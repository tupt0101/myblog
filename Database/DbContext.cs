using FinalProject_Blog.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Database
{
    public class DbContext
    {
        string strConnection;
        public DbContext()
        {
            strConnection = "server=.;database=BlogDB;uid=sa;pwd=12345678";
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
                    lstPost.Add(post);
                }
                conn.Close();
            }
            return lstPost;
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
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand("Tag_Load", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Tag> result = new List<Tag>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    result.Add(new Tag
                    {
                        Id = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        UrlSlug = dr.GetString(2),
                        Description = dr.GetString(3)
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
    }
}
