#pragma checksum "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\Error\Permission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7d7f683f807edbe1b5dc0a09625b3eebe47a270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Permission), @"mvc.1.0.view", @"/Views/Error/Permission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/Permission.cshtml", typeof(AspNetCore.Views_Error_Permission))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d7f683f807edbe1b5dc0a09625b3eebe47a270", @"/Views/Error/Permission.cshtml")]
    public class Views_Error_Permission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\Error\Permission.cshtml"
  
    ViewData["Title"] = "Permission";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 231, true);
            WriteLiteral("\r\n<section class=\"container-fluid page-404 minWP text-c\">\r\n    <p class=\"error-title\">\r\n        <i class=\"Hui-iconfont va-m\" style=\"font-size:80px\">&#xe688;</i><span class=\"va-m\"></span>\r\n    </p>\r\n    <p class=\"error-description\">");
            EndContext();
            BeginContext(327, 18, false);
#line 11 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\Error\Permission.cshtml"
                            Write(ViewData["FuncID"]);

#line default
#line hidden
            EndContext();
            BeginContext(345, 39, true);
            WriteLiteral("</p>\r\n    <p class=\"error-description\">");
            EndContext();
            BeginContext(385, 19, false);
#line 12 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\Error\Permission.cshtml"
                            Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(404, 18, true);
            WriteLiteral("</p>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
