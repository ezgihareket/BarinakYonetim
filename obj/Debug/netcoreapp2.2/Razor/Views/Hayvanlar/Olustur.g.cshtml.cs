#pragma checksum "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b0fd81f872f6a49cd5270f99353ffbc095ab7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hayvanlar_Olustur), @"mvc.1.0.view", @"/Views/Hayvanlar/Olustur.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hayvanlar/Olustur.cshtml", typeof(AspNetCore.Views_Hayvanlar_Olustur))]
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
#line 1 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\_ViewImports.cshtml"
using Dost.Patiler.Barinak;

#line default
#line hidden
#line 2 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\_ViewImports.cshtml"
using Dost.Patiler.Barinak.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b0fd81f872f6a49cd5270f99353ffbc095ab7c", @"/Views/Hayvanlar/Olustur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30ad5344f22f7b1c20030be11aba1dd4066314d", @"/Views/_ViewImports.cshtml")]
    public class Views_Hayvanlar_Olustur : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/hayvanlar/kaydet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("FormAlani"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1564, true);
            WriteLiteral(@"<!-- Üst Başlangıç -->
<div id=""ctl00_cph1_UzunAlan1_panel_alan_4"">


</div>
<!-- Üst Son -->
<section style=""background-color:#FFC061""
    class=""page-header page-header-center  page-header-primary page-header-color page-header-more-padding page-header-no-title-border"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h1 style=""font-size:40px;color:#FFF829"">
                    Hayvanları Kaydet
                </h1>
            </div>
        </div>
    </div>
</section>

<div class=""container"" id=""girisyap"">

    <div class=""row"">
        <div class=""col-md-12"">
            <div id=""ctl00_cph1_PanelOrta"">


                <!-- OrtaAlan2 Başlangıç -->
                <div id=""ctl00_cph1_ctl00_panel_orta"">


                    <!-- ##Blok -->

                    <div class=""Blok"" id=""Uyelik_uyeol"">
                        <div class=""Area"">

                            <div class=""col-md-12"">
                    ");
            WriteLiteral(@"            <div class=""col-md-2""></div>
                                <div class=""col-md-8""
                                    data-appear-animation=""wobble"">

                                </div>
                            </div>
                            <div id=""ctl00_cph1_ctl00_ctl00_Panel4"">


                                <div class=""col-md-2""></div>
                                <div class=""col-md-8""
                                    data-appear-animation=""wobble"">
                                    ");
            EndContext();
            BeginContext(1564, 5982, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b0fd81f872f6a49cd5270f99353ffbc095ab7c6136", async() => {
                BeginContext(1629, 69, true);
                WriteLiteral("\r\n                                     <input hidden name=\"hayvan_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1698, "\"", 1722, 1);
#line 50 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 1706, Model.hayvan_id, 1706, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1723, 442, true);
                WriteLiteral(@" />
                                        <div class=""col-md-12  margin-bottom"">
                                            <div class=""col-md-12 margin-bottom"">
                                                Hayvan Adı (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""ad""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2165, "\"", 2182, 1);
#line 56 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 2173, Model.ad, 2173, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2183, 518, true);
                WriteLiteral(@" type=""text"" maxlength=""70"" class=""form-control"">
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Cinsiyet (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""cinsiyet""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2701, "\"", 2724, 1);
#line 63 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 2709, Model.cinsiyet, 2709, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2725, 535, true);
                WriteLiteral(@" class=""form-control"">
                                                    
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Tip (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""tip""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3260, "\"", 3278, 1);
#line 71 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 3268, Model.tip, 3268, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3279, 534, true);
                WriteLiteral(@" class=""form-control"">
                                                   
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Yas (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""yas""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3813, "\"", 3831, 1);
#line 79 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 3821, Model.yas, 3821, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3832, 489, true);
                WriteLiteral(@" class=""form-control"">
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Ağırlık (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""agirlik""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4321, "\"", 4343, 1);
#line 86 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 4329, Model.agirlik, 4329, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4344, 483, true);
                WriteLiteral(@" class=""form-control"">
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Renk (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""renk""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4827, "\"", 4846, 1);
#line 93 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 4835, Model.renk, 4835, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4847, 491, true);
                WriteLiteral(@" class=""form-control"">
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Tasma No (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""tasma_no""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5338, "\"", 5361, 1);
#line 100 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 5346, Model.tasma_no, 5346, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5362, 491, true);
                WriteLiteral(@" class=""form-control"">
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Kafes No (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""kafes_no""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5853, "\"", 5876, 1);
#line 107 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 5861, Model.kafes_no, 5861, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5877, 483, true);
                WriteLiteral(@" class=""form-control"">
                                                </b>
                                            </div>

                                            <div class=""col-md-12 margin-bottom"">
                                                Cins id (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <select name=""cins_id""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6360, "\"", 6382, 1);
#line 115 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 6368, Model.cins_id, 6368, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6383, 24, true);
                WriteLiteral(" class=\"form-control\">\r\n");
                EndContext();
#line 116 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
                                                         foreach (var item in ViewBag.HayvanCinsleri)
                                                        {

#line default
#line hidden
                BeginContext(6569, 60, true);
                WriteLiteral("                                                            ");
                EndContext();
                BeginContext(6629, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b0fd81f872f6a49cd5270f99353ffbc095ab7c15762", async() => {
                    BeginContext(6660, 8, false);
#line 118 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
                                                                                     Write(item.adi);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 118 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
                                                               WriteLiteral(item.cins_id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6677, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 119 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(6738, 254, true);
                WriteLiteral("                                                    </select>\r\n                                                </b>\r\n                                            </div>\r\n\r\n                                            <div class=\"col-md-12 margin-bottom\">\r\n");
                EndContext();
#line 125 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
                                                 if(Model.hayvan_id!=0){

#line default
#line hidden
                BeginContext(7066, 54, true);
                WriteLiteral("                                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 7120, "\"", 7161, 2);
                WriteAttributeValue("", 7127, "/hayvanlar/sil?id=", 7127, 18, true);
#line 126 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
WriteAttributeValue("", 7145, Model.hayvan_id, 7145, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7162, 33, true);
                WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n");
                EndContext();
#line 127 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Hayvanlar\Olustur.cshtml"
                                                }

#line default
#line hidden
                BeginContext(7246, 293, true);
                WriteLiteral(@"                                                <input type=""submit"" value=""Ekle"" class=""btn btn-success"">
                                               
                                            </div>
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7546, 653, true);
            WriteLiteral(@"
                                </div>

                            </div>
                        </div>
                        <!-- Blok Alan -->
                    </div>
                    <!-- Blok Gölge -->
                    <div class=""Golge"">
                        &nbsp;
                    </div>
                    <!-- Blok Gölge -->


                </div>
                <!-- OrtaAlan2 Son -->
            </div>
        </div>

    </div>
</div>

<div id=""ctl00_cph1_orta"">

    <!-- OrtaAlan1 Başlangıç -->
    <div id=""ctl00_cph1_ctl01_panel_orta"">


    </div>
    <!-- OrtaAlan1 Son -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
