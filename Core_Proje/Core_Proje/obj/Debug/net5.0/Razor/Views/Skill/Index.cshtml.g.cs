#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1657a4c89d6c42570633e91cd89b0751383505d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1657a4c89d6c42570633e91cd89b0751383505d3", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Yetenek Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 28 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
               Write(item.SkillId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td class=\"budget\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"d-flex align-items-center\">\r\n                        <span class=\"completion mr-2\">");
#nullable restore
#line 39 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                        <div>\r\n                            <div class=\"progress\">\r\n                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1460, "\"", 1487, 1);
#nullable restore
#line 42 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1476, item.Value, 1476, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1526, "\"", 1554, 3);
            WriteAttributeValue("", 1534, "width:", 1534, 6, true);
#nullable restore
#line 42 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 1540, item.Value, 1541, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1552, "%;", 1552, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1705, "\"", 1744, 2);
            WriteAttributeValue("", 1712, "/Skill/DeleteSkill/", 1712, 19, true);
#nullable restore
#line 47 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1731, item.SkillId, 1731, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1842, 2);
            WriteAttributeValue("", 1812, "/Skill/EditSkill/", 1812, 17, true);
#nullable restore
#line 48 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1829, item.SkillId, 1829, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <a href=\"/Skill/AddSkill\" class=\"btn btn-primary\">Yeni Yetenek Ekle</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
