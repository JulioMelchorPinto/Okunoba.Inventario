#pragma checksum "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2a59e62178d04676f1e6b16e8ddea1d540e2179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stocks_Overview), @"mvc.1.0.view", @"/Views/Stocks/Overview.cshtml")]
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
#line 1 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\_ViewImports.cshtml"
using Inventario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\_ViewImports.cshtml"
using Inventario.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a59e62178d04676f1e6b16e8ddea1d540e2179", @"/Views/Stocks/Overview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35448a1cf263cca2af42d762db5585cfbc81187e", @"/Views/_ViewImports.cshtml")]
    public class Views_Stocks_Overview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inventario.ViewModels.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 2 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>");
#nullable restore
#line 3 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
Write(ViewData["Subtitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<hr />\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a59e62178d04676f1e6b16e8ddea1d540e21794343", async() => {
                WriteLiteral("Nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-6 align-self-center"">
                <div class=""card card-body"">
                    <button type=""button"" class=""btn btn-default"" data-toggle=""collapse"" data-target=""#collapse"" aria-expanded=""false"" aria-controls=""collapse"">
                        ");
#nullable restore
#line 19 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
                   Write(Html.DisplayFor(modelItem => product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </button>
                    <div id=""collapse"" class=""collapse"">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                    </div>


                </div>
            </div>
            <div class=""col-6"">
                <div class=""card text-white bg-danger"">
                    <div class=""card-body"">
                        <h3 class=""card-title"">Taller</h3>
                        <p class=""card-text"">
                            <table>
");
#nullable restore
#line 34 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
                                 foreach (var productType in product.ProductTypes)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>");
#nullable restore
#line 38 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
                                       Write(Html.DisplayFor(modelItem => productType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 39 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
                                       Write(Html.DisplayFor(modelItem => product.ProductSizes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 41 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
                                       Write(Html.DisplayFor(modelItem => product.SumAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 43 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
                                       Write(Html.DisplayFor(modelItem => product.SumWeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 45 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\r\n                        </p>\r\n                        <a href=\"#\" class=\"btn text-white border-light\">Outline</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Views\Stocks\Overview.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr>\r\n<div class=\"note\">\r\n    Vertical align grid columns of varying height.\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inventario.ViewModels.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
