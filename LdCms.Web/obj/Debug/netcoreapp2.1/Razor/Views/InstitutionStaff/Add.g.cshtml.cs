#pragma checksum "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa45f9b83d12c026270de97abfeb94d0428d651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InstitutionStaff_Add), @"mvc.1.0.view", @"/Views/InstitutionStaff/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InstitutionStaff/Add.cshtml", typeof(AspNetCore.Views_InstitutionStaff_Add))]
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
#line 1 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa45f9b83d12c026270de97abfeb94d0428d651", @"/Views/InstitutionStaff/Add.cshtml")]
    public class Views_InstitutionStaff_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ld_Institution_Staff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/validate-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/messages_zh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(201, 45, true);
            WriteLiteral("\r\n<article class=\"page-container\">\r\n    <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 246, "\"", 306, 1);
#line 11 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
WriteAttributeValue("", 255, Url.Action("Save",new { StaffId = Model.StaffID }), 255, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(307, 417, true);
            WriteLiteral(@" method=""post"" class=""form form-horizontal"" id=""form-add"">
        <div class=""row cl"">
            <div class=""admin-add-top-tips"">提示：员工初始化密码为手机后8位组成。</div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>员工工号：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 724, "\"", 746, 1);
#line 18 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
WriteAttributeValue("", 732, Model.StaffID, 732, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(747, 46, true);
            WriteLiteral(" placeholder=\"\" id=\"fStaffID\" name=\"fStaffID\" ");
            EndContext();
            BeginContext(795, 53, false);
#line 18 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                                                                                                      Write(string.IsNullOrEmpty(Model.StaffID) ? "" : "disabled");

#line default
#line hidden
            EndContext();
            BeginContext(849, 281, true);
            WriteLiteral(@" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>员工姓名：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1130, "\"", 1154, 1);
#line 24 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
WriteAttributeValue("", 1138, Model.StaffName, 1138, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1155, 402, true);
            WriteLiteral(@" placeholder="""" id=""fStaffName"" name=""fStaffName"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>性别：</label>
            <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                <div class=""radio-box"">
                    <input type=""radio"" id=""sex-1"" name=""fSex"" value=""1"" ");
            EndContext();
            BeginContext(1559, 39, false);
#line 31 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                                                     Write(Model.Sex.ToInt() == 1 ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1599, 193, true);
            WriteLiteral(" />\r\n                    <label for=\"sex-1\">男</label>\r\n                </div>\r\n                <div class=\"radio-box\">\r\n                    <input type=\"radio\" id=\"sex-2\" name=\"fSex\" value=\"2\" ");
            EndContext();
            BeginContext(1794, 39, false);
#line 35 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                                                     Write(Model.Sex.ToInt() == 2 ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1834, 193, true);
            WriteLiteral(" />\r\n                    <label for=\"sex-2\">女</label>\r\n                </div>\r\n                <div class=\"radio-box\">\r\n                    <input type=\"radio\" id=\"sex-3\" name=\"fSex\" value=\"0\" ");
            EndContext();
            BeginContext(2029, 39, false);
#line 39 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                                                     Write(Model.Sex.ToInt() == 0 ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2069, 1524, true);
            WriteLiteral(@" />
                    <label for=""sex-3"">保密</label>
                </div>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>担任职位：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <span class=""select-box"">
                    <select class=""select"" size=""1"" id=""fPositionId"" name=""fPositionId""></select>
                </span>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>所属部门：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <span class=""select-box"">
                    <select class=""select"" size=""1"" id=""fDepartmentId"" name=""fDepartmentId""></select>
                </span>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>所属网点：</lab");
            WriteLiteral(@"el>
            <div class=""formControls col-xs-8 col-sm-9"">
                <span class=""select-box"">
                    <select class=""select"" size=""1"" id=""fStoreId"" name=""fStoreId""></select>
                </span>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>联系手机：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3593, "\"", 3613, 1);
#line 71 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
WriteAttributeValue("", 3601, Model.Phone, 3601, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3614, 322, true);
            WriteLiteral(@" placeholder="""" id=""fPhone"" name=""fPhone"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>联系邮箱：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3936, "\"", 3956, 1);
#line 77 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
WriteAttributeValue("", 3944, Model.Email, 3944, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3957, 322, true);
            WriteLiteral(@" placeholder="""" id=""fEmail"" name=""fEmail"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>联系地址：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4279, "\"", 4301, 1);
#line 83 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
WriteAttributeValue("", 4287, Model.Address, 4287, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4302, 371, true);
            WriteLiteral(@" placeholder="""" id=""fAddress"" name=""fAddress"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">备注：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <textarea id=""fDescription"" name=""fDescription"" class=""textarea"" placeholder=""说点什么...100个字符以内"" dragonfly=""true"">");
            EndContext();
            BeginContext(4674, 27, false);
#line 89 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                                                                                                           Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4701, 429, true);
            WriteLiteral(@"</textarea>
                <p class=""textarea-numberbar""><em class=""textarea-length"">0</em>/100</p>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">审核：</label>
            <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                <div class=""check-box"">
                    <input type=""checkbox"" id=""fState"" name=""fState"" value=""1"" ");
            EndContext();
            BeginContext(5132, 37, false);
#line 97 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                                                           Write(Model.State.ToBool() ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(5170, 400, true);
            WriteLiteral(@" />
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
</article>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5649, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(5683, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb583c82fd7d408aa1244b540712c578", async() => {
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
                BeginContext(5785, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5791, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0bc48c4aa4f49938243f76d3771fc67", async() => {
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
                BeginContext(5894, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5900, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04922a5e71ae48e2b570099e94daa161", async() => {
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
                BeginContext(5998, 566, true);
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
                    $(""#fDescription"").Huitextarealength({
                        minlength: 4,
                        maxlength: 100
                    });
                    $.mainu.getPosition('");
                EndContext();
                BeginContext(6565, 16, false);
#line 133 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                    Write(Model.PositionID);

#line default
#line hidden
                EndContext();
                BeginContext(6581, 43, true);
                WriteLiteral("\');\r\n                    $.mainu.getStore(\'");
                EndContext();
                BeginContext(6625, 13, false);
#line 134 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                 Write(Model.StoreID);

#line default
#line hidden
                EndContext();
                BeginContext(6638, 48, true);
                WriteLiteral("\');\r\n                    $.mainu.getDepartment(\'");
                EndContext();
                BeginContext(6687, 18, false);
#line 135 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                                      Write(Model.DepartmentID);

#line default
#line hidden
                EndContext();
                BeginContext(6705, 113, true);
                WriteLiteral("\');\r\n                },\r\n                getPosition: function (setPositionId) {\r\n                    var url = \"");
                EndContext();
                BeginContext(6819, 31, false);
#line 138 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                          Write(Url.Action("position-list-get"));

#line default
#line hidden
                EndContext();
                BeginContext(6850, 1121, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.get(url, { state: true }, function (result) {
                        var state = result.state;
                        var message = result.message;
                        var strOption = '<option value="""">请选择担任职位</option>';
                        if (state == ""success"") {
                            var list = result.data;
                            for (var i = 0; i < list.length; i++) {
                                if (setPositionId == list[i].position_id)
                                    strOption += '<option value=""' + list[i].position_id + '"" selected>' + list[i].position_name + '</option>';
                                else
                                    strOption += '<option value=""' + list[i].position_id + '"">' + list[i].position_name + '</option>';
                            }
                        }
                        $(""#fPositionId"").html(strOption);
                    });
     ");
                WriteLiteral("           },\r\n                getStore: function (setStoreId) {\r\n                    var url = \"");
                EndContext();
                BeginContext(7972, 28, false);
#line 157 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                          Write(Url.Action("store-list-get"));

#line default
#line hidden
                EndContext();
                BeginContext(8000, 1110, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.get(url, { state: true }, function (result) {
                        var state = result.state;
                        var message = result.message;
                        var strOption = '<option value="""">请选择所属网点</option>';
                        if (state == ""success"") {
                            var list = result.data;
                            for (var i = 0; i < list.length; i++) {
                                if (setStoreId == list[i].store_id)
                                    strOption += '<option value=""' + list[i].store_id + '"" selected>' + list[i].store_name + '</option>';
                                else
                                    strOption += '<option value=""' + list[i].store_id + '"">' + list[i].store_name + '</option>';
                            }
                        }
                        $(""#fStoreId"").html(strOption);
                    });
                },
      ");
                WriteLiteral("          getDepartment: function (setDepartmentId) {\r\n                    var url = \"");
                EndContext();
                BeginContext(9111, 33, false);
#line 176 "I:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\InstitutionStaff\Add.cshtml"
                          Write(Url.Action("department-list-get"));

#line default
#line hidden
                EndContext();
                BeginContext(9144, 3351, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.get(url, { id: 0 }, function (result) {
                        var state = result.state;
                        var message = result.message;
                        var strOption = '<option value="""">请选择所属部门</option>';
                        if (state == ""success"") {
                            var list = result.data;
                            for (var i = 0; i < list.length; i++) {
                                if (setDepartmentId == list[i].department_id)
                                    strOption += '<option value=""' + list[i].department_id + '"" selected>' + list[i].space + list[i].level_symbol + list[i].department_name + '</option>';
                                else
                                    strOption += '<option value=""' + list[i].department_id + '"">' + list[i].space + list[i].level_symbol + list[i].department_name + '</option>';
                            }
                        }
      ");
                WriteLiteral(@"                  $(""#fDepartmentId"").html(strOption);
                    });
                },
                formSubmit: function () {
                    $(""#form-add"").validate({
                        rules: {
                            fStaffId: {
                                required: true
                            },
                            fStaffName: {
                                required: true
                            }
                        },
                        onkeyup: false,
                        focusCleanup: true,
                        success: ""valid"",
                        submitHandler: function (form) {
                            var fState = $(""input[name='fState']"").is(':checked');
                            $(form).ajaxSubmit({
                                type: ""POST"",
                                cache: false,
                                data: { fState: fState },
                                dataType: ""json"",
   ");
                WriteLiteral(@"                             error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""POST[FAIL]"", { icon: 5 });
                                    }
                                },
                                success: function (result) {
                                    var state = result.state;          //错误代码
                                    var message = result.message;        //错误说明
                                    if (state == ""success"") {
                                        var index = parent.layer.getFrameIndex(window.name);
                                        parent.location.reload();
                                        parent.layer.close(index);
                                    } else {
                                        layer.alert(message, { icon: 5 });
                                    }
                              ");
                WriteLiteral(@"  }
                            });
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
            BeginContext(12498, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ld_Institution_Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591
