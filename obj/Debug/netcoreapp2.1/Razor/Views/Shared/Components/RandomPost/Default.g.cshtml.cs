#pragma checksum "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Shared\Components\RandomPost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d84228737bbc6bc99c2af3c89e16aa015de2a5b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RandomPost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RandomPost/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RandomPost/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_RandomPost_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d84228737bbc6bc99c2af3c89e16aa015de2a5b7", @"/Views/Shared/Components/RandomPost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f11e6f8d66474edbc63c6d1fd343dcc57d7673", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RandomPost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Shared\Components\RandomPost\Default.cshtml"
 foreach (var post in Model)
{

#line default
#line hidden
            BeginContext(33, 127, true);
            WriteLiteral("    <div class=\"latest-post\" href=\"#\">\r\n        <div class=\"post-info\" style=\"width: 100%; margin-left: 0px\">\r\n            <h5>");
            EndContext();
            BeginContext(160, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "870a4f596d5842b992357d76ac25890e", async() => {
                BeginContext(233, 23, true);
                WriteLiteral("<b class=\"light-color\">");
                EndContext();
                BeginContext(257, 10, false);
#line 5 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Shared\Components\RandomPost\Default.cshtml"
                                                                                                           Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(267, 4, true);
                WriteLiteral("</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 5 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Shared\Components\RandomPost\Default.cshtml"
                                                                   WriteLiteral(post.Id);

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
            BeginContext(275, 40, true);
            WriteLiteral("</h5>\r\n            <h6 class=\"date\"><em>");
            EndContext();
            BeginContext(316, 13, false);
#line 6 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Shared\Components\RandomPost\Default.cshtml"
                            Write(post.PostedOn);

#line default
#line hidden
            EndContext();
            BeginContext(329, 40, true);
            WriteLiteral("</em></h6>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 9 "D:\FPT\Semester 5\PRN292\Repository\FinalProject-Blog\FinalProject-Blog\Views\Shared\Components\RandomPost\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
