using FluentNHibernate.Mapping;
using Personal_Blog.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal_Blog.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);

            Map(x => x.Name).Length(100).Not.Nullable();

            Map(x => x.UrlSlug).Length(100).Not.Nullable();

            Map(x => x.Description).Length(300).Not.Nullable();

            HasMany(x => x.Posts).Inverse().Cascade.All().KeyColumn("Category");
        }
    }
}