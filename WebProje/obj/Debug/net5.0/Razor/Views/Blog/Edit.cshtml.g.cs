#pragma checksum "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecc2f61efbe3257c481cb90091c4e29a8d56bd71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Edit), @"mvc.1.0.view", @"/Views/Blog/Edit.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc2f61efbe3257c481cb90091c4e29a8d56bd71", @"/Views/Blog/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProje.Models.Model.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml"
 using (Html.BeginForm("Edit", "Blog", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <main id=\"main\" class=\"main\">\r\n\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Blog D??zenle</h5>\r\n\r\n            <!-- Browser Default Validation -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecc2f61efbe3257c481cb90091c4e29a8d56bd714842", async() => {
                WriteLiteral("\r\n                <div class=\"col-md-4\">\r\n                    <label for=\"validationDefault01\" class=\"form-label\">Ba??l??k</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"Baslik\" name=\"Baslik\"");
                BeginWriteAttribute("value", " value=\"", 706, "\"", 727, 1);
#nullable restore
#line 20 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml"
WriteAttributeValue("", 714, Model.Baslik, 714, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                </div>\r\n                <label for=\"validationDefault02\" class=\"form-label\">??nceki Resim</label>\r\n                <div class=\"col-md-4\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 918, "\"", 939, 1);
#nullable restore
#line 24 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml"
WriteAttributeValue("", 924, Model.ResimURL, 924, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" height=""150"" width=""150"" />
                </div>
                <div class=""col-md-4"">
                    <label for=""validationDefault02"" class=""form-label"">Resim</label>
                    <input type=""file"" class=""form-control"" name=""ResimURL"" accept="".png,.jpg,.jpeg"">
                </div>
                <label for=""validationDefault03"" class=""form-label"">Kategori</label>
                <div class=""col-md-8"">

                </div>
                <div class=""col-md-8"">
                    <label for=""validationDefault03"" class=""form-label"">????erik</label>
                    <textarea name=""Aciklama"" class=""ckeditor"" required>");
#nullable restore
#line 36 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml"
                                                                   Write(Model.Icerik);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                </div>
                <div class=""col-12"">
                    <button class=""btn btn-primary"" type=""submit"">Kaydet</button>
                    <button class=""btn btn-outline-secondary"" type=""button""><a href=""/Blog/Index"">??ptal</a></button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <!-- End Browser Default Validation -->\r\n\r\n        </div>\r\n    </main>\r\n");
#nullable restore
#line 47 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Blog\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProje.Models.Model.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
