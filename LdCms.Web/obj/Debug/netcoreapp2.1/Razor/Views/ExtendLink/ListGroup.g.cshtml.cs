#pragma checksum "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e75bf6b0d2e34b72bca0ea94587e521905068f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExtendLink_ListGroup), @"mvc.1.0.view", @"/Views/ExtendLink/ListGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ExtendLink/ListGroup.cshtml", typeof(AspNetCore.Views_ExtendLink_ListGroup))]
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
#line 1 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
using LdCms.EF.DbViews;

#line default
#line hidden
#line 3 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
#line 4 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e75bf6b0d2e34b72bca0ea94587e521905068f", @"/Views/ExtendLink/ListGroup.cshtml")]
    public class Views_ExtendLink_ListGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ld_Extend_LinkGroup>
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
#line 6 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
  
    ViewData["Title"] = "ListGroup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(231, 467, true);
            WriteLiteral(@"

<nav class=""breadcrumb"">
    <i class=""Hui-iconfont"">&#xe67f;</i> 首页<span class=""c-gray en"">&gt;</span>扩展管理<span class=""c-gray en"">&gt;</span>友情链接<span class=""c-gray en"">&gt;</span>分组设置
    <a class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:window.location.reload();"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a>
</nav>

<article class=""page-container"">
    <div class=""l"" style=""width:40%;"">
        <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 698, "\"", 731, 1);
#line 19 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
WriteAttributeValue("", 707, Url.Action("SaveGroup"), 707, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(732, 2104, true);
            WriteLiteral(@" method=""post"" class=""form form-horizontal"" id=""form-add"">
            <div class=""row cl"">
                <label class=""form-label col-xs-4 col-sm-2"">类别名称：</label>
                <div class=""formControls col-xs-8 col-sm-9"">
                    <input type=""text"" class=""input-text"" value="""" placeholder=""分组名称"" id=""fName"" name=""fName"" />
                </div>
            </div>
            <div class=""row cl"">
                <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>外部组别：</label>
                <div class=""formControls col-xs-8 col-sm-9"">
                    <span class=""select-box"">
                        <select class=""select"" size=""1"" id=""fIsExternal"" name=""fIsExternal"">
                            <option value=""0"">关闭</option>
                            <option value=""1"">开启</option>
                        </select>
                    </span>
                </div>
            </div>
            <div class=""row cl"">
                <label class=""form-");
            WriteLiteral(@"label col-xs-4 col-sm-2"">备注：</label>
                <div class=""formControls col-xs-8 col-sm-9"">
                    <textarea id=""fRemark"" name=""fRemark"" class=""textarea"" placeholder=""说点什么...100个字符以内"" dragonfly=""true""></textarea>
                    <p class=""textarea-numberbar""><em class=""textarea-length""></em>/100</p>
                </div>
            </div>
            <div class=""row cl"">
                <label class=""form-label col-xs-4 col-sm-2"">审核：</label>
                <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                    <div class=""check-box"">
                        <input type=""checkbox"" id=""fState"" name=""fState"" value=""1""  checked="""" />
                        <label for=""checkbox-1"">&nbsp;</label>
                    </div>
                </div>
            </div>
            <div class=""row cl"">
                <div class=""col-xs-8 col-sm-9 col-xs-offset-4 col-sm-offset-2"">
                    <input class=""btn btn-primary radius"" type=""submit"" val");
            WriteLiteral("ue=\"&nbsp;&nbsp;提交&nbsp;&nbsp;\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2836, "\"", 2862, 1);
#line 56 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
WriteAttributeValue("", 2843, Url.Action("list"), 2843, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2863, 1002, true);
            WriteLiteral(@" class=""btn btn-default radius"" type=""button""><i class=""Hui-iconfont"">&#xe684;</i> 返回 </a>
                </div>
            </div>
        </form>
    </div>
    <div class=""l"" style=""width:60%;border:0px solid #ffd800;"">
        <div style=""height:32px;line-height:32px;"">链接分组列表：</div>
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""120"">名称</th>
                    <th width="""">名称</th>
                    <th width=""80"">外部</th>
                    <th width=""80"">状态</th>
                    <th width=""120"">时间</th>
                    <th width=""100"">操作</th>
                </tr>
            </thead>
            <tbody id=""lists"">
                <tr class=""text-c"">
                    <td valign=""top"" colspan=""5"" class=""dataTables_empty"">暂无数据</td>
                </tr>
            </tbody>
        </table>
    </div>
</article>



");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3944, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(3978, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9661bb8dff3464bad028f2130d68e6a", async() => {
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
                BeginContext(4070, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4076, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283c488a6b9e45aca1118e1812b6fc9c", async() => {
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
                BeginContext(4178, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4184, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ad5dfa4ddf4430955182d90a7114be", async() => {
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
                BeginContext(4287, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4293, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7351d63f75c4766a6999aae25563e81", async() => {
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
                BeginContext(4391, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4397, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61a8dab2aec2420f847ba87543aa82e4", async() => {
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
                BeginContext(4493, 2418, true);
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
                    $.mainu.getLinkGroupList();
                },
                formSubmit: function () {
                    $(""#form-add"").validate({
                        rules: {
                            fName: {
                                required: true
                            }
                        },
                        onkeyup: false,
                        focusCleanup: true,
                        success: ""valid"",
                        submitHandler");
                WriteLiteral(@": function (form) {
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
                                        window.location.reload();
                     ");
                WriteLiteral(@"               } else {
                                        layer.msg(message, { icon: 5, time: 3000 });
                                    }
                                }
                            });
                        }
                    });
                },
                getLinkGroupList: function () {
                    var url = """);
                EndContext();
                BeginContext(6912, 32, false);
#line 148 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
                          Write(Url.Action("linkgroup-list-get"));

#line default
#line hidden
                EndContext();
                BeginContext(6944, 2318, true);
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
                                sBody += '<td valign=""top"" colspan=""6"" class=""dataTables_empty"">暂无数据</td>';
                                sBody += '</tr>';
                            } else {
                                for (var i = 0; i < total; i++) {
                                    sBody += '<tr class=""text-c"">';
                                    sBody += '<td class=""text-c"">' + result.data[i].name + '</td>';
                                    sBody += ");
                WriteLiteral(@"'<td class=""text-l"">' + result.data[i].remark + '</td>';
                                    if (result.data[i].external) {
                                        sBody += '<td>是</td>';
                                    } else {
                                        sBody += '<td>否</td>';
                                    }
                                    if (result.data[i].state) {
                                        sBody += '<td>启用</td>';
                                    } else {
                                        sBody += '<td>停用</td>';
                                    }
                                    sBody += '<td>' + result.data[i].date + '</td>';
                                    sBody += '<td><a href=""###"" onclick=""$.mainu.edit(\'' + result.data[i].id + '\')"">编辑</a>  ';
                                    sBody +=' <a href = ""###"" onclick = ""$.mainu.delete(\'' + result.data[i].id + '\')"" > 删除</a></td> ';
                                    sBody += '</tr>");
                WriteLiteral(@"';
                                }
                            }
                        }
                        $(""#lists"").html(sBody);
                    }, ""json"");
                },
                edit: function (id) {
                    var url = """);
                EndContext();
                BeginContext(9263, 22, false);
#line 187 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
                          Write(Url.Action("GetGroup"));

#line default
#line hidden
                EndContext();
                BeginContext(9285, 328, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.get(url, { GroupID: id, }, function (result) {
                        var state = result.state;
                        var message = result.message;
                        if (state == ""success"") {
                            var actionUrl = """);
                EndContext();
                BeginContext(9614, 23, false);
#line 193 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
                                        Write(Url.Action("SaveGroup"));

#line default
#line hidden
                EndContext();
                BeginContext(9637, 589, true);
                WriteLiteral(@""";
                            $(""#form-add"").attr({ ""action"": actionUrl + ""?GroupID="" + id });
                            $(""input[name='fName']"").val(result.data.name);
                            $(""select[name='fIsExternal']"").val(result.data.external);
                            $(""textarea[name='fRemark']"").val(result.data.remark);
                        } else {
                            layer.alert(message, { icon: 5 });
                        }
                    });
                },
                delete: function (id) {
                    var url = """);
                EndContext();
                BeginContext(10227, 25, false);
#line 204 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ExtendLink\ListGroup.cshtml"
                          Write(Url.Action("DeleteGroup"));

#line default
#line hidden
                EndContext();
                BeginContext(10252, 682, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.post(url, { GroupID: id, }, function (result) {
                        var state = result.state;
                        var message = result.message;
                        if (state == ""success"") {
                            $.mainu.getLinkGroupList();
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
            BeginContext(10937, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ld_Extend_LinkGroup> Html { get; private set; }
    }
}
#pragma warning restore 1591
