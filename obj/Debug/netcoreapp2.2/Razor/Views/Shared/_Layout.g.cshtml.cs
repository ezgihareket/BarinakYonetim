#pragma checksum "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0436399f28d841bec64a435d00e4047b279d6cfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0436399f28d841bec64a435d00e4047b279d6cfa", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30ad5344f22f7b1c20030be11aba1dd4066314d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("shortcut icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/site_document/icon_img/favicon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style.css?Tema="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ctl00_Head1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/kayitol/girisyap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/site_document/files/resim/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 80px; margin-right: 10px; width: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Shared\_Layout.cshtml"
  
int? id = Context.Session.GetInt32("id");

#line default
#line hidden
            BeginContext(85, 86, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html id=\"ctl00_tagHtml\" xmlns=\"https://www.w3.org/1999/xhtml\">\r\n\r\n");
            EndContext();
            BeginContext(171, 1313, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0436399f28d841bec64a435d00e4047b279d6cfa7712", async() => {
                BeginContext(194, 385, true);
                WriteLiteral(@"
    <meta name=""keywords"" content=""site,"" />
    <meta name=""description"" content=""Site Açıklaması"" />
    <meta property=""og:image""
        content=""http://barinakplatinum.platinum.webdeneme.com/site_document/icon_img/favicon_b.jpg"" />
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />

    ");
                EndContext();
                BeginContext(579, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0436399f28d841bec64a435d00e4047b279d6cfa8497", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(651, 730, true);
                WriteLiteral(@"

    <!-- Mobile Metas -->
    <meta name=""viewport"" content=""width=device-width, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no"" />

    <!-- Web Fonts  -->
    <link href=""https://fonts.googleapis.com/css?family=Coiny:400,700|Caveat+Brush:400,700&subset=latin,cyrillic,arabic""
        rel=""stylesheet"" type=""text/css"">

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""https://hemencdn.com/interface/platinum/css/main.css"" />

    <script src=""https://hemencdn.com/interface/platinum/js/modernizr.min.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.js""></script>



    ");
                EndContext();
                BeginContext(1381, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0436399f28d841bec64a435d00e4047b279d6cfa10577", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1429, 48, true);
                WriteLiteral("\r\n\r\n    <title>\r\n        SemPati\r\n    </title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1484, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1488, 12453, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0436399f28d841bec64a435d00e4047b279d6cfa12854", async() => {
                BeginContext(1494, 506, true);
                WriteLiteral(@"
    <div>
        <div class=""body"">
            <header id=""header"" class=""headertheme_11 header-narrow""
                data-plugin-options='{""stickyEnabled"": false, ""stickyEnableOnBoxed"": false, ""stickyEnableOnMobile"": true, ""stickyStartAt"": 0, ""stickySetTop"": ""-0"", ""stickyChangeLogo"": true}'>
                <div class=""header-body"">
                    <div class=""header-top htop_11"" style=""background-color: #85D5DF; color: #FFFFFF"">

                        <div class=""container"">


");
                EndContext();
#line 52 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Shared\_Layout.cshtml"
                             if(!id.HasValue){

#line default
#line hidden
                BeginContext(2048, 310, true);
                WriteLiteral(@"                            <div class=""header-row membership"">
                                <div id=""ctl00_Header_ctl02_UyeGiris""
                                    onkeypress=""javascript:return WebForm_FireDefaultButton(event, &#39;ctl00_Header_ctl02_Giris&#39;)"">
                                    ");
                EndContext();
                BeginContext(2358, 2067, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0436399f28d841bec64a435d00e4047b279d6cfa14367", async() => {
                    BeginContext(2405, 2013, true);
                    WriteLiteral(@"
                                        <div class=""Ust_Uyelik"" id=""Uyelik_logo_yani"">
                                            <div class=""col-md-12"">
                                                <div class=""col-md-1""></div>
                                                <div class=""col-md-3 mobile-hide"">
                                                    <input name=""email"" type=""text""
                                                        id=""ctl00_Header_ctl02_uyeKullaniciAdi"" class=""form-control""
                                                        placeholder=""Kullanıcı Adı"" />
                                                </div>
                                                <div class=""col-md-3 mobile-hide"">
                                                    <input name=""sifre"" type=""password"" id=""ctl00_Header_ctl02_uyeSifre""
                                                        class=""form-control"" autocomplete=""off"" placeholder=""Şifre"" />
                              ");
                    WriteLiteral(@"                  </div>
                                                <div class=""col-md-5"">
                                                    <input type=""submit"" value=""Giriş"" id=""ctl00_Header_ctl02_Giris""
                                                        class=""btn btn-primary mobile-hide"" />

                                                    <a href=""/members/login"" class=""btn btn-primary mobile-show"">Giriş
                                                        Yap</a>
                                                    <a href=""/kayitol"" class=""btn btn-primary"">Kayıt Ol</a>
                                                    <a href=""/members/forgot-password"" class=""btn btn-primary"">Şifremi
                                                        Unuttum</a>
                                                </div>
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4425, 76, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>");
                EndContext();
#line 83 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Shared\_Layout.cshtml"
                                  }

#line default
#line hidden
                BeginContext(4504, 569, true);
                WriteLiteral(@"                        </div>
                    </div>
                    <div id=""header"" class=""headtheme_11 header-container container"">
                        <div class=""header-row"">
                            <div class=""header-column"">
                                <div class=""header-logo"">
                                    <table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""tema_sol"">
                                        <tbody>
                                            <tr>
                                                <td>");
                EndContext();
                BeginContext(5073, 173, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0436399f28d841bec64a435d00e4047b279d6cfa19240", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5246, 3121, true);
                WriteLiteral(@"</td>
                                                <td><span style=""font-size:24px;""><span
                                                            style=""color:#1C2125;"">SemPati</span></span></td>
                                            </tr>
                                        </tbody>
                                    </table>

                                </div>
                            </div>

                            <div class=""header-column"">
                                <div class=""header-row"">
                                    <div class=""header-nav"">
                                        <button class=""btn header-btn-collapse-nav"" type=""button"" data-toggle=""collapse""
                                            data-target="".header-nav-main"">
                                            <i class=""fa fa-bars""></i>
                                        </button>
                                        <div
                                            c");
                WriteLiteral(@"lass=""header-nav-main header-nav-main-effect-1 header-nav-main-sub-effect-1 collapse"">
                                            <nav>
                                                <ul class=""nav nav-pills"" id=""mainNav"">

                                                    <li>
                                                        <a href=""/"" id=""mn_1"" class=""menu_tur_11"">Anasayfa</a>
                                                    </li>

                                                    <li>
                                                        <a href=""/hakkimizda"" id=""mn_290""
                                                            class=""menu_tur_11"">Hakkımızda</a>
                                                    </li>
                                                    <li>
                                                        <a href=""#tablolar"" id=""mn_289"" class=""menu_tur_11"">Tablolar</a>
                                                    </li>

                  ");
                WriteLiteral(@"                                  <li>
                                                        <a href=""#galeri"" id=""mn_289"" class=""menu_tur_11"">Galeri</a>
                                                    </li>

                                                    <li>
                                                        <a href=""/iletisim"" id=""mn_3"" class=""menu_tur_11"">Iletişim</a>
                                                    </li>
                                                    <li class=""dropdown"">
                                                        <a href=""/sahiplendirme/c/291"" id=""mn_291""
                                                            class=""dropdown-toggle menu_tur_11""><span
                                                                data-hover=""Sahiplendirme"">Hesap</span></a>
                                                        <ul class=""dropdown-menu"">
                                                            <li>
                               ");
                WriteLiteral("                                 <a  id=\"mn_293\">");
                EndContext();
                BeginContext(8368, 42, false);
#line 141 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Shared\_Layout.cshtml"
                                                                           Write(Context.Session.GetString("kullanici_adi"));

#line default
#line hidden
                EndContext();
                BeginContext(8410, 895, true);
                WriteLiteral(@"</a>
                                                            </li>
                                                            <li>
                                                                <a href=""/kayitol/cikisyap"" id=""mn_293"">Çıkış Yap</a>
                                                            </li>


                                                        </ul>
                                                    </li>
                                                </ul>
                                            </nav>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </header>

            <div role=""main"" class=""main"">
                ");
                EndContext();
                BeginContext(9306, 12, false);
#line 162 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(9318, 4616, true);
                WriteLiteral(@"
            </div>

            <footer id=""footer"" style=""background: url(/site_document/files/resim/bgaltpet.jpg) repeat-x top center;"">
                <div class=""container"">
                    <div class=""row"">
                        <div id=""ctl00_AltAlan_pnaltAlt"">


                            <!-- ##Blok -->
                            <div class=""col-md-4"">

                                <div class=""Blok"" data-appear-animation=""fadeInLeft"" id=""statik_254"">
                                    <!-- Blok Başlık -->
                                    <h4 class=""heading-primary"">Hakkımızda</h4>
                                    <div class=""Area"">
                                        <p>Tecrübeli teknik kadromuz ile güvenilir ve verilmi ekip olma anlayışıyla;
                                            müşteri memnuniyeti ve kalite ile birlikte zamanındalık ilkerinden ödün
                                            vermeden ülke ve dünya standartlarına uygun olarak hizmet sun");
                WriteLiteral(@"maktayız.</p>

                                    </div>
                                </div>

                            </div>
                            <!-- ##Blok -->
                            <!-- 
                            <div class=""col-md-4"">

                                
                                <div class=""Blok"" data-appear-animation=""fadeInUp"" id=""statik_252"">
                                   --- Blok Başlık ---
                                    <h4 class=""heading-primary"">Facebook</h4>
                                    <div class=""Area"">
                                        <div class=""fb-page"" data-href=""https://www.facebook.com/facebook"" data-small-header=""false"" data-adapt-container-width=""true"" data-hide-cover=""false"" data-show-facepile=""false"" data-show-posts=""false"">
                                            <div class=""fb-xfbml-parse-ignore"">
                                                <blockquote cite=""https://www.facebook.com/facebook""");
                WriteLiteral(@"><a href=""https://www.facebook.com/facebook"">https://www.facebook.com/facebook</a></blockquote>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                

                            </div>
                            -->
                            <!-- ##Blok -->
                            <div class=""col-md-4"">

                                <div class=""Blok"" data-appear-animation=""fadeInRight"" id=""statik_288"">
                                    <!-- Blok Başlık -->
                                    <h4 class=""heading-primary"">İletişim</h4>
                                    <div class=""Area"">
                                        <p>Adres: Atatürk Caddesi - Malatya</p>

                                        <p>Telefon: 0212 444 0 444</p>

                                        <p>E-Mail: ezgihareket@gmail.com</p>

     ");
                WriteLiteral(@"                               </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""footer-copyright"" style=""display: block !important; visibility: visible !important;"">
                    <div class=""container"" style=""display: block !important; visibility: visible !important;"">
                        <div class=""row"" style=""display: block !important; visibility: visible !important;"">
                            <div class=""col-md-6"" style=""display: block !important; visibility: visible !important;"">
                                2020-Web Sitesi
                            </div>
                            <div class=""col-md-6 pull-right""
                                style=""display: block !important; visibility: visible !important;"">
                                <div class=""pull-right""
                                    style=""display: block !imp");
                WriteLiteral(@"ortant; visibility: visible !important;"">
                                    <div class=""bilgikurumsal GenislikSub""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    </div>

    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>

    <script src=""https://hemencdn.com/interface/platinum/js/main.js""></script>

");
                EndContext();
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
            EndContext();
            BeginContext(13941, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
