#pragma checksum "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da211ebaca9484f7df637723f262c50bdcd2b77b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HayvanHastaliklari_Index), @"mvc.1.0.view", @"/Views/HayvanHastaliklari/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HayvanHastaliklari/Index.cshtml", typeof(AspNetCore.Views_HayvanHastaliklari_Index))]
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
#line 2 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da211ebaca9484f7df637723f262c50bdcd2b77b", @"/Views/HayvanHastaliklari/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30ad5344f22f7b1c20030be11aba1dd4066314d", @"/Views/_ViewImports.cshtml")]
    public class Views_HayvanHastaliklari_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dost.Patiler.Barinak.Models.Database.hayvan_hastaliklari>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
  
int? id = Context.Session.GetInt32("id");

#line default
#line hidden
            BeginContext(159, 539, true);
            WriteLiteral(@"    <style>
        .table1 {
            color: black;
        }

        .bas {
            background-color: #85D5DF;
        }

        .metin {
            color: darkslategray;
        }

        h4 {
            color: #47a447;
        }
    </style>


    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <b style=""float:left"">
                    <p>
                        <h4>HAYVAN HASTALIKLARI</h4>
                    </p>
                </b>
");
            EndContext();
#line 33 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                 if(id.HasValue){

#line default
#line hidden
            BeginContext(733, 107, true);
            WriteLiteral("            <a style=\"float:right\" class=\"btn btn-success\" href=\"/hayvanhastaliklari/olustur\">Oluştur</a>\r\n");
            EndContext();
#line 35 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(859, 287, true);
            WriteLiteral(@"                <table class=""table table-hover"">

                    <thead class=""table1"">
                        <tr class=""bas"">
                            <th>hastalik_id</th>
                            <th>Hastalik Adi</th>
                            <th>Bulasici</th>
");
            EndContext();
#line 43 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                             if(id.HasValue){

#line default
#line hidden
            BeginContext(1193, 47, true);
            WriteLiteral("                            <th>İşlemler</th>\r\n");
            EndContext();
#line 45 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1271, 94, true);
            WriteLiteral("\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 51 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                         foreach(var item in Model){

#line default
#line hidden
            BeginContext(1419, 76, true);
            WriteLiteral("                        <tr class=\"metin\">\r\n                            <td>");
            EndContext();
            BeginContext(1496, 16, false);
#line 53 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                           Write(item.hastalik_id);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1552, 17, false);
#line 54 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                           Write(item.hastalik_adi);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1609, 13, false);
#line 55 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                           Write(item.bulasici);

#line default
#line hidden
            EndContext();
            BeginContext(1622, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 56 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                             if(id.HasValue){

#line default
#line hidden
            BeginContext(1676, 35, true);
            WriteLiteral("                            <th> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1711, "\"", 1766, 2);
            WriteAttributeValue("", 1718, "/hayvanhastaliklari/duzenle?id=", 1718, 31, true);
#line 57 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
WriteAttributeValue("", 1749, item.hastalik_id, 1749, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1767, 39, true);
            WriteLiteral("class=\"btn btn-info\">Düzenle</a></th>\r\n");
            EndContext();
#line 58 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1837, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 60 "c:\Users\ezgih\Desktop\Dost.Patiler.Barinak\Views\HayvanHastaliklari\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1895, 104, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dost.Patiler.Barinak.Models.Database.hayvan_hastaliklari>> Html { get; private set; }
    }
}
#pragma warning restore 1591