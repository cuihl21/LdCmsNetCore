#pragma checksum "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69cdb4867176b644fc5ef06e5cff3e61f678a6d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysAccessCorsHost_Show), @"mvc.1.0.view", @"/Views/SysAccessCorsHost/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SysAccessCorsHost/Show.cshtml", typeof(AspNetCore.Views_SysAccessCorsHost_Show))]
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
#line 1 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
using LdCms.EF.DbViews;

#line default
#line hidden
#line 3 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
#line 4 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cdb4867176b644fc5ef06e5cff3e61f678a6d7", @"/Views/SysAccessCorsHost/Show.cshtml")]
    public class Views_SysAccessCorsHost_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ld_Sys_AccessCorsHost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/validate-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/messages_zh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/static/h-ui.admin/js/H-ui.admin.common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
  
    ViewData["Title"] = "Show";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(228, 435, true);
            WriteLiteral(@"
<nav class=""breadcrumb"">
    <i class=""Hui-iconfont"">&#xe67f;</i> 首页<span class=""c-gray en"">&gt;</span>接口管理<span class=""c-gray en"">&gt;</span>接口设置
    <a class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a>
</nav>

<article class=""page-container"">

    <div class=""l"" style=""width:60%;"">
        <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 663, "\"", 691, 1);
#line 19 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
WriteAttributeValue("", 672, Url.Action("Save"), 672, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(692, 2448, true);
            WriteLiteral(@" method=""post"" class=""form form-horizontal"" id=""form-add"">
            <div class=""row cl"">
                <label class=""form-label col-xs-4 col-sm-2"">访问网址：</label>
                <div class=""formControls col-xs-8 col-sm-9"">
                    <input type=""text"" class=""input-text"" value="""" placeholder=""允午访问网址"" id=""fWebHost"" name=""fWebHost"" />
                    <span><font color=""red"">注：</font>授权网址必须是“http://”开头，结尾不要“/”。</span>
                </div>
            </div>
            <div class=""row cl"">
                <label class=""form-label col-xs-4 col-sm-2"">备注：</label>
                <div class=""formControls col-xs-8 col-sm-9"">
                    <textarea id=""fRemark"" name=""fRemark"" class=""textarea"" placeholder=""说点什么...100个字符以内"" dragonfly=""true""></textarea>
                    <p class=""textarea-numberbar""><em class=""textarea-length""></em>/100</p>
                </div>
            </div>
            <div class=""row cl"">
                <label class=""form-label col-xs-4 col-sm-2"">审核：");
            WriteLiteral(@"</label>
                <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                    <div class=""check-box"">
                        <input type=""checkbox"" id=""fState"" name=""fState"" value=""1"" checked=""checked"" />
                        <label for=""checkbox-1"">&nbsp;</label>
                    </div>
                </div>
            </div>
            <div class=""row cl"">
                <div class=""col-xs-8 col-sm-9 col-xs-offset-4 col-sm-offset-2"">
                    <input class=""btn btn-primary radius"" type=""submit"" value=""&nbsp;&nbsp;提交&nbsp;&nbsp;"">
                </div>
            </div>
        </form>
    </div>
    <div class=""l"" style=""width:40%;border:0px solid #ffd800;"">
        <div style=""height:32px;line-height:32px;"">已授权访问网址：</div>
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width="""">授权网址</th>
                    <th width=""");
            WriteLiteral(@"80"">状态</th>
                    <th width=""120"">时间</th>
                    <th width=""80"">操作</th>
                </tr>
            </thead>
            <tbody id=""lists"">
                <tr class=""text-c"">
                    <td valign=""top"" colspan=""4"" class=""dataTables_empty"">没有数据</td>
                </tr>
            </tbody>
        </table>
    </div>



</article>



");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3219, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(3253, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0fd1770ea124f6b84582b7fd0b99b83", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3345, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3351, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c59483c7375e4a029b2be9423117cc8d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3453, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3459, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d504f41bbc03447a8b2f483cc3782835", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3562, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3568, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c1b8988cb054a84998e4e2f3afa5216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3666, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3672, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee70f794dfa463aa7382c2528939361", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3768, 2524, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.skin-minimal input').iCheck({
                        checkboxClass: 'icheckbox-blue',
                        radioClass: 'iradio-blue',
                        increaseArea: '20%'
                    });
                    $(""#fRemark"").Huitextarealength({
                        minlength: 4,
                        maxlength: 100
                    });
                    $.mainu.getAccessCorsHostList();
                },
                formSubmit: function () {
                    $(""#form-add"").validate({
                        rules: {
                            fWebHost: {
                                required: true
                            }
                        },
                        onkeyup: false,
                        focusCleanup: true,
                        success: ""valid"",
                        submi");
                WriteLiteral(@"tHandler: function (form) {
                            var fState = $(""input[name='fState']"").is(':checked');
                            $(form).ajaxSubmit({
                                type: ""POST"",
                                cache: false,
                                data: { fState: fState },
                                dataType: ""json"",
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""POST[FAIL]"", { icon: 5 });
                                    }
                                },
                                success: function (result) {
                                    var state = result.state;
                                    var message = result.message;
                                    if (state == ""success"") {
                                        layer.msg(message, { icon: 6, time: 3000");
                WriteLiteral(@" });
                                        $.mainu.getAccessCorsHostList();
                                    } else {
                                        layer.msg(message, { icon: 5, time: 3000 });
                                    }
                                }
                            });
                        }
                    });
                },
                getAccessCorsHostList: function () {
                    var url = """);
                EndContext();
                BeginContext(6293, 37, false);
#line 139 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
                          Write(Url.Action("AccessCorsHost-List-Get"));

#line default
#line hidden
                EndContext();
                BeginContext(6330, 1632, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.get(url, { state: true}, function (result) {
                        var state = result.state;
                        var message = result.message;
                        var sBody = """";
                        if (state == ""success"") {
                            var total = result.data.length;
                            console.log(total);
                            if (total == 0) {
                                sBody += '<tr class=""text-c"">';
                                sBody += '<td valign=""top"" colspan=""4"" class=""dataTables_empty"">没有数据</td>';
                                sBody += '</tr>';
                            } else {
                                for (var i = 0; i < total; i++) {
                                    sBody += '<tr class=""text-c"">';
                                    sBody += '<td class=""text-l"">' + result.data[i].web_host + '</td>';
                                    sBody");
                WriteLiteral(@" += '<td>' + result.data[i].state + '</td>';
                                    sBody += '<td>' + result.data[i].create_date + '</td>';
                                    sBody += '<td><a href=""###"" onclick=""$.mainu.delete(\'' + result.data[i].web_host + '\')"">删除</a></td>';
                                    sBody += '</tr>';
                                }
                            }
                        }
                        $(""#lists"").html(sBody);
                    }, ""json"");
                },
                delete: function (webHost) {
                    var url = """);
                EndContext();
                BeginContext(7963, 20, false);
#line 167 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysAccessCorsHost\Show.cshtml"
                          Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(7983, 692, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.post(url, { webHost: webHost, }, function (result) {
                        var state = result.state;
                        var message = result.message;
                        if (state == ""success"") {
                            $.mainu.getAccessCorsHostList();
                        } else {
                            layer.alert(message, { icon: 5 });
                        }
                    });
                }
            };
            $(function () {
                $.mainu.init();
                $.mainu.formSubmit();
            });

        })(jQuery);
    </script>
");
                EndContext();
            }
            );
            BeginContext(8678, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ld_Sys_AccessCorsHost> Html { get; private set; }
    }
}
#pragma warning restore 1591
