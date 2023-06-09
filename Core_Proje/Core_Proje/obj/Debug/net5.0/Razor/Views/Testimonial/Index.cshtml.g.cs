#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4064a329d801b135b7827af3f3bddfb707310624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Index), @"mvc.1.0.view", @"/Views/Testimonial/Index.cshtml")]
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
#line 1 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4064a329d801b135b7827af3f3bddfb707310624", @"/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Referans Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Ad Soyad </th>
                                <th> Şirket </th>
                                <th> Project </th>
                                <th> Unvan </th>
                                <th> Sil </th>
                                <th> Detaylar </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 28 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1153, "\"", 1173, 1);
#nullable restore
#line 32 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1159, item.ImageUrl, 1159, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 34 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                                Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 35 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                                Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 36 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1444, "\"", 1501, 2);
            WriteAttributeValue("", 1451, "/Testimonial/DeleteTestimonial/", 1451, 31, true);
#nullable restore
#line 37 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1482, item.TestimonialId, 1482, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n                                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1588, "\"", 1643, 2);
            WriteAttributeValue("", 1595, "/Testimonial/EditTestimonial/", 1595, 29, true);
#nullable restore
#line 38 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1624, item.TestimonialId, 1624, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Detaylar</a> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                    </table>
                    <a href=""/Testimonial/AddTestimonial/"" class=""btn btn-outline-info"">Yeni Referans Ekle</a>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
