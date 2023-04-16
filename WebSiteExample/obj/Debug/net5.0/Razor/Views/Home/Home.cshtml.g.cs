#pragma checksum "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4845874be623297ac9bcc1b6b059b9b74096602a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 1 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\_ViewImports.cshtml"
using WebSiteExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\_ViewImports.cshtml"
using WebSiteExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
using WebSiteExample.DataTransferObject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4845874be623297ac9bcc1b6b059b9b74096602a", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c1c2237a19e2ac02ed097b9a29e541ff43eaf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/DeleteProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
  
    decimal total = 0;
    foreach (var item in Model.ProductsCard)
    {
        total = total + item.TotalPrice;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <h2 class=\"text-center\">Products</h2>\r\n        <div class=\"row mt-5\">\r\n");
#nullable restore
#line 15 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
             foreach (var item in Model.ProductsTable)
            {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4845874be623297ac9bcc1b6b059b9b74096602a5457", async() => {
                WriteLiteral("\r\n                    <div class=\"col-md\">\r\n                        <input hidden=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 531, "\"", 547, 1);
#nullable restore
#line 18 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
WriteAttributeValue("", 539, item.id, 539, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <div class=\"form-group text-center\">\r\n                            <button type=\"submit\" class=\"btn btn-secondary\">\r\n\r\n                                <p class=\"font-weight-bold\" style=\"color:red\">");
#nullable restore
#line 22 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                                                                         Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                                <p class=\"font-weight-bold\">");
#nullable restore
#line 23 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                                                       Write(item.UnitPrice.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺ </p>\r\n\r\n\r\n                            </button>\r\n\r\n                            <input class=\"form-control mt-1\" type=\"number\" name=\"quantity\" min=\"1\" placeholder=\"Enter Quantity\"/>\r\n                            <h4 class=\"text-danger\">");
#nullable restore
#line 29 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                                               Write(TempData["submit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""col-md-4"">
        <h3 style=""text-align:center"">The Shopping Card</h3>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Product Name</th>
                    <th>Quantity</th>
                    <th>Unit Price</th>
                    <th>Total Price</th>
                    <th>Process</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 49 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                 foreach (var item in Model.ProductsCard)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                       Write(item.UnitPrice.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                       Write(item.TotalPrice.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4845874be623297ac9bcc1b6b059b9b74096602a11180", async() => {
                WriteLiteral("\r\n                                <input hidden=\"hidden\"  name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2257, "\"", 2273, 1);
#nullable restore
#line 58 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
WriteAttributeValue("", 2265, item.id, 2265, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                         \r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 64 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n        <hr />\r\n        <label class=\"form-control\">\r\n            Total Price ");
#nullable restore
#line 70 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                   Write(total.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺\r\n        </label>\r\n        <h4 class=\"text-danger\">");
#nullable restore
#line 72 "C:\Users\faruk\source\repos\WebSiteExample\WebSiteExample\Views\Home\Home.cshtml"
                           Write(TempData["payment"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4845874be623297ac9bcc1b6b059b9b74096602a14281", async() => {
                WriteLiteral("\r\n            <button class=\"btn btn-success btn-block mt-2\"> Payment </button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
