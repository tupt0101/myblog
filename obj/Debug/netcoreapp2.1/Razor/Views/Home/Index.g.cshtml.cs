#pragma checksum "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d25bc75d2f3f6f35e18d5664ccdd56beb57a95d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\_ViewImports.cshtml"
using FinalProject_Blog;

#line default
#line hidden
#line 2 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\_ViewImports.cshtml"
using FinalProject_Blog.Models;

#line default
#line hidden
#line 3 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\_ViewImports.cshtml"
using FinalProject_Blog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d25bc75d2f3f6f35e18d5664ccdd56beb57a95d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f11e6f8d66474edbc63c6d1fd343dcc57d7673", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
 foreach (var item in Model.Posts)
{

#line default
#line hidden
            BeginContext(125, 160, true);
            WriteLiteral("    <div class=\"single-post\">\r\n        <div class=\"image-wrapper\"><img src=\"images/blog-1-1000x600.jpg\" alt=\"Blog Image\"></div>\r\n\r\n        <div class=\"icons\">\r\n");
            EndContext();
            BeginContext(744, 77, true);
            WriteLiteral("        </div>\r\n        <h2 class=\"title\"><a href=\"#\"><b class=\"light-color\">");
            EndContext();
            BeginContext(822, 40, false);
#line 22 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
                                                        Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(862, 43, true);
            WriteLiteral("</b></a></h2>\r\n        <p class=\"date\"><em>");
            EndContext();
            BeginContext(906, 43, false);
#line 23 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PostedOn));

#line default
#line hidden
            EndContext();
            BeginContext(949, 36, true);
            WriteLiteral("</em></p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(986, 51, false);
#line 25 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 116, true);
            WriteLiteral("\r\n        </p>\r\n        <a class=\"btn read-more-btn\" href=\"#\"><b>READ MORE</b></a>\r\n    </div><!-- single-post -->\r\n");
            EndContext();
#line 29 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
