#pragma checksum "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c901449b51536604fcc727218ae3bb052c6cfcec"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c901449b51536604fcc727218ae3bb052c6cfcec", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f11e6f8d66474edbc63c6d1fd343dcc57d7673", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn caegory-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn read-more-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 129, true);
            WriteLiteral("\r\n<div class=\"text-center\" style=\"margin-bottom: 20px\">\r\n    <a class=\"btn\" style=\"width: 100%\"><h5>MỚI NHẤT</h5></a>\r\n</div>\r\n\r\n");
            EndContext();
#line 7 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
 foreach (var item in Model.Posts)
{

#line default
#line hidden
            BeginContext(194, 70, true);
            WriteLiteral("    <div class=\"single-post\">\r\n        <div class=\"image-wrapper\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 264, "\"", 282, 1);
#line 10 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 270, item.ImgSrc, 270, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(283, 72, true);
            WriteLiteral(" runat=\"server\" alt=\"Blog Image\"></div>\r\n\r\n        <div class=\"icons\">\r\n");
            EndContext();
#line 13 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
             foreach (var tag in item.Tags)
            {

#line default
#line hidden
            BeginContext(415, 87, true);
            WriteLiteral("                <div class=\"left-area\" style=\"margin-right: 5px\">\r\n                    ");
            EndContext();
            BeginContext(502, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0696aff25f64a49ad0e47d0855b7491", async() => {
                BeginContext(594, 3, true);
                WriteLiteral("<b>");
                EndContext();
                BeginContext(598, 8, false);
#line 16 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
                                                                                                              Write(tag.Name);

#line default
#line hidden
                EndContext();
                BeginContext(606, 4, true);
                WriteLiteral("</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tagId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
                                                                                           WriteLiteral(tag.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tagId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tagId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tagId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(614, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 18 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(655, 291, true);
            WriteLiteral(@"            <ul class=""right-area social-icons"">
                <li><a href=""#""><i class=""ion-android-share-alt""></i>Share</a></li>
                <li><a href=""#""><i class=""ion-android-favorite-outline""></i>03</a></li>
                <li><a href=""#""><i class=""ion-android-textsms""></i>");
            EndContext();
            BeginContext(947, 17, false);
#line 22 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
                                                              Write(item.NumOfComment);

#line default
#line hidden
            EndContext();
            BeginContext(964, 86, true);
            WriteLiteral("</a></li>\r\n            </ul>\r\n        </div>\r\n        <h2 class=\"title\">\r\n            ");
            EndContext();
            BeginContext(1050, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d07e37113e4d40b3164a07dd56a04f", async() => {
                BeginContext(1123, 41, true);
                WriteLiteral("\r\n                <b class=\"light-color\">");
                EndContext();
                BeginContext(1165, 40, false);
#line 27 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(1205, 18, true);
                WriteLiteral("</b>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
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
            BeginContext(1227, 45, true);
            WriteLiteral("\r\n        </h2>\r\n        <p class=\"date\"><em>");
            EndContext();
            BeginContext(1273, 43, false);
#line 30 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PostedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 36, true);
            WriteLiteral("</em></p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1353, 51, false);
#line 32 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 24, true);
            WriteLiteral("\r\n        </p>\r\n        ");
            EndContext();
            BeginContext(1428, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f309af82cf4c329d6c69c22b88e2a7", async() => {
                BeginContext(1527, 16, true);
                WriteLiteral("<b>READ MORE</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
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
            BeginContext(1547, 34, true);
            WriteLiteral("\r\n    </div><!-- single-post -->\r\n");
            EndContext();
#line 36 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Home\Index.cshtml"
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
