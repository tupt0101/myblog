using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using NHibernate.Transform;
using System.ServiceModel.Channels;
using System.Web;
using Personal_Blog.DTOs;

namespace Personal_Blog
{
    public class BlogRepository : IBlogRepository
    {
        private readonly NHibernate.ISession _session;
        public BlogRepository(NHibernate.ISession session)
        {
            _session = session;
        }
        public IList<Post> Posts(int pageNum, int pageSize)
        {
            var posts = _session.Query<Post>().Where(p => p.Published)
                                  .OrderByDescending(p => p.PostedOn)
                                  .Skip(pageNum * pageSize)
                                  .Take(pageSize)
                                  .Fetch(p => p.Category)
                                  .ToList();
            var postIds = posts.Select(p => p.Id).ToList();
            return _session.Query<Post>()
                            .Where(p => postIds.Contains(p.Id))
                            .OrderByDescending(p => p.PostedOn)
                            .FetchMany(p => p.Tags)
                            .ToList();
        }

        public int TotalPosts()
        {
            return _session.Query<Post>().Where(p => p.Published).Count();
        }
    }
}