#pragma checksum "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b8997e895f5715845ac7fa607539cedc6db7e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Search), @"mvc.1.0.view", @"/Views/Post/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Search.cshtml", typeof(AspNetCore.Views_Post_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b8997e895f5715845ac7fa607539cedc6db7e8", @"/Views/Post/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f11e6f8d66474edbc63c6d1fd343dcc57d7673", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn read-more-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(88, 102, true);
            WriteLiteral("\r\n\r\n<div class=\"text-center\" style=\"margin-bottom: 20px\">\r\n    <a class=\"btn\" style=\"width: 100%\"><h5>");
            EndContext();
            BeginContext(191, 21, false);
#line 7 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
                                      Write(Model.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(212, 21, true);
            WriteLiteral("</h5></a>\r\n</div>\r\n\r\n");
            EndContext();
#line 10 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
 if (@Model.Posts.ToList().Count > 0)
{
    

#line default
#line hidden
#line 12 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
     foreach (var item in Model.Posts)
    {

#line default
#line hidden
            BeginContext(322, 78, true);
            WriteLiteral("        <div class=\"single-post\">\r\n            <div class=\"image-wrapper\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 400, "\"", 418, 1);
#line 15 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
WriteAttributeValue("", 406, item.ImgSrc, 406, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 76, true);
            WriteLiteral(" runat=\"server\" alt=\"Blog Image\"></div>\r\n\r\n            <div class=\"icons\">\r\n");
            EndContext();
            BeginContext(647, 319, true);
            WriteLiteral(@"                <ul class=""right-area social-icons"">
                        <li><a href=""#""><i class=""ion-android-share-alt""></i>Share</a></li>
                        <li><a href=""#""><i class=""ion-android-favorite-outline""></i>03</a></li>
                        <li><a href=""#""><i class=""ion-android-textsms""></i>");
            EndContext();
            BeginContext(967, 17, false);
#line 24 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
                                                                      Write(item.NumOfComment);

#line default
#line hidden
            EndContext();
            BeginContext(984, 123, true);
            WriteLiteral("</a></li>\r\n                    </ul>\r\n            </div>\r\n            <h2 class=\"title\"><a href=\"#\"><b class=\"light-color\">");
            EndContext();
            BeginContext(1108, 40, false);
#line 27 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 47, true);
            WriteLiteral("</b></a></h2>\r\n            <p class=\"date\"><em>");
            EndContext();
            BeginContext(1196, 43, false);
#line 28 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PostedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 44, true);
            WriteLiteral("</em></p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(1284, 51, false);
#line 30 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 32, true);
            WriteLiteral("\r\n            </p>\r\n            ");
            EndContext();
            BeginContext(1367, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7858450ef234c83b8005bff80f7d1a0", async() => {
                BeginContext(1466, 16, true);
                WriteLiteral("<b>READ MORE</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1486, 38, true);
            WriteLiteral("\r\n        </div><!-- single-post -->\r\n");
            EndContext();
#line 34 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
    }

#line default
#line hidden
#line 34 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(1543, 29, true);
            WriteLiteral("    <p>No record found.</p>\r\n");
            EndContext();
#line 39 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Post\Search.cshtml"
}

#line default
#line hidden
            BeginContext(1575, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
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
