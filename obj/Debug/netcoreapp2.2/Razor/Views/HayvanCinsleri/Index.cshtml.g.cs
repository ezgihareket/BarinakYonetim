#pragma checksum "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86976d32c369c56015dc31b9cc7c1315a33d692f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HayvanCinsleri_Index), @"mvc.1.0.view", @"/Views/HayvanCinsleri/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HayvanCinsleri/Index.cshtml", typeof(AspNetCore.Views_HayvanCinsleri_Index))]
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
#line 2 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86976d32c369c56015dc31b9cc7c1315a33d692f", @"/Views/HayvanCinsleri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30ad5344f22f7b1c20030be11aba1dd4066314d", @"/Views/_ViewImports.cshtml")]
    public class Views_HayvanCinsleri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dost.Patiler.Barinak.Models.Database.hayvan_cinsleri>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
  
int? id = Context.Session.GetInt32("id");

#line default
#line hidden
            BeginContext(156, 533, true);
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
                        <h4>HAYVAN CINSLERI</h4>
                    </p>
                </b>
");
            EndContext();
#line 32 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                 if(id.HasValue){

#line default
#line hidden
            BeginContext(724, 150, true);
            WriteLiteral("                <a style=\"float:right; margin-bottom: 15px;\" class=\"btn btn-success\"\r\n                    href=\"/hayvancinsleri/olustur\">Oluştur</a>\r\n");
            EndContext();
#line 35 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(893, 279, true);
            WriteLiteral(@"                <table class=""table table-hover"">

                    <thead class=""table1"">
                        <tr class=""bas"">
                            <th>cins_id</th>
                            <th>Cins Adi</th>
                            <th>Aciklama</th>
");
            EndContext();
#line 43 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                             if(id.HasValue){

#line default
#line hidden
            BeginContext(1219, 47, true);
            WriteLiteral("                            <th>İşlemler</th>\r\n");
            EndContext();
#line 45 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1297, 92, true);
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 50 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                         foreach(var item in Model){

#line default
#line hidden
            BeginContext(1443, 76, true);
            WriteLiteral("                        <tr class=\"metin\">\r\n                            <td>");
            EndContext();
            BeginContext(1520, 12, false);
#line 52 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                           Write(item.cins_id);

#line default
#line hidden
            EndContext();
            BeginContext(1532, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1572, 8, false);
#line 53 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                           Write(item.adi);

#line default
#line hidden
            EndContext();
            BeginContext(1580, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1620, 13, false);
#line 54 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                           Write(item.aciklama);

#line default
#line hidden
            EndContext();
            BeginContext(1633, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 55 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                             if(id.HasValue){

#line default
#line hidden
            BeginContext(1687, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1768, 2);
            WriteAttributeValue("", 1728, "/hayvancinsleri/duzenle?id=", 1728, 27, true);
#line 56 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
WriteAttributeValue("", 1755, item.cins_id, 1755, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1769, 40, true);
            WriteLiteral(" class=\"btn btn-info\">Düzenle</a></td>\r\n");
            EndContext();
#line 57 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1840, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 59 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanCinsleri\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1898, 108, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dost.Patiler.Barinak.Models.Database.hayvan_cinsleri>> Html { get; private set; }
    }
}
#pragma warning restore 1591
