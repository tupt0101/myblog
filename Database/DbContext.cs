using FinalProject_Blog.Models;
using FinalProject_Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Blog.Database
{
    public class DbContext
    {
        string strConnection;

        public DbContext()
        {
            strConnection = GetConnectionString();
        }

        public static string GetConnectionString()
        {
            return Startup.ConnectionString;
        }

        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        public User CheckLogin(string email, string password)
        {
            User u = new User();
            if (string.IsNullOrEmpty(password))
            {
                return u;
            }
            string encryptPwd = EncodePasswordToBase64(password);
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("CheckLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", encryptPwd);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u.Email = email;
                    u.Password = password;
                    u.Role = dr["Role"].ToString();
                }
            }
            return u;
        }

        public IEnumerable<Post> GetPost(int pageIndex, int pageSize)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand("Post_LazyLoad", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@pageSize", pageSize);
            List<Post> result = new List<Post>();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                da.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    result.Add(new Post
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Title = dr["Title"].ToString(),
                        ShortDescription = dr["ShortDescription"].ToString(),
                        Description = dr["Description"].ToString(),
                        ImgSrc = dr["ImgSrc"].ToString(),
                        Author = dr["Author"].ToString(),
                        UrlSlug = dr["UrlSlug"].ToString(),
                        Published = Convert.ToBoolean(dr["Published"]),
                        PostedOn = Convert.ToDateTime(dr["PostedOn"]),
                        Modified = Convert.ToDateTime(dr["Modified"])
                    });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<Tag> LoadTagToPost(int postId)
        {
            List<Tag> tags = new List<Tag>();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("LoadTagToPost", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@postId", postId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tags.Add(new Tag
                    {
                        Id = Convert.ToInt32(dr["Tag_Id"]),
                        Name = dr["Name"].ToString(),
                        UrlSlug = dr["UrlSlug"].ToString(),
                        Description = dr["Description"].ToString()
                    });
                }
            }
            return tags;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            List<Post> lstPost = new List<Post>();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Post_Load", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Post post = new Post();
                    post.Id = Convert.ToInt32(dr["Id"]);
                    post.Title = dr["Title"].ToString();
                    post.ShortDescription = dr["ShortDescription"].ToString();
                    post.Description = dr["Description"].ToString();
                    post.ImgSrc = dr["ImgSrc"].ToString();
                    post.Author = dr["Author"].ToString();
                    post.UrlSlug = dr["UrlSlug"].ToString();
                    post.Published = dr.GetBoolean(dr.GetOrdinal("Published"));
                    post.PostedOn = Convert.ToDateTime(dr["PostedOn"]);
                    post.Category = dr["Category"].ToString();
                    post.NumOfComment = CountOfComment(post.Id);
                    post.Tags = LoadTagToPost(post.Id);
                    lstPost.Add(post);
                }
                conn.Close();
            }
            return lstPost;
        }

        public List<Post> LoadPostToTag(int tagId)
        {
            List<Post> posts = new List<Post>();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("LoadPostToTag", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tagId", tagId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Post post = new Post();
                    post.Id = Convert.ToInt32(dr["Post_Id"]);
                    post.Title = dr["Title"].ToString();
                    post.ShortDescription = dr["ShortDescription"].ToString();
                    post.Description = dr["Description"].ToString();
                    post.ImgSrc = dr["ImgSrc"].ToString();
                    post.Author = dr["Author"].ToString();
                    post.UrlSlug = dr["UrlSlug"].ToString();
                    post.Published = dr.GetBoolean(dr.GetOrdinal("Published"));
                    post.PostedOn = Convert.ToDateTime(dr["PostedOn"]);
                    post.Category = dr["Category"].ToString();
                    post.NumOfComment = CountOfComment(post.Id);
                    post.Tags = LoadTagToPost(post.Id);
                    posts.Add(post);
                }
                conn.Close();
            }
            return posts;
        }

        public Post GetPostById(int Id)
        {
            Post post = new Post();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("GetPostById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    post.Id = Id;
                    post.Title = dr["Title"].ToString();
                    post.ShortDescription = dr["ShortDescription"].ToString();
                    post.Description = dr["Description"].ToString();
                    post.ImgSrc = dr["ImgSrc"].ToString();
                    post.Author = dr["Author"].ToString();
                    post.UrlSlug = dr["UrlSlug"].ToString();
                    post.Published = dr.GetBoolean(dr.GetOrdinal("Published"));
                    post.PostedOn = Convert.ToDateTime(dr["PostedOn"]);
                    post.NumOfComment = CountOfComment(Id);
                    post.Tags = LoadTagToPost(post.Id);
                }
                conn.Close();
            }
            return post;
        }

        public IEnumerable<Post> GetPostByCategoryId(int categoryId)
        {
            List<Post> listPost = new List<Post>();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Post_Load_By_Category", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Post post = new Post
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Title = dr["Title"].ToString(),
                        ShortDescription = dr["ShortDescription"].ToString(),
                        Description = dr["Description"].ToString(),
                        ImgSrc = dr["ImgSrc"].ToString(),
                        Author = dr["Author"].ToString(),
                        UrlSlug = dr["UrlSlug"].ToString(),
                        Published = dr.GetBoolean(dr.GetOrdinal("Published")),
                        PostedOn = Convert.ToDateTime(dr["PostedOn"]),
                        Category = dr["Category"].ToString()
                };
                    post.NumOfComment = CountOfComment(post.Id);
                    post.Tags = LoadTagToPost(post.Id);
                    listPost.Add(post);
                }
                conn.Close();
            }
            return listPost;
        }

        public IEnumerable<Post> GetRandomPost()
        {
            List<Post> listPost = new List<Post>();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Post_Random", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listPost.Add(new Post
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Title = dr["Title"].ToString(),
                        ShortDescription = dr["ShortDescription"].ToString(),
                        Description = dr["Description"].ToString(),
                        ImgSrc = dr["ImgSrc"].ToString(),
                        Author = dr["Author"].ToString(),
                        UrlSlug = dr["UrlSlug"].ToString(),
                        Published = dr.GetBoolean(dr.GetOrdinal("Published")),
                        PostedOn = Convert.ToDateTime(dr["PostedOn"]),
                        Category = dr["Category"].ToString()
                    });
                }
                conn.Close();
            }
            return listPost;
        }

        public IEnumerable<Post> SearchByKey(string searchKey)
        {
            List<Post> listPost = new List<Post>();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Post_Search", conn);
                cmd.Parameters.AddWithValue("@searchKey", searchKey);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Post post = new Post
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Title = dr["Title"].ToString(),
                        ShortDescription = dr["ShortDescription"].ToString(),
                        Description = dr["Description"].ToString(),
                        ImgSrc = dr["ImgSrc"].ToString(),
                        Author = dr["Author"].ToString(),
                        UrlSlug = dr["UrlSlug"].ToString(),
                        Published = dr.GetBoolean(dr.GetOrdinal("Published")),
                        PostedOn = Convert.ToDateTime(dr["PostedOn"]),
                        Category = dr["Category"].ToString()
                    };
                    post.NumOfComment = CountOfComment(post.Id);
                    post.Tags = LoadTagToPost(post.Id);
                    listPost.Add(post);
                }
                conn.Close();
            }
            return listPost;
        }

        public bool SaveSubscribeEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Subscribe_Email", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                conn.Close();
                return count > 0;
            }
        }

        public bool CreatePost(Post post)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("CreatePost", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", post.Title);
                cmd.Parameters.AddWithValue("@ShortDescription", post.ShortDescription);
                cmd.Parameters.AddWithValue("@Description", post.Description);
                cmd.Parameters.AddWithValue("@ImgSrc", post.ImgSrc);
                cmd.Parameters.AddWithValue("@Author", post.Author);
                cmd.Parameters.AddWithValue("@UrlSlug", post.UrlSlug);
                cmd.Parameters.AddWithValue("@Published", post.Published);
                cmd.Parameters.AddWithValue("@PostedOn", post.PostedOn);
                cmd.Parameters.AddWithValue("@Category", post.Category);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdatePost(Post post)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("UpdatePost", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", post.Id);
                cmd.Parameters.AddWithValue("@Title", post.Title);
                cmd.Parameters.AddWithValue("@ShortDescription", post.ShortDescription);
                cmd.Parameters.AddWithValue("@Description", post.Description);
                cmd.Parameters.AddWithValue("@ImgSrc", post.ImgSrc);
                cmd.Parameters.AddWithValue("@Author", post.Author);
                cmd.Parameters.AddWithValue("@UrlSlug", post.UrlSlug);
                cmd.Parameters.AddWithValue("@Published", post.Published);
                cmd.Parameters.AddWithValue("@Modified", post.Modified);
                cmd.Parameters.AddWithValue("@Category", post.Category);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeletePost(int postId)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("DeletePost", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", postId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// All actions with Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public IEnumerable<Category> GetAllCategories()
        {
            List<Category> lstCate = new List<Category>();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Category_Load", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lstCate.Add(new Category
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        UrlSlug = dr["UrlSlug"].ToString(),
                        Description = dr["Description"].ToString()
                    });

                }
                conn.Close();
            }
            return lstCate;
        }

        public bool CreateCategory(Category category)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("CreateCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.Parameters.AddWithValue("@UrlSlug", category.UrlSlug);
                cmd.Parameters.AddWithValue("@Description", category.Description);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Category GetCategoryById(int Id)
        {
            Category cat = new Category();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("GetCategoryById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cat.Id = Id;
                    cat.Name = dr["Name"].ToString();
                    cat.UrlSlug = dr["UrlSlug"].ToString();
                    cat.Description = dr["Description"].ToString();
                }
                conn.Close();
            }
            return cat;
        }

        public bool UpdateCategory(Category category)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("UpdateCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", category.Id);
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.Parameters.AddWithValue("@UrlSlug", category.UrlSlug);
                cmd.Parameters.AddWithValue("@Description", category.Description);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteCategory(int id)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("DeleteCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// All actions with Tag
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tag> GetAllTags()
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Tag_Load", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                List<Tag> result = new List<Tag>();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Tag tag = new Tag();
                    tag.Id = dr.GetInt32(0);
                    tag.Name = dr.GetString(1);
                    tag.UrlSlug = dr.GetString(2);
                    tag.Description = dr.GetString(3) ?? "";
                    result.Add(tag);

                }
                return result;
            }
        }

        public bool CreateTag(Tag tag)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("CreateTag", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", tag.Name);
                cmd.Parameters.AddWithValue("@UrlSlug", tag.UrlSlug);
                cmd.Parameters.AddWithValue("@Description", tag.Description);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Tag GetTagById(int Id)
        {
            Tag tag = new Tag();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("GetTagById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tag.Id = Id;
                    tag.Name = dr["Name"].ToString();
                    tag.UrlSlug = dr["UrlSlug"].ToString();
                    tag.Description = dr["Description"].ToString();
                }
                conn.Close();
            }
            return tag;
        }

        public bool UpdateTag(Tag tag)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("UpdateTag", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", tag.Id);
                cmd.Parameters.AddWithValue("@Name", tag.Name);
                cmd.Parameters.AddWithValue("@UrlSlug", tag.UrlSlug);
                cmd.Parameters.AddWithValue("@Description", tag.Description);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteTag(int id)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("DeleteTag", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// All actions with comment
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public IEnumerable<Comment> LoadComment(int postId)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Comment_Load", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                List<Comment> list = new List<Comment>();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Comment {
                        Id = Convert.ToInt32(dr["Id"]),
                        Username = dr["Username"].ToString(),
                        Email = dr["Email"].ToString(),
                        PostedOn = Convert.ToDateTime(dr["PostedOn"]),
                        CmtContent = dr["CmtContent"].ToString(),
                        PostId = postId
                    });

                }
                return list;
            }
        }

        public int CountOfComment(int postId)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("Comment_Count", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    count = Convert.ToInt32(dr["NumOfCmt"]);
                }
                return count;
            }
        }

        public bool CreateComment(Comment cmt)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand("CreateComment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", cmt.Username);
                cmd.Parameters.AddWithValue("@Email", cmt.Email);
                cmd.Parameters.AddWithValue("@PostedOn", cmt.PostedOn);
                cmd.Parameters.AddWithValue("@CmtContent", cmt.CmtContent);
                cmd.Parameters.AddWithValue("@PostId", cmt.PostId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
