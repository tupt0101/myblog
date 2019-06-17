using FluentNHibernate.Mapping;
using Personal_Blog.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal_Blog.Mappings
{
    public class TagMap : ClassMap<Tag>
    {
        public TagMap()
        {
            Id(x => x.Id);

            Map(x => x.Name).Length(100).Not.Nullable();

            Map(x => x.UrlSlug).Length(100).Not.Nullable();

            Map(x => x.Description).Length(300).Not.Nullable();

            HasManyToMany(x => x.Posts).Cascade.All().Inverse().Table("PostTagMap");
        }
    }
}