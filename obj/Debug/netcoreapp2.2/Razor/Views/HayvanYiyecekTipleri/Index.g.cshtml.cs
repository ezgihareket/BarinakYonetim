#pragma checksum "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73e71ad719ffca1b0fbb925c0bf2319ab6a9f11f"
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
#line 1 "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\_ViewImports.cshtml"
using Dost.Patiler.Barinak;

#line default
#line hidden
#line 2 "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\_ViewImports.cshtml"
using Dost.Patiler.Barinak.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73e71ad719ffca1b0fbb925c0bf2319ab6a9f11f", @"/Views/HayvanYiyecekTipleri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30ad5344f22f7b1c20030be11aba1dd4066314d", @"/Views/_ViewImports.cshtml")]
    public class Views_HayvanYiyecekTipleri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dost.Patiler.Barinak.Models.Database.hayvan_yiyecek_tipleri>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 1025, true);
            WriteLiteral(@"
    <style>
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
            <a style=""float:right"" class=""btn btn-success"" href=""/hayvanyiyecektipleri/olustur"">Oluştur</a>
                <table class=""table table-hover"">

                    <thead class=""table1"">
                        <tr class=""bas"">
                            <th>yiyecek_id</th>
                            <th>Aciklama</th>
                            <th>işlemler</th>
                        </tr>
                    </thead>
                    <tbody>
            WriteLiteral("\n");
            EndContext();
#line 41 "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                         foreach(var item in Model){

#line default
#line hidden
            BeginContext(1153, 76, true);
            WriteLiteral("                        <tr class=\"metin\">\r\n                            <td>");
            EndContext();
            BeginContext(1230, 15, false);
#line 43 "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                           Write(item.yiyecek_id);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1285, 13, false);
#line 44 "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                           Write(item.aciklama);

#line default
#line hidden
            EndContext();
            BeginContext(1298, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1339, "\"", 1395, 2);
            WriteAttributeValue("", 1346, "/hayvanyiyecektipleri/duzenle?id=", 1346, 33, true);
#line 45 "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
WriteAttributeValue("", 1379, item.yiyecek_id, 1379, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1396, 71, true);
            WriteLiteral(" class=\"btn btn-info\">Düzenle</a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 47 "c:\Users\ezgih\Documents\GitHub\BarinakYonetim\Dost.Patiler.Barinak\Views\HayvanYiyecekTipleri\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1494, 108, true);
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