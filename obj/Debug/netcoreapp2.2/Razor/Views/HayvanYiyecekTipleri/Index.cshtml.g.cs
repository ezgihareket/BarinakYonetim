#pragma checksum "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e5d8e7e9f25596a80746d7035a9a165ac9289ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HayvanYiyecekTipleri_Index), @"mvc.1.0.view", @"/Views/HayvanYiyecekTipleri/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HayvanYiyecekTipleri/Index.cshtml", typeof(AspNetCore.Views_HayvanYiyecekTipleri_Index))]
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
#line 2 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e5d8e7e9f25596a80746d7035a9a165ac9289ca", @"/Views/HayvanYiyecekTipleri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30ad5344f22f7b1c20030be11aba1dd4066314d", @"/Views/_ViewImports.cshtml")]
    public class Views_HayvanYiyecekTipleri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dost.Patiler.Barinak.Models.Database.hayvan_yiyecek_tipleri>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(113, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 3 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
      
    int? id = Context.Session.GetInt32("id");
    

#line default
#line hidden
            BeginContext(175, 542, true);
            WriteLiteral(@"    <style>
        .table1 {
            color: black;
        }

        h4 {
            color: #47a447;
        }

        .metin {
            color: darkslategray;
        }

        .bas {
            background-color: #85D5DF;
        }
    </style>


    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <b style=""float:left"">
                    <p>
                        <h4>HAYVAN YIYECEK TIPLERI</h4>
                    </p>
                </b>
");
            EndContext();
#line 33 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                 if(id.HasValue){

#line default
#line hidden
            BeginContext(752, 113, true);
            WriteLiteral("                <a style=\"float:right\" class=\"btn btn-success\" href=\"/hayvanyiyecektipleri/olustur\">Oluştur</a>\r\n");
            EndContext();
#line 35 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(884, 247, true);
            WriteLiteral("                <table class=\"table table-hover\">\r\n            \r\n                    <thead class=\"table1\">\r\n                        <tr class=\"bas\">\r\n                            <th>yiyecek_id</th>\r\n                            <th>Aciklama</th>\r\n");
            EndContext();
#line 42 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                             if(id.HasValue){

#line default
#line hidden
            BeginContext(1178, 47, true);
            WriteLiteral("                            <th>işlemler</th>\r\n");
            EndContext();
#line 44 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1256, 90, true);
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 48 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                         foreach(var item in Model){

#line default
#line hidden
            BeginContext(1400, 76, true);
            WriteLiteral("                        <tr class=\"metin\">\r\n                            <td>");
            EndContext();
            BeginContext(1477, 15, false);
#line 50 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                           Write(item.yiyecek_id);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1532, 13, false);
#line 51 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                           Write(item.aciklama);

#line default
#line hidden
            EndContext();
            BeginContext(1545, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 52 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                             if(id.HasValue){

#line default
#line hidden
            BeginContext(1599, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1633, "\"", 1689, 2);
            WriteAttributeValue("", 1640, "/hayvanyiyecektipleri/duzenle?id=", 1640, 33, true);
#line 53 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
WriteAttributeValue("", 1673, item.yiyecek_id, 1673, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1690, 40, true);
            WriteLiteral(" class=\"btn btn-info\">Düzenle</a></td>\r\n");
            EndContext();
#line 54 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1761, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 56 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1819, 108, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dost.Patiler.Barinak.Models.Database.hayvan_yiyecek_tipleri>> Html { get; private set; }
    }
}
#pragma warning restore 1591