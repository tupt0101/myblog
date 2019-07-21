using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using FinalProject_Blog.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Session;

namespace FinalProject_Blog
{
    public class Startup
    {
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        public static string ConnectionString { get; private set; }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Allow app use custom interfaces
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ITagRepository, TagRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<IUserManager, UserManager>();

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".AdventureWorks.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(1800);
                options.Cookie.IsEssential = true;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "categoryFilter", 
                    template: "Post/{action}/{categoryId?}", 
                    defaults: new { Controller = "Post", Action = "Category"});
                routes.MapRoute(
                    name: "search",
                    template: "Post/{action}/{searchKey?}",
                    defaults: new { Controller = "Post", Action = "Search" });
                routes.MapRoute(
                    name: "subscribe",
                    template: "Post/{action}/{email?}",
                    defaults: new { Controller = "Post", Action = "Subscribe" });
            });
        }
    }
}
