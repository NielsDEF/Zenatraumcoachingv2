#pragma checksum "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Account\Profiel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aee497e31fb3d8b3e8ae4ccff6538092f686adb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profiel), @"mvc.1.0.view", @"/Views/Account/Profiel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee497e31fb3d8b3e8ae4ccff6538092f686adb2", @"/Views/Account/Profiel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa8a9bfa514def840976adab4a383805ca963c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profiel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZenaTraumacoaching.Models.ProfileViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Account\Profiel.cshtml"
   ViewData["Title"] = "Profiel";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js%22%3E\"></script>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js\"></script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee497e31fb3d8b3e8ae4ccff6538092f686adb23789", async() => {
                WriteLiteral("\r\n    <h3>Accountgegevens</h3>\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-4\">\r\n            <div class=\"container\" id=\"AccountGegevens\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-2\">\r\n                        <label>");
#nullable restore
#line 17 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Account\Profiel.cshtml"
                          Write(Model.Firstname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Account\Profiel.cshtml"
                                           Write(Model.Lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"col-2\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-2\">\r\n                        <label>");
#nullable restore
#line 24 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Account\Profiel.cshtml"
                          Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"col-2\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-2\">\r\n                        <label>");
#nullable restore
#line 31 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Account\Profiel.cshtml"
                          Write(Model.Gender);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                    </div>
                    <div class=""col-2"">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <table class=""buttons"">
        <tr>
            <td><button type=""button"">Hoofdmenu</button>
            <td><button type=""button"">Button</button>
            <td><button type=""button"">Button</button>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    label {
        display: block;
        padding-left: 15px;
        text-indent: -15px;
    }

    input {
        width: 13px;
        height: 16px;
        padding: 0;
        margin: 0;
        vertical-align: bottom;
        position: relative;
        top: -1px;
        *overflow: hidden;
    }



    .buttons {
        display: block;
        position: absolute;
        top: 80px;
        right: 100px;
        width: 60%;
        table-layout: fixed;
        border-collapse: collapse;
    }

        .buttons button {
            width: 100%;
        }
</style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZenaTraumacoaching.Models.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
