#pragma checksum "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dba8c091ad2ea42e32a585e80bf45d2413e4737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysFunction_List), @"mvc.1.0.view", @"/Views/SysFunction/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SysFunction/List.cshtml", typeof(AspNetCore.Views_SysFunction_List))]
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
#line 1 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dba8c091ad2ea42e32a585e80bf45d2413e4737", @"/Views/SysFunction/List.cshtml")]
    public class Views_SysFunction_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Sys_Function>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(210, 527, true);
            WriteLiteral(@"<nav class=""breadcrumb""><i class=""Hui-iconfont"">&#xe67f;</i> 首页 <span class=""c-gray en"">&gt;</span> 系统管理 <span class=""c-gray en"">&gt;</span> 权限管理 <a id=""btn_refresh"" class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a></nav>
<div class=""page-container"">
    <div class=""text-c"">
        功能名称：<input type=""text"" class=""input-text"" style=""width:350px"" placeholder=""输入功能节点编号"" id=""keyword"" name=""keyword""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 737, "\"", 761, 1);
#line 12 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 745, ViewBag.keyword, 745, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(762, 411, true);
            WriteLiteral(@" />
        <button type=""submit"" class=""btn btn-success radius"" id=""search"" name=""search"" onclick=""$.mainu.search()""><i class=""Hui-iconfont"">&#xe665;</i> 查找</button>
    </div>
    <div class=""cl pd-5 bg-1 bk-gray mt-20"">
        <span class=""l"">
            <a href=""javascript:;"" onclick=""$.mainu.deleteBatch()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 批量删除</a>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1173, "\"", 1199, 1);
#line 18 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 1180, Url.Action("list"), 1180, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1200, 113, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe667;</i> 权限列表</a>\r\n            <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1313, "\"", 1374, 6);
            WriteAttributeValue("", 1323, "$.mainu.add(\'添加权限节点\',", 1323, 21, true);
            WriteAttributeValue(" ", 1344, "\'", 1345, 2, true);
#line 19 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 1346, Url.Action("add"), 1346, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1364, "\',", 1364, 2, true);
            WriteAttributeValue(" ", 1366, "\'\',", 1367, 4, true);
            WriteAttributeValue(" ", 1370, "\'\')", 1371, 4, true);
            EndWriteAttribute();
            BeginContext(1375, 135, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe600;</i> 添加权限节点</a>\r\n        </span>\r\n        <span class=\"r\">共有数据：<strong>");
            EndContext();
            BeginContext(1511, 13, false);
#line 21 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1524, 672, true);
            WriteLiteral(@"</strong> 条</span>
    </div>
    <div class=""mt-20"">
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""25""><input type=""checkbox"" name="""" value=""""></th>
                    <th width=""100"">功能编号</th>
                    <th width="""">功能名称</th>
                    <th width=""100"">上级编号</th>
                    <th width=""70"">级别</th>
                    <th width=""70"">状态</th>
                    <th width=""120"">操作时间</th>
                    <th width=""120"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 38 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(2321, 109, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td><input type=\"checkbox\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2430, "\"", 2451, 1);
#line 43 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 2438, m.FunctionID, 2438, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2452, 40, true);
            WriteLiteral("></td>\r\n                            <td>");
            EndContext();
            BeginContext(2493, 12, false);
#line 44 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                           Write(m.FunctionID);

#line default
#line hidden
            EndContext();
            BeginContext(2505, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(2561, 45, false);
#line 45 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                           Write(Utility.StringRepeat("　", m.RankID.ToInt()-1));

#line default
#line hidden
            EndContext();
            BeginContext(2607, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2610, 30, false);
#line 45 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                                                                            Write(m.RankID.ToInt() > 1 ? "" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2642, 14, false);
#line 45 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                                                                                                            Write(m.FunctionName);

#line default
#line hidden
            EndContext();
            BeginContext(2656, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2696, 10, false);
#line 46 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                           Write(m.ParentID);

#line default
#line hidden
            EndContext();
            BeginContext(2706, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2746, 8, false);
#line 47 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                           Write(m.RankID);

#line default
#line hidden
            EndContext();
            BeginContext(2754, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(2813, 147, false);
#line 48 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                              Write(m.State.ToBool()? Html.Raw("<span class='label label-success radius'>已启用</span>") : Html.Raw("<span class='label label-defaunt radius'>已停用</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(2961, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3002, 77, false);
#line 49 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                            Write(m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy-MM-dd HH:mm") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(3080, 59, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n");
            EndContext();
#line 51 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                 if (m.State.ToBool())
                                {

#line default
#line hidden
            BeginContext(3230, 67, true);
            WriteLiteral("                                    <a style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 3297, "\"", 3341, 3);
            WriteAttributeValue("", 3307, "$.mainu.stop(this,\'", 3307, 19, true);
#line 53 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 3326, m.FunctionID, 3326, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3339, "\')", 3339, 2, true);
            EndWriteAttribute();
            BeginContext(3342, 40, true);
            WriteLiteral(" href=\"javascript:;\" title=\"停用\">停用</a>\r\n");
            EndContext();
#line 54 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3490, 67, true);
            WriteLiteral("                                    <a style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 3557, "\"", 3602, 3);
            WriteAttributeValue("", 3567, "$.mainu.start(this,\'", 3567, 20, true);
#line 57 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 3587, m.FunctionID, 3587, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3600, "\')", 3600, 2, true);
            EndWriteAttribute();
            BeginContext(3603, 40, true);
            WriteLiteral(" href=\"javascript:;\" title=\"启用\">启用</a>\r\n");
            EndContext();
#line 58 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(3678, 54, true);
            WriteLiteral("                                <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3732, "\"", 3843, 5);
            WriteAttributeValue("", 3742, "$.mainu.edit(\'编辑权限节点\',\'", 3742, 23, true);
#line 59 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 3765, Url.Action("edit", new { functionid = m.FunctionID }), 3765, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 3819, "\',\'", 3819, 3, true);
#line 59 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 3822, m.FunctionID, 3822, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3835, "\',\'\',\'\')", 3835, 8, true);
            EndWriteAttribute();
            BeginContext(3844, 116, true);
            WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\" title=\"编辑\">编辑</a>\r\n                                <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3960, "\"", 4006, 3);
            WriteAttributeValue("", 3970, "$.mainu.delete(this,\'", 3970, 21, true);
#line 60 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
WriteAttributeValue("", 3991, m.FunctionID, 3991, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4004, "\')", 4004, 2, true);
            EndWriteAttribute();
            BeginContext(4007, 128, true);
            WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\" title=\"删除\">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 63 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4177, 120, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"pt-30\" style=\"width:100%; height:60px;\"></div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4376, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(4410, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0a13fdf073f45aaa75ca46d05b17b3a", async() => {
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
                BeginContext(4502, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4508, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39d05988703541b6b4543c4aedf49172", async() => {
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
                BeginContext(4609, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4615, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9583c9ae0144212b0794fff8b1362d7", async() => {
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
                BeginContext(4696, 1788, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.table-sort').dataTable({
                        ""lengthMenu"": false,                            //显示数量选择
                        ""bFilter"": false,                               //过滤功能
                        ""bPaginate"": false,                             //翻页信息
                        ""bInfo"": false,                                 //数量信息
                        ""aaSorting"": [[1, ""asc""]],                      //默认第几个排序
                        ""bStateSave"": true,                             //状态保存
                        ""aoColumnDefs"": [
                          { ""orderable"": false, ""aTargets"": [0, 7] }    // 制定列不参与排序
                        ],
                        ""aLengthMenu"": [5, 10, 25, 50, 100]
                    });
                },
                add: function (title,url,w,h) {
                    layer_show(title, url, w, h);
 ");
                WriteLiteral(@"               },
                edit: function (title, url, id, w, h) {
                    layer_show(title, url, w, h);
                },
                search: function () {
                    $keyword = $(""input[name='keyword']"").val();
                    if ($keyword == """") {
                        layer.alert('请输入功能节点编号', { icon: 5 });
                        return;
                    }
                    var url = ""?keyword="" + $keyword + """";
                    window.location.href = url;
                },
                stop: function (obj, id) {
                    layer.confirm('确认要停用吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(6485, 25, false);
#line 116 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(6510, 1495, true);
                WriteLiteral(@"',
                            data: { functionId: id, state: false },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;            //错误代码
                                var message = result.message;        //错误说明
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a style=""text-decoration:none"" onClick=""$.mainu.start(this,\'' + id + '\')"" href=""javascript:;"" title=""启用"">启用</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-defaunt radius"">已停用</span>');
                                    $(obj).remove();
                                    layer.msg('已停用!', { icon: 5, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                ");
                WriteLiteral(@"}
                            },
                            error: function (data) {
                                console.log(data.msg);
                            }
                        });
                    });
                },
                start: function (obj, id) {
                    layer.confirm('确认要启用吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(8006, 25, false);
#line 141 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(8031, 1492, true);
                WriteLiteral(@"',
                            data: { functionId: id, state: true },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;          //错误代码
                                var message = result.message;        //错误说明
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a style=""text-decoration:none"" onClick=""$.mainu.stop(this,\'' + id + '\')"" href=""javascript:;"" title=""停用"">停用</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-success radius"">已启用</span>');
                                    $(obj).remove();
                                    layer.msg('已启用!', { icon: 6, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
 ");
                WriteLiteral(@"                           },
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
                BeginContext(9524, 20, false);
#line 166 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                             Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(9544, 1730, true);
                WriteLiteral(@"',
                            data: { functionId: id },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").remove();
                                    layer.msg('已删除!', { icon: 1, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                            },
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                if (XMLHttpRequest.status != 200) {
                                    layer.alert(""系统错误！"", { icon: 5 });
                                }
                            }
                        });
              ");
                WriteLiteral(@"      });
                },
                deleteBatch: function () {
                    layer.confirm('确认要删除吗？', function (index) {
                        var arrId = [];
                        $(""input:checkbox[name='id']:checked"").each(function () {
                            //alert($(this).val());
                            arrId.push($(this).val());
                        });
                        if (arrId.length == 0) {
                            layer.msg('请选择需要删除日志！', { icon: 5, time: 2000 });
                            return;
                        }
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(11275, 25, false);
#line 200 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\SysFunction\List.cshtml"
                             Write(Url.Action("DeleteBatch"));

#line default
#line hidden
                EndContext();
                BeginContext(11300, 1149, true);
                WriteLiteral(@"',
                            data: { arrFunctionId: arrId },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;          //错误代码
                                var message = result.message;        //错误说明
                                if (state == ""success"") {
                                    window.location.replace(location.href);
                                } else {
                                    layer.msg(message, { icon: 5, time: 1000 });
                                }
                            },
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                if (XMLHttpRequest.status != 200) {
                                    layer.alert(""系统错误！"", { icon: 5 });
                                }
                            }
                        });
                    });
                }
      ");
                WriteLiteral("      };\r\n            $(function () {\r\n                $.mainu.init();\r\n            });\r\n        })(jQuery);\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(12452, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Sys_Function>> Html { get; private set; }
    }
}
#pragma warning restore 1591
