#pragma checksum "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56c89f11cc2bd8d6cec409c6329a501efe3e396c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zena_Blogpagina), @"mvc.1.0.view", @"/Views/Zena/Blogpagina.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\_ViewImports.cshtml"
using ZenaTraumacoaching;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\_ViewImports.cshtml"
using ZenaTraumacoaching.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c89f11cc2bd8d6cec409c6329a501efe3e396c", @"/Views/Zena/Blogpagina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa8a9bfa514def840976adab4a383805ca963c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Zena_Blogpagina : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogpaginaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Blogpaginastyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
   ViewData["Title"] = "BlogPagina";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56c89f11cc2bd8d6cec409c6329a501efe3e396c4696", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56c89f11cc2bd8d6cec409c6329a501efe3e396c4958", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>De Zenacoaching Blog</h1>\r\n    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 267, "\"", 319, 3);
            WriteAttributeValue("", 277, "location.href=\'", 277, 15, true);
#nullable restore
#line 8 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
WriteAttributeValue("", 292, Url.Action("blog","Zena"), 292, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 318, "\'", 318, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Toevoegen</button>\r\n");
#nullable restore
#line 9 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
     foreach (var blog in Model.blog)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table-fill"">
            <thead>
                <tr>
                    <th>Titel</th>
                    <th>Tekst</th>
                    <th></th>
                </tr>
            </thead>
            <tbody class=""table-hover"">
                <tr>
                    <td class=""text-left"">
                        ");
#nullable restore
#line 22 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
                   Write(blog.BlogTitel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
                   Write(blog.BlogTekst);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                        <td class=\"text-left\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 979, "\"", 1024, 2);
            WriteAttributeValue("", 986, "/Zena/BlogPostDeleteClick/", 986, 26, true);
#nullable restore
#line 28 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
WriteAttributeValue("", 1012, blog.BlogID, 1012, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1106, 2);
            WriteAttributeValue("", 1075, "/Zena/BlogBewerken/", 1075, 19, true);
#nullable restore
#line 29 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
WriteAttributeValue("", 1094, blog.BlogID, 1094, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                        </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 34 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Zena\Blogpagina.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogpaginaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
