#pragma checksum "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ee5d1acca9a16aa53498a407b2667089f2300e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemSizes_Details), @"mvc.1.0.view", @"/Views/ItemSizes/Details.cshtml")]
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
#line 1 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\_ViewImports.cshtml"
using Inventario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\_ViewImports.cshtml"
using Inventario.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ee5d1acca9a16aa53498a407b2667089f2300e", @"/Views/ItemSizes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35448a1cf263cca2af42d762db5585cfbc81187e", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemSizes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inventario.Models.ItemSize>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>");
#nullable restore
#line 6 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
Write(ViewData["Subtitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <dl>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 12 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 33 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 36 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 39 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 42 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 45 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<div class=\"btn-group\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ee5d1acca9a16aa53498a407b2667089f2300e9384", async() => {
                WriteLiteral("Modificar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\ItemSizes\Details.cshtml"
                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ee5d1acca9a16aa53498a407b2667089f2300e11639", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#itemSize').on('click', '.js-delete', function () {
                var button = $(this);
                bootbox.confirm(
                    message: ""¿Está seguro que desea borrar este elemento?"",
                    buttons: {
                    confirm: {
                        label: 'Eliminar',
                        className: 'btn-success'
                    },
                    cancel: {
                        label: 'Cancelar',
                        className: 'btn-danger'
                    }
                },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/ItemSizes/Delete/' + button.attr('data-id'),
                                method: ""POST"",
                                success: function () {
                                    button.parents(""tr"").remove();
             ");
                WriteLiteral(@"                       toastr.success(""El elemento se eliminó con éxito"", ""Listo!"").
                                                                    },
                                error: function () {
                                    toastr.error(""No se pudo eliminar la especie"", ""Error"")
                                }
                            });
                        }
                    });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventario.Models.ItemSize> Html { get; private set; }
    }
}
#pragma warning restore 1591
