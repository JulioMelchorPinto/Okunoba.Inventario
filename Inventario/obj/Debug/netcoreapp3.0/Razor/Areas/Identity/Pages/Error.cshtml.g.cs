#pragma checksum "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a089b8fa1b4a8ef7bcf6642cbd9547f2b91d3fff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Error), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Error.cshtml")]
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
#line 1 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\_ViewImports.cshtml"
using Inventario.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\_ViewImports.cshtml"
using Inventario.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a089b8fa1b4a8ef7bcf6642cbd9547f2b91d3fff", @"/Areas/Identity/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905927258304ea03042803ef1383fb1ece1a976", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1 class=\"text-danger\">");
#nullable restore
#line 7 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\Error.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2 class=\"text-danger\">Ocurri&oacute; un error al procesar la petici&oacute;n.</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 13 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Program Files (x86)\Okunoba\Inventario2.0\Inventario\Inventario\Areas\Identity\Pages\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Modo de Desarrollo</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
