#pragma checksum "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e28b0e0bbd6c9b51f67346f35a5d9c3618369da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InstitutionPosition_List), @"mvc.1.0.view", @"/Views/InstitutionPosition/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InstitutionPosition/List.cshtml", typeof(AspNetCore.Views_InstitutionPosition_List))]
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
#line 1 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e28b0e0bbd6c9b51f67346f35a5d9c3618369da", @"/Views/InstitutionPosition/List.cshtml")]
    public class Views_InstitutionPosition_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Institution_Position>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/laypage/1.2/laypage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/static/h-ui.admin/js/H-ui.admin.common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(218, 600, true);
            WriteLiteral(@"

<nav class=""breadcrumb""><i class=""Hui-iconfont"">&#xe67f;</i> 首页 <span class=""c-gray en"">&gt;</span> 公司管理 <span class=""c-gray en"">&gt;</span> 职位管理 <a id=""btn_refresh"" class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a></nav>
<div class=""page-container"">
    <div class=""text-c"">
        日期范围：
        <input type=""text"" onfocus=""WdatePicker({ maxDate:'#F{$dp.$D(\'datemax\')||\'%y-%M-%d\'}' })"" id=""datemin"" name=""datemin"" class=""input-text Wdate"" style=""width:120px;""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 818, "\"", 842, 1);
#line 15 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 826, ViewBag.datemin, 826, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(843, 196, true);
            WriteLiteral(" />\r\n        -\r\n        <input type=\"text\" onfocus=\"WdatePicker({ minDate:\'#F{$dp.$D(\\\'datemin\\\')}\',maxDate:\'%y-%M-%d\' })\" id=\"datemax\" name=\"datemax\" class=\"input-text Wdate\" style=\"width:120px;\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1039, "\"", 1063, 1);
#line 17 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 1047, ViewBag.datemax, 1047, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1064, 122, true);
            WriteLiteral(" />\r\n        <input type=\"text\" class=\"input-text\" style=\"width:350px\" placeholder=\"输入职位编号、名称\" id=\"keyword\" name=\"keyword\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1186, "\"", 1210, 1);
#line 18 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 1194, ViewBag.keyword, 1194, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1211, 420, true);
            WriteLiteral(@" />
        <button type=""submit"" class=""btn btn-success radius"" id=""driversearch"" name=""driversearch"" onclick=""$.mainu.search()""><i class=""Hui-iconfont"">&#xe665;</i> 查找</button>
    </div>
    <div class=""cl pd-5 bg-1 bk-gray mt-20"">
        <span class=""l"">
            <a href=""javascript:;"" onclick=""$.mainu.delBatch()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 批量删除</a>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1657, 1);
#line 24 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 1638, Url.Action("list"), 1638, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1658, 144, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe667;</i> 职位列表</a>\r\n            <a href=\"javascript:;\" class=\"btn btn-primary radius\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1802, "\"", 1858, 3);
            WriteAttributeValue("", 1812, "$.mainu.add(\'新增职位\',\'", 1812, 20, true);
#line 25 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 1832, Url.Action("add"), 1832, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1850, "\',\'\',\'\')", 1850, 8, true);
            EndWriteAttribute();
            BeginContext(1859, 102, true);
            WriteLiteral("><i class=\"Hui-iconfont\">&#xe600;</i> 新增职位</a>\r\n        </span>\r\n        <span class=\"r\">共有数据：<strong>");
            EndContext();
            BeginContext(1962, 13, false);
#line 27 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                                Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1975, 670, true);
            WriteLiteral(@"</strong> 条</span>
    </div>
    <div class=""mt-20"">
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""25""><input type=""checkbox"" name="""" value=""""></th>
                    <th width=""100"">职位编号</th>
                    <th width=""200"">职位名称</th>
                    <th width="""">描述</th>
                    <th width=""80"">排序</th>
                    <th width=""80"">状态</th>
                    <th width=""120"">加入时间</th>
                    <th width=""120"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 44 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(2770, 109, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td><input type=\"checkbox\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2879, "\"", 2900, 1);
#line 49 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 2887, m.PositionID, 2887, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2901, 40, true);
            WriteLiteral("></td>\r\n                            <td>");
            EndContext();
            BeginContext(2943, 58, false);
#line 50 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.PositionID, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3002, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3043, 60, false);
#line 51 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.PositionName, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3104, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(3159, 13, false);
#line 52 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                                          Write(m.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3172, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3212, 14, false);
#line 53 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                           Write(m.Sort.ToInt());

#line default
#line hidden
            EndContext();
            BeginContext(3226, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(3285, 148, false);
#line 54 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                                              Write(m.State.ToBool() ? Html.Raw("<span class='label label-success radius'>已启用</span>") : Html.Raw("<span class='label label-defaunt radius'>已停用</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(3434, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3475, 77, false);
#line 55 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                            Write(m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy-MM-dd HH:mm") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(3553, 59, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n");
            EndContext();
#line 57 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                                 if (m.State.ToBool())
                                {

#line default
#line hidden
            BeginContext(3703, 111, true);
            WriteLiteral("                                    <a title=\"停用\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 3814, "\"", 3858, 3);
            WriteAttributeValue("", 3824, "$.mainu.stop(this,\'", 3824, 19, true);
#line 59 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 3843, m.PositionID, 3843, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3856, "\')", 3856, 2, true);
            EndWriteAttribute();
            BeginContext(3859, 9, true);
            WriteLiteral(">停用</a>\r\n");
            EndContext();
#line 60 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3976, 111, true);
            WriteLiteral("                                    <a title=\"启用\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 4087, "\"", 4132, 3);
            WriteAttributeValue("", 4097, "$.mainu.start(this,\'", 4097, 20, true);
#line 63 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 4117, m.PositionID, 4117, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4130, "\')", 4130, 2, true);
            EndWriteAttribute();
            BeginContext(4133, 9, true);
            WriteLiteral(">启用</a>\r\n");
            EndContext();
#line 64 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(4177, 107, true);
            WriteLiteral("                                <a title=\"编辑\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4284, "\"", 4374, 3);
            WriteAttributeValue("", 4294, "$.mainu.edit(\'编辑\',\'", 4294, 19, true);
#line 65 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 4313, Url.Action("add", new { positionid = m.PositionID }), 4313, 53, false);

#line default
#line hidden
            WriteAttributeValue("", 4366, "\',\'\',\'\')", 4366, 8, true);
            EndWriteAttribute();
            BeginContext(4375, 116, true);
            WriteLiteral(">编辑</a>\r\n                                <a title=\"删除\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4491, "\"", 4534, 3);
            WriteAttributeValue("", 4501, "$.mainu.del(this,\'", 4501, 18, true);
#line 66 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
WriteAttributeValue("", 4519, m.PositionID, 4519, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4532, "\')", 4532, 2, true);
            EndWriteAttribute();
            BeginContext(4535, 75, true);
            WriteLiteral(">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 69 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4652, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4791, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(4825, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89f672adad684681a7e63d22157789dc", async() => {
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
                BeginContext(4917, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4923, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "119000b2226a40a1b9d894db3e25e138", async() => {
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
                BeginContext(5024, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5030, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5dc0580128246eca7ef4abd3b6c9fa6", async() => {
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
                BeginContext(5111, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5117, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64e3de2a159449069545dfade58dfd75", async() => {
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
                BeginContext(5213, 1625, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.table-sort').dataTable({
                        ""aaSorting"": [[1, ""asc""]],//默认第几个排序
                        ""bStateSave"": true,//状态保存
                        ""aoColumnDefs"": [
                          { ""orderable"": false, ""aTargets"": [0,7] }// 制定列不参与排序
                        ]
                    });
                },
                search: function () {
                    $dateMin = $(""input[name='datemin']"").val();
                    $dateMax = $(""input[name='datemax']"").val();
                    $keyword = $(""input[name='keyword']"").val();
                    if ($keyword == """") {
                        if ($dateMin == """" || $dateMax=="""") {
                            layer.alert('日期范围不能空', { icon: 5 });
                            return;
                        }
                    }
                    var url = ""?datemin="" + $");
                WriteLiteral(@"dateMin + ""&datemax="" + $dateMax + ""&keyword="" + $keyword + """";
                    window.location.href = url;
                },
                add: function (title, url, w, h) {
                    layer_show(title, url, w, h);
                },
                edit: function (title, url, w, h) {
                    layer_show(title, url, w, h);
                },
                stop: function (obj, id) {
                    layer.confirm('确认要停用吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(6839, 25, false);
#line 121 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(6864, 1476, true);
                WriteLiteral(@"',
                            data: { positionid: id, state: false },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""启用"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.start(this,\'' + id + '\')"">启用</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-defaunt radius"">已停用</span>');
                                    $(obj).remove();
                                    layer.msg('已停用！', { icon: 5, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                ");
                WriteLiteral(@"            },
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
                BeginContext(8341, 25, false);
#line 146 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(8366, 1472, true);
                WriteLiteral(@"',
                            data: { positionid: id, state: true },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""停用"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.stop(this,\'' + id + '\')"">停用</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-success radius"">已启用</span>');
                                    $(obj).remove();
                                    layer.msg('已启用！', { icon: 6, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                  ");
                WriteLiteral(@"          },
                            error: function (data) {
                                console.log(data.msg);
                            }
                        });
                    });
                },
                del: function (obj, id) {
                    layer.confirm('确认要删除吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(9839, 20, false);
#line 171 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                             Write(Url.Action("delete"));

#line default
#line hidden
                EndContext();
                BeginContext(9859, 1520, true);
                WriteLiteral(@"',
                            data: { positionid: id },
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
                delBatch: function () {
                    layer.confirm('确认要删除吗？', function (index) {
                 ");
                WriteLiteral(@"       var arrId = [];
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
                BeginContext(11380, 25, false);
#line 202 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionPosition\List.cshtml"
                             Write(Url.Action("deletebatch"));

#line default
#line hidden
                EndContext();
                BeginContext(11405, 957, true);
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
            BeginContext(12365, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Institution_Position>> Html { get; private set; }
    }
}
#pragma warning restore 1591
