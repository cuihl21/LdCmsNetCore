#pragma checksum "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380c000e8c3523d3b4b4342db439f8233d442864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceMessageBoard_List), @"mvc.1.0.view", @"/Views/ServiceMessageBoard/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ServiceMessageBoard/List.cshtml", typeof(AspNetCore.Views_ServiceMessageBoard_List))]
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
#line 1 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
#line 4 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
using LdCms.Common.Enum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380c000e8c3523d3b4b4342db439f8233d442864", @"/Views/ServiceMessageBoard/List.cshtml")]
    public class Views_ServiceMessageBoard_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Service_MessageBoard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/laypage/1.2/laypage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(244, 600, true);
            WriteLiteral(@"

<nav class=""breadcrumb""><i class=""Hui-iconfont"">&#xe67f;</i> 首页 <span class=""c-gray en"">&gt;</span> 客服管理 <span class=""c-gray en"">&gt;</span> 留言管理 <a id=""btn_refresh"" class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a></nav>
<div class=""page-container"">
    <div class=""text-c"">
        日期范围：
        <input type=""text"" onfocus=""WdatePicker({ maxDate:'#F{$dp.$D(\'datemax\')||\'%y-%M-%d\'}' })"" id=""datemin"" name=""datemin"" class=""input-text Wdate"" style=""width:120px;""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 844, "\"", 868, 1);
#line 16 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 852, ViewBag.datemin, 852, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(869, 196, true);
            WriteLiteral(" />\r\n        -\r\n        <input type=\"text\" onfocus=\"WdatePicker({ minDate:\'#F{$dp.$D(\\\'datemin\\\')}\',maxDate:\'%y-%M-%d\' })\" id=\"datemax\" name=\"datemax\" class=\"input-text Wdate\" style=\"width:120px;\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1065, "\"", 1089, 1);
#line 18 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 1073, ViewBag.datemax, 1073, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1090, 193, true);
            WriteLiteral(" />\r\n        <select id=\"state\" name=\"state\" class=\"select\" style=\"width:100px; height:31px;vertical-align: middle;\">\r\n            <option value=\"\">全部状态</option>\r\n            <option value=\"1\" ");
            EndContext();
            BeginContext(1285, 32, false);
#line 21 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                          Write(ViewBag.State=="1"?"selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1318, 45, true);
            WriteLiteral(">已审阅</option>\r\n            <option value=\"0\" ");
            EndContext();
            BeginContext(1365, 32, false);
#line 22 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                          Write(ViewBag.State=="0"?"selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1398, 154, true);
            WriteLiteral(">待审阅</option>\r\n        </select>\r\n        <input type=\"text\" class=\"input-text\" style=\"width:350px\" placeholder=\"输入会员编号、手机、邮箱\" id=\"keyword\" name=\"keyword\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1552, "\"", 1576, 1);
#line 24 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 1560, ViewBag.keyword, 1560, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1577, 423, true);
            WriteLiteral(@" />
        <button type=""submit"" class=""btn btn-success radius"" id=""driversearch"" name=""driversearch"" onclick=""$.mainu.search()""><i class=""Hui-iconfont"">&#xe665;</i> 查找</button>
    </div>
    <div class=""cl pd-5 bg-1 bk-gray mt-20"">
        <span class=""l"">
            <a href=""javascript:;"" onclick=""$.mainu.deleteBatch()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 批量删除</a>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2000, "\"", 2026, 1);
#line 30 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 2007, Url.Action("list"), 2007, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2027, 133, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe667;</i> 留言列表</a>\r\n        </span>\r\n        <span class=\"r\">共有数据：<strong>");
            EndContext();
            BeginContext(2161, 13, false);
#line 32 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                                Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2174, 710, true);
            WriteLiteral(@"</strong> 条</span>
    </div>
    <div class=""mt-20"">
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""25""><input type=""checkbox"" name="""" value=""""></th>
                    <th width=""120"">ID</th>
                    <th width=""80"">姓名</th>
                    <th width=""120"">手机</th>
                    <th width="""">内容</th>
                    <th width=""80"">状态</th>
                    <th width=""80"">回复</th>
                    <th width=""120"">创建时间</th>
                    <th width=""160"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 50 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(3009, 109, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td><input type=\"checkbox\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3118, "\"", 3138, 1);
#line 55 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 3126, m.MessageID, 3126, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3139, 40, true);
            WriteLiteral("></td>\r\n                            <td>");
            EndContext();
            BeginContext(3180, 11, false);
#line 56 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                           Write(m.MessageID);

#line default
#line hidden
            EndContext();
            BeginContext(3191, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3232, 52, false);
#line 57 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.Name, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3285, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3326, 53, false);
#line 58 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.Phone, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3380, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(3435, 9, false);
#line 59 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                                          Write(m.Content);

#line default
#line hidden
            EndContext();
            BeginContext(3444, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(3503, 148, false);
#line 60 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                                              Write(m.State.ToBool() ? Html.Raw("<span class='label label-success radius'>已审阅</span>") : Html.Raw("<span class='label label-defaunt radius'>待审阅</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(3652, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3693, 162, false);
#line 61 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                            Write(!string.IsNullOrEmpty(m.Reply) ? Html.Raw("<span class='label label-success radius'>已回复</span>") : Html.Raw("<span class='label label-defaunt radius'>待回复</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(3856, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3897, 77, false);
#line 62 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                            Write(m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy-MM-dd HH:mm") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(3975, 59, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n");
            EndContext();
#line 64 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                                 if (m.State.ToBool())
                                {

#line default
#line hidden
            BeginContext(4125, 111, true);
            WriteLiteral("                                    <a title=\"待审\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 4236, "\"", 4279, 3);
            WriteAttributeValue("", 4246, "$.mainu.stop(this,\'", 4246, 19, true);
#line 66 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 4265, m.MessageID, 4265, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4277, "\')", 4277, 2, true);
            EndWriteAttribute();
            BeginContext(4280, 9, true);
            WriteLiteral(">待审</a>\r\n");
            EndContext();
#line 67 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4397, 111, true);
            WriteLiteral("                                    <a title=\"已审\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 4508, "\"", 4552, 3);
            WriteAttributeValue("", 4518, "$.mainu.start(this,\'", 4518, 20, true);
#line 70 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 4538, m.MessageID, 4538, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4550, "\')", 4550, 2, true);
            EndWriteAttribute();
            BeginContext(4553, 9, true);
            WriteLiteral(">已审</a>\r\n");
            EndContext();
#line 71 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(4597, 107, true);
            WriteLiteral("                                <a title=\"回复\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4704, "\"", 4794, 3);
            WriteAttributeValue("", 4714, "$.mainu.edit(\'编辑\',\'", 4714, 19, true);
#line 72 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 4733, Url.Action("Reply", new { MessageID = m.MessageID }), 4733, 53, false);

#line default
#line hidden
            WriteAttributeValue("", 4786, "\',\'\',\'\')", 4786, 8, true);
            EndWriteAttribute();
            BeginContext(4795, 116, true);
            WriteLiteral(">回复</a>\r\n                                <a title=\"查看\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4911, "\"", 5000, 3);
            WriteAttributeValue("", 4921, "$.mainu.show(\'查看\',\'", 4921, 19, true);
#line 73 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 4940, Url.Action("Show", new { MessageID = m.MessageID }), 4940, 52, false);

#line default
#line hidden
            WriteAttributeValue("", 4992, "\',\'\',\'\')", 4992, 8, true);
            EndWriteAttribute();
            BeginContext(5001, 116, true);
            WriteLiteral(">查看</a>\r\n                                <a title=\"删除\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5117, "\"", 5162, 3);
            WriteAttributeValue("", 5127, "$.mainu.delete(this,\'", 5127, 21, true);
#line 74 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
WriteAttributeValue("", 5148, m.MessageID, 5148, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 5160, "\')", 5160, 2, true);
            EndWriteAttribute();
            BeginContext(5163, 75, true);
            WriteLiteral(">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 77 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(5280, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5419, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(5453, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62bc8de737a74d7da5ba82134a0e91f2", async() => {
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
                BeginContext(5554, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5560, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98bbd1550d1e49dc83b24c05666ce0e7", async() => {
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
                BeginContext(5652, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5658, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e7122ed9e047b28833c7aaaa33b130", async() => {
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
                BeginContext(5739, 2155, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.table-sort').dataTable({
                        ""aaSorting"": [[7, ""desc""]],//默认第几个排序
                        ""bStateSave"": true,//状态保存
                        ""aoColumnDefs"": [
                          { ""orderable"": false, ""aTargets"": [0,8] }// 制定列不参与排序
                        ]
                    });
                },
                search: function () {
                    $dateMin = $(""input[name='datemin']"").val();
                    $dateMax = $(""input[name='datemax']"").val();
                    $state = $(""select[name='state']"").val();
                    $keyword = $(""input[name='keyword']"").val();
                    if ($keyword == """") {
                        if ($dateMin == """" || $dateMax=="""") {
                            layer.alert('日期范围不能空', { icon: 5 });
                            return;
                        }
    ");
                WriteLiteral(@"                }
                    var param = {
                        datemin: $dateMin,
                        datemax: $dateMax,
                        state: $state,
                        keyword: $keyword
                    };
                    var url = ""?"" + urlEncodes(param);
                    window.location.href = url;
                },
                show: function (title, url) {
                    var index = layer.open({
                        type: 2,
                        title: title,
                        content: url
                    });
                    layer.full(index);
                },
                add: function (title, url, w, h) {
                    layer_show(title, url, w, h);
                },
                edit: function (title, url, w, h) {
                    layer_show(title, url, w, h);
                },
                stop: function (obj, id) {
                    layer.confirm('确认要待审阅吗？', function (index) {
    ");
                WriteLiteral("                    $.ajax({\r\n                            type: \'POST\',\r\n                            url: \'");
                EndContext();
                BeginContext(7895, 25, false);
#line 143 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(7920, 1476, true);
                WriteLiteral(@"',
                            data: { messageId: id, state: false },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""已审"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.start(this,\'' + id + '\')"">已审</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-defaunt radius"">待审阅</span>');
                                    $(obj).remove();
                                    layer.msg('待审阅！', { icon: 5, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                 ");
                WriteLiteral(@"           },
                            error: function (data) {
                                console.log(data.msg);
                            }
                        });
                    });
                },
                start: function (obj, id) {
                    layer.confirm('确认要已审阅吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(9397, 25, false);
#line 168 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(9422, 1474, true);
                WriteLiteral(@"',
                            data: { messageId: id, state: true },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""待审"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.stop(this,\'' + id + '\')"">待审</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-success radius"">已审阅</span>');
                                    $(obj).remove();
                                    layer.msg('已审阅！', { icon: 6, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                   ");
                WriteLiteral(@"         },
                            error: function (data) {
                                console.log(data.msg);
                            }
                        });
                    });
                },
                delete: function (obj, id) {
                    layer.confirm('确认要删除吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(10897, 20, false);
#line 193 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                             Write(Url.Action("delete"));

#line default
#line hidden
                EndContext();
                BeginContext(10917, 1522, true);
                WriteLiteral(@"',
                            data: { messageId: id },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").remove();
                                    layer.msg('已删除！', { icon: 1, time: 2000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                            },
                            error: function (data) {
                                console.log(data.msg);
                            },
                        });
                    });
                },
                deleteBatch: function () {
                    layer.confirm('确认要删除吗？', function (index) {
               ");
                WriteLiteral(@"         var arrId = [];
                        $(""input:checkbox[name='id']:checked"").each(function () {
                            arrId.push($(this).val());
                        });
                        if (arrId.length == 0) {
                            layer.msg('请选择要删除的数据！', { icon: 5, time: 2000 });
                            return;
                        }
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(12440, 25, false);
#line 224 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\ServiceMessageBoard\List.cshtml"
                             Write(Url.Action("DeleteBatch"));

#line default
#line hidden
                EndContext();
                BeginContext(12465, 957, true);
                WriteLiteral(@"',
                            data: { arrid: arrId },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    window.location.replace(location.href);
                                } else {
                                    layer.msg(message, { icon: 5, time: 1000 });
                                }
                            },
                            error: function (data) {
                                console.log(data.msg);
                            },
                        });
                    });
                }
            };
            $(function () {
                $.mainu.init();
            });
        })(jQuery);
    </script>
");
                EndContext();
            }
            );
            BeginContext(13425, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Service_MessageBoard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
