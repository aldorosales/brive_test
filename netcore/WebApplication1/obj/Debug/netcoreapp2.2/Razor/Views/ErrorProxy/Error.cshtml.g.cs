#pragma checksum "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\ErrorProxy\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386519c5c077938960c19fa79f3bc80a675a68cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ErrorProxy_Error), @"mvc.1.0.view", @"/Views/ErrorProxy/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ErrorProxy/Error.cshtml", typeof(AspNetCore.Views_ErrorProxy_Error))]
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
#line 1 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386519c5c077938960c19fa79f3bc80a675a68cd", @"/Views/ErrorProxy/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_ErrorProxy_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exception>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\ErrorProxy\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(59, 120, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            EndContext();
            BeginContext(180, 20, false);
#line 9 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\ErrorProxy\Error.cshtml"
Write(Model.InnerException);

#line default
#line hidden
            EndContext();
            BeginContext(200, 60, true);
            WriteLiteral("\r\n    <p>\r\n        <strong>Error Exception :</strong> <code>");
            EndContext();
            BeginContext(261, 20, false);
#line 11 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\ErrorProxy\Error.cshtml"
                                            Write(Model.InnerException);

#line default
#line hidden
            EndContext();
            BeginContext(281, 48, true);
            WriteLiteral("</code>\r\n    </p>\r\n\r\n<h3>Description</h3>\r\n<p>\r\n");
            EndContext();
            BeginContext(330, 13, false);
#line 16 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\ErrorProxy\Error.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(343, 14, true);
            WriteLiteral("    \r\n</p>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exception> Html { get; private set; }
    }
}
#pragma warning restore 1591