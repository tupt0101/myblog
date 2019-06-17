using FluentNHibernate.Mapping;
using Personal_Blog.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal_Blog.Mappings
{
    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(x => x.Id);

            Map(x => x.Title).Length(300).Not.Nullable();

            Map(x => x.ShortDescription).Length(500).Not.Nullable();

            Map(x => x.Description).Length(5000).Not.Nullable();

            Map(x => x.Meta).Length(300).Not.Nullable();

            Map(x => x.UrlSlug).Length(100).Not.Nullable();

            Map(x => x.Published).Not.Nullable();

            Map(x => x.PostedOn).Not.Nullable();

            Map(x => x.Modified);
            
            //Many-one relationship
            References(x => x.Category).Column("Category").Not.Nullable();
            //Many-many relationship
            HasManyToMany(x => x.Tags).Table("PostTagMap");
        }
    }
}