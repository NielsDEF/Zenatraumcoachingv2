#pragma checksum "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7daa8ac408ab8c68b3c868e457f47686ac9a340c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7daa8ac408ab8c68b3c868e457f47686ac9a340c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa8a9bfa514def840976adab4a383805ca963c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Homepagina.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Niels\Documents\GitHub\Zenatraumcoachingv2\ZenaTraumacoaching\ZenaTraumacoaching\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_LayoutNonUser.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7daa8ac408ab8c68b3c868e457f47686ac9a340c4799", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7daa8ac408ab8c68b3c868e457f47686ac9a340c5065", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7daa8ac408ab8c68b3c868e457f47686ac9a340c7034", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-6"">
            <h1>Zena trauma- en paardencoaching</h1>
            <p>
                Om jezelf weer terug te vinden wie je ooit was en feitelijk nog altijd bent
            </p>
        </div>
    </div>
    <!-- ----------Home------ -->
    <section class=""Home-section"">
        <div class=""container"">
            <div class=""heading white-heading"">
                <span>Ik help je bevriend te worden met de klappen die je hebt gekregen in het leven, om er sterker uit te komen en weer echt te leven!</span>
            </div>
            <div class=""row"">
                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""Home-block"">
                        <div class=""inner-box"">
                            <div class=""lower-content"">
                                <h3>Trauma coaching</h3>
                                <div class=""text"">Bij trauma’s denkt men vaak aan een heftig auto ongeluk, brand, oorlog en natu");
                WriteLiteral(@"urgeweld. Trauma is echter veel meer, het kan bestaan uit één of meerdere heftige gebeurtenissen die een traumatische ervaring oproepen. Vaak is er nog onbegrip in de samenleving en zegt men “Niet klagen, maar dragen” of “ieder huisje heeft wel een kruisje, geef het een plekje en ga door met je leven”. Hoe vaak heb jij door deze opmerkingen al niet gedacht, ‘zal er maar niet weer over beginnen’, houdt jij je tranen in en zet een pokerface op.  Zo gemakkelijk werkt het echter niet en je komt je dan ook meerdere malen tegen in diverse situaties zowel privé als op het werk. Wanneer jij dit wilt aanpakken en veranderen, weer wilt gaan leren leven, dan is er héél veel mogelijk. Ondanks je opgelopen trauma, welke je dan kan gaan inzetten als je kracht. </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""Home-block"">
                        <div class=");
                WriteLiteral(@"""inner-box"">
                            <div class=""lower-content"">
                                <h3>Verlies & Rouw</h3>
                                <div class=""text"">Eén ding is zeker…., we worden allemaal een keer geconfronteerd met het verlies van iemand of iets in ons leven. Bij verlies en rouw denkt men vaak aan het verlies van iemand aan de dood. Bij alle soorten verlies geldt dat er iets sterft binnen in je en je hebt arbeid te verrichten, de rouwtaken. Deze rouwtaken is iets wat samen met anderen dient te gebeuren, je kan dit niet alleen en ik ben hier om jou daarbij te helpen en te begeleiden. Vanuit kennis, kunde en eigen ervaringen. </div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""Home-block"">
                        <div class=""inner-box"">
                            <div class=""lower-content"">
                     ");
                WriteLiteral(@"           <h3>Paardencoaching</h3>
                                <div class=""text"">
                                    Paardencoaching is voor iedereen bedoeld die tegen bepaalde belemmeringen/ blokkades aanloopt, een bepaald vraagstuk heeft of telkens met eenzelfde thema geconfronteerd wordt in het leven. De paarden zijn essentieel in jouw persoonlijke ontwikkeling, zij luisteren namelijk niet naar jouw pogingen om gevoelens en emoties te verbergen of af te zwakken. De paarden reageren altijd op jouw energie die je bij je draagt en wat op dat moment het hoogste spanningsniveau met zich meedraagt.

                                    Binnen een fractie van tijd heeft het paard jou gescreend en zal het paard jou gaan spiegelen, helpen of steunen. De paarden leggen direct de vinger op de zere plek bij jou. Zij, met de doorvertaling van het paardengedrag door mij, laten jou zien waar een blokkade bij jou zit, dit is vaak in de diepere (onbewuste) laag. Dit kan confronterend en zeker ook verhelderend werk");
                WriteLiteral(@"en voor jou, waarmee jouw bewustwording- en ontwikkelingsproces in een versnelling raakt en je de antwoorden in jezelf vindt op je vraagstukken.
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""Home-block"">
                        <div class=""inner-box"">
                            <div class=""lower-content"">
                                <h3>Wie ben ik……</h3>
                                <div class=""text"">
                                    Achter Zena Trauma- & Paardencoaching zit Marieke Blankers-van Loon. Getrouwd, geen kinderen wel héél veel dieren om de onvoorwaardelijke liefde te ervaren en te compenseren die ik in mijn jeugd zo heb gemist.

                                    Ervaringsexpert op het gebied van trauma’s, mijn leven heeft vanaf mijn 3e levensjaar tot en met mijn 40ste levens");
                WriteLiteral(@"jaar in teken gestaan van diverse trauma’s (o.a. narcisme, misbruik, stalking, inbraak, verlies van een dierbare als een levend verlies). Maar nu niet meer! Nu ben ik echt aan het leven en aan het genieten van het leven. En ik gun jou ook die ervaring! Vandaar dat ik mijn levenservaring op gebied van trauma heb omgezet in een kracht en samen met mijn jarenlange werkervaring waarin coaching een belangrijk onderdeel vormde én de opgedane kennis vanuit relevante (trauma) opleidingen maakt dat ik klaar sta als trauma coach én paardencoach om jou te helpen en te begeleiden.
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
    <!-- ----------Home-close------ -->
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
            WriteLiteral("\r\n   ");
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
