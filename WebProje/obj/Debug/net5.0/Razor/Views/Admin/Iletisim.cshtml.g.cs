#pragma checksum "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54de057f36d62eb7d48607a4f105b41fde03cd18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Iletisim), @"mvc.1.0.view", @"/Views/Admin/Iletisim.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54de057f36d62eb7d48607a4f105b41fde03cd18", @"/Views/Admin/Iletisim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Iletisim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProje.Models.Model.Iletisim>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
  
    ViewData["Title"] = "Iletisim";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"" class=""main"">

    <div class=""pagetitle"">
        <h1>İletişim</h1>
        <nav>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Anasayfa</a></li>
                <li class=""breadcrumb-item"">Sayfalar</li>
                <li class=""breadcrumb-item active"">İletişim</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->

    <section class=""section contact"">

        <div class=""row gy-4"">

            <div class=""col-xl-6"">

                <div class=""row"">
");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6\">\r\n                            <div class=\"info-box card\">\r\n                                <i class=\"bi bi-geo-alt\"></i>\r\n                                <h3>Adress</h3>\r\n                                <p>");
#nullable restore
#line 34 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
                              Write(item.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""info-box card"">
                                <i class=""bi bi-envelope""></i>
                                <h3>Sosyal Medya</h3>
                                <b class=""bi bi-twitter"">");
#nullable restore
#line 41 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
                                                    Write(item.Twitter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                <b class=\"bi bi-facebook\">");
#nullable restore
#line 42 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
                                                     Write(item.Facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                <b class=\"bi bi-instagram\">");
#nullable restore
#line 43 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
                                                      Write(item.Instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                <b class=\"bi bi-whatsapp\">");
#nullable restore
#line 44 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
                                                     Write(item.Whatsapp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                            </div>
                        </div>
                        <div class=""col-lg-12"">
                            <div class=""info-box card"">
                                <i class=""bi bi-telephone""></i>
                                <h3>Telefon</h3>
                                <p>");
#nullable restore
#line 51 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"
                              Write(item.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\PC\Desktop\Web Programlama\WebProje\WebProje\Views\Admin\Iletisim.cshtml"

                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"col-xl-6\">\r\n                <div class=\"card p-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54de057f36d62eb7d48607a4f105b41fde03cd188605", async() => {
                WriteLiteral(@"
                        <div class=""row gy-4"">

                            <div class=""col-md-6"">
                                <input type=""text"" name=""name"" class=""form-control"" placeholder=""Adınız"" required>
                            </div>

                            <div class=""col-md-6 "">
                                <input type=""email"" class=""form-control"" name=""email"" placeholder=""E-mailiniz"" required>
                            </div>

                            <div class=""col-md-12"">
                                <input type=""text"" class=""form-control"" name=""subject"" placeholder=""Konu"" required>
                            </div>

                            <div class=""col-md-12"">
                                <textarea class=""form-control"" name=""message"" rows=""6"" placeholder=""Mesaj"" required></textarea>
                            </div>

                            <div class=""col-md-12 text-center"">
                                <div class=""loading"">Yükleni");
                WriteLiteral(@"yor</div>
                                <div class=""error-message""></div>
                                <div class=""sent-message"">Mesajınız gönderildi. Teşekkürler!</div>

                                <button type=""submit"">Gönder</button>
                            </div>

                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </section>\r\n\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProje.Models.Model.Iletisim>> Html { get; private set; }
    }
}
#pragma warning restore 1591