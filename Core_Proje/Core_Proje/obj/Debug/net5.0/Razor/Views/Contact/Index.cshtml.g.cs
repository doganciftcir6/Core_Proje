#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5602fc7a6b7021eb13a8151350fa6fbf4e82d32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5602fc7a6b7021eb13a8151350fa6fbf4e82d32", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">İletişim Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Gönderen</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Görüntüle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                               Write(item.MessageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1092, "\"", 1137, 2);
            WriteAttributeValue("", 1099, "/Contact/DeleteContact/", 1099, 23, true);
#nullable restore
#line 31 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1122, item.MessageId, 1122, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1222, "\"", 1268, 2);
            WriteAttributeValue("", 1229, "/Contact/ContactDetails/", 1229, 24, true);
#nullable restore
#line 32 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1253, item.MessageId, 1253, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Detaylar</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
