#pragma checksum "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Experience2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed2700dfdc9918c8e89de9481e9f2ebef240de31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience2_Index), @"mvc.1.0.view", @"/Views/Experience2/Index.cshtml")]
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
#line 1 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Experience2\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed2700dfdc9918c8e89de9481e9f2ebef240de31", @"/Views/Experience2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\dogan\OneDrive\Masaüstü\murat\Core_Proje\Core_Proje\Views\Experience2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-6"">
    <div class=""p-2"">
        <button type=""button"" id=""btngetlistall"" class=""btn btn-outline-primary"">Verileri Getir</button>
        <button type=""button"" id=""btnadd"" class=""btn btn-outline-info"">Kaydet</button>
        <button type=""button"" id=""btnid"" class=""btn btn-outline-success"">Id İle Getir</button>
        <button type=""button"" id=""btndelete"" class=""btn btn-outline-danger"">Sil</button>
        <button type=""button"" id=""btnupdate"" class=""btn btn-outline-warning"">Güncelle</button>
    </div>
</div>

<h4 class=""text-center"">Deneyim Listesi</h4>

<div class=""p-2"" id=""listexperience"">
");
            WriteLiteral("</div>\r\n<br />\r\n<div class=\"p-2\" id=\"listbyidexperience\">\r\n");
            WriteLiteral(@"</div>


<br />

<div class=""col-md-12"">
    <h5>Ekleme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Başlık"" />
    <br />
    <input type=""text"" class=""form-control"" id=""inpdate"" placeholder=""Tarih"" />
</div>
<br />
<div class=""col-md-12"">
    <h5>Id'ye Göre Getirme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpid"" placeholder=""ID Giriniz"" />
</div>
<br />
<div class=""col-md-12"">
    <h5>Silme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpexpid"" placeholder=""ID Giriniz"" />
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //listeleme işlemi
        $(""#btngetlistall"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience2/ListExperience/"",

                success: function (funk) {
                    let values = jQuery.parseJSON(funk);
                    console.log(values);

                    //verilerin listesini tabloya aktarma
                    let htmlst = ""<table class=table table-bordered> <tr> <th> ID </th> <th> Başlık </th> <th> Tarih </th> </tr>"";
                    $.each(values, (index, value) => {
                        htmlst += `<tr> <td>${value.ExperienceId}</td> <td>${value.Name}</td> <td>${value.Date}</td> </tr>`
                    });
                    htmlst += ""</table>"";
                    $(""#listexperience"").html(htmlst);
                }
            });
        });

        //ekleme işlemi
        $(""#btnadd"")");
                WriteLiteral(@".click(function (){
            let values = {
                Name: $(""#inpname"").val(),
                Date: $(""#inpdate"").val()
            };
            //ajax eklemesi yapıcam
            $.ajax({
                type: ""Post"",
                url: ""Experience2/AddExperience/"",
                data: values,
                success: function(funk1){
                    let result = jQuery.parseJSON(funk1);
                    alert(""Başarılı bir şekilde eklendi"");
                }
            });
        });

        //Id'ye göre kayıt getirme işlemi
        $(""#btnid"").click(x => {
            let id = $(""#inpid"").val();

            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience2/GetById/"",
                data: { ExperienceId: id },
                success: function (funk2) {
                    let result = jQuery.parseJSON(funk2);
                    console.log(r");
                WriteLiteral(@"esult);
                    let htmlstr = `<table class=table table-hover> <tr> <th>Deneyim ID</th> <td>${result.ExperienceId}</td></tr> <tr> <th> Deneyim Başlığı </th> <td> ${result.Name}</td> </tr> </table>`;
                    $(""#listbyidexperience"").html(htmlstr);
                }
            });

        });

        //silme işlemi
        $(""#btndelete"").click(x=> {
            let id = $(""#inpexpid"").val();
            $.ajax({
                url: ""/Experience2/DeleteExperience/"" + id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function(funk3){
                    loadData();
                    alert(""Başarılı bir şekilde silindi"");
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed2700dfdc9918c8e89de9481e9f2ebef240de318266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
