#pragma checksum "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6639a321a54c485a0988fc8b33e9f62baa079637"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Index.cshtml", typeof(AspNetCore.Views_Store_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6639a321a54c485a0988fc8b33e9f62baa079637", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModels.StoreViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
  

    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(94, 27, true);
            WriteLiteral("\r\n<h1>Sucursales</h1>\r\n\r\n\r\n");
            EndContext();
#line 11 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
 if (Model.tenemossucursales() )
{

#line default
#line hidden
            BeginContext(158, 144, true);
            WriteLiteral("    <div id=\" \" SucursalGroup\" class=\" list-group\" style=\"height: 300px; width: 100%; overflow-y: scroll;\">\r\n        <ul class=\"list-group\">\r\n\r\n");
            EndContext();
#line 16 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
             foreach (var sucursal in Model.StoreList)
            {

#line default
#line hidden
            BeginContext(373, 45, true);
            WriteLiteral("                <li class=\"list-group-item\"> ");
            EndContext();
            BeginContext(419, 15, false);
#line 18 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
                                        Write(sucursal.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(434, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 19 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(457, 29, true);
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n");
            EndContext();
#line 23 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"

}
else if (Model.HttpStatusCode.Equals(System.Net.HttpStatusCode.NoContent))
{

#line default
#line hidden
            BeginContext(570, 135, true);
            WriteLiteral("    <div id=\" \" SucursalGroup\" class=\"text-info\">\r\n        <label class=\"alert-info\">No se encontraron sucursales</label>\r\n    </div>\r\n");
            EndContext();
#line 30 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
}
else
{


}

#line default
#line hidden
            BeginContext(724, 10, true);
            WriteLiteral("<br />\r\n\r\n");
            EndContext();
            BeginContext(734, 422, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6639a321a54c485a0988fc8b33e9f62baa0796377348", async() => {
                BeginContext(833, 50, true);
                WriteLiteral("\r\n\r\n    <label>Nombre de Sucursal </label>\r\n\r\n    ");
                EndContext();
                BeginContext(884, 150, false);
#line 42 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
Write(Html.TextBoxFor(x => x.Store.Nombre,
        new { @class = "form-control", placeholder = "Escribe un nombre de Sucursal", autofocus = "autofocus" }));

#line default
#line hidden
                EndContext();
                BeginContext(1034, 115, true);
                WriteLiteral("\r\n\r\n\r\n    <br />\r\n\r\n    <button class=\"btn btn-primary\" type=\"submit\">\r\n        Crear sucursal\r\n    </button>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1156, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 55 "D:\GateTech\Entrenamiento\brive_api\WebApplication1\Views\Store\Index.cshtml"
 if (Model.HttpStatusCode == System.Net.HttpStatusCode.BadRequest)
{
    Html.Label("lblMessage", Model.Message, new { @class = "alert-warning" });
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModels.StoreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
