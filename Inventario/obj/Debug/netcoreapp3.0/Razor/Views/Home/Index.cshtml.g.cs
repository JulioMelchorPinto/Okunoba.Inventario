#pragma checksum "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1697071fc6123f3a3a9c5b2d65543f05ce517189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1697071fc6123f3a3a9c5b2d65543f05ce517189", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35448a1cf263cca2af42d762db5585cfbc81187e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Grupo Okunoba S.A de C.V.</h1>\r\n    <p>Aplicaci&oacute;n de control de inventarios.</a></p>\r\n</div>\r\n<div class=\"jumbotron\">\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\Home\Index.cshtml"
   Write(ViewBag.ActionTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <p class=""lead"">
        Es una aplicaci&oacute;n Web para la administraci&oacute;n y manejo de inventario f&iacute;sico de productos.
</p>
</div>

<div class=""row"">
    <div class=""col-md-4"">
        <div class=""service"">
            <h3>Inventario</h3>
            <p> Consulta el resumen de existencias en producto en tiempo real.  </p>
            <p>");
#nullable restore
#line 17 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\Home\Index.cshtml"
          Write(Html.ActionLink("Inventario", "Budget", "Stocks", null, new { @Class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <div class=\"service\">\r\n            <h3>Lista de productos</h3>\r\n            <p>Encuentra o agrega productos nuevos al cat&aacute;.</p>\r\n            <p>");
#nullable restore
#line 24 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\Home\Index.cshtml"
          Write(Html.ActionLink("Productos", "Index", "Items", null, new { @Class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <div class=\"service\">\r\n            <h3>An&aacute;lisis</h3>\r\n            <p>Analisis estad&iacute;stico de Grupo Okunoba S.A. de C.V.</p>\r\n            <p>");
#nullable restore
#line 31 "C:\Users\Julio Melchor\beaverNet\Inventario\Inventario\Views\Home\Index.cshtml"
          Write(Html.ActionLink("Analisis", "Index", "", null, new { @Class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
