#pragma checksum "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c25e13618e687f0c3a4bbd64aa8450003651cb61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberAccount_Add), @"mvc.1.0.view", @"/Views/MemberAccount/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MemberAccount/Add.cshtml", typeof(AspNetCore.Views_MemberAccount_Add))]
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
#line 1 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25e13618e687f0c3a4bbd64aa8450003651cb61", @"/Views/MemberAccount/Add.cshtml")]
    public class Views_MemberAccount_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ld_Member_Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/validate-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/messages_zh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(198, 45, true);
            WriteLiteral("\r\n<article class=\"page-container\">\r\n    <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 243, "\"", 305, 1);
#line 11 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
WriteAttributeValue("", 252, Url.Action("Save",new { MemberID = Model.MemberID }), 252, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(306, 682, true);
            WriteLiteral(@" method=""post"" class=""form form-horizontal"" id=""form-add"">
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>会员等级：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <span class=""select-box"">
                    <select class=""select"" size=""1"" id=""fRankId"" name=""fRankId""></select>
                </span>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>公司名称：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 988, "\"", 1014, 1);
#line 23 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
WriteAttributeValue("", 996, Model.CompanyName, 996, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1015, 330, true);
            WriteLiteral(@" placeholder="""" id=""CompanyName"" name=""CompanyName"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>姓名：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1345, "\"", 1364, 1);
#line 29 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
WriteAttributeValue("", 1353, Model.Name, 1353, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1365, 392, true);
            WriteLiteral(@" placeholder="""" id=""fName"" name=""fName"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>性别：</label>
            <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                <div class=""radio-box"">
                    <input type=""radio"" id=""sex-1"" name=""fSex"" value=""1"" ");
            EndContext();
            BeginContext(1759, 39, false);
#line 36 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
                                                                     Write(Model.Sex.ToInt() == 1 ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1799, 193, true);
            WriteLiteral(" />\r\n                    <label for=\"sex-1\">男</label>\r\n                </div>\r\n                <div class=\"radio-box\">\r\n                    <input type=\"radio\" id=\"sex-2\" name=\"fSex\" value=\"2\" ");
            EndContext();
            BeginContext(1994, 39, false);
#line 40 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
                                                                     Write(Model.Sex.ToInt() == 2 ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2034, 193, true);
            WriteLiteral(" />\r\n                    <label for=\"sex-2\">女</label>\r\n                </div>\r\n                <div class=\"radio-box\">\r\n                    <input type=\"radio\" id=\"sex-3\" name=\"fSex\" value=\"0\" ");
            EndContext();
            BeginContext(2229, 39, false);
#line 44 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
                                                                     Write(Model.Sex.ToInt() == 0 ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2269, 354, true);
            WriteLiteral(@" />
                    <label for=""sex-3"">保密</label>
                </div>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>手机：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2623, "\"", 2643, 1);
#line 52 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
WriteAttributeValue("", 2631, Model.Phone, 2631, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2644, 320, true);
            WriteLiteral(@" placeholder="""" id=""fPhone"" name=""fPhone"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>邮箱：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2964, "\"", 2984, 1);
#line 58 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
WriteAttributeValue("", 2972, Model.Email, 2972, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2985, 320, true);
            WriteLiteral(@" placeholder="""" id=""fEmail"" name=""fEmail"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>地址：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3305, "\"", 3327, 1);
#line 64 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
WriteAttributeValue("", 3313, Model.Address, 3313, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3328, 377, true);
            WriteLiteral(@" placeholder="""" id=""fAddress"" name=""fAddress"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">备注：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <textarea id=""fRemark"" name=""fRemark"" cols="""" rows="""" class=""textarea"" placeholder=""说点什么...100个字符以内"" dragonfly=""true"">");
            EndContext();
            BeginContext(3706, 12, false);
#line 70 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
                                                                                                                                 Write(Model.Remark);

#line default
#line hidden
            EndContext();
            BeginContext(3718, 428, true);
            WriteLiteral(@"</textarea>
                <p class=""textarea-numberbar""><em class=""textarea-length""></em>/100</p>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">审核：</label>
            <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                <div class=""check-box"">
                    <input type=""checkbox"" id=""fState"" name=""fState"" value=""1"" ");
            EndContext();
            BeginContext(4148, 37, false);
#line 78 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
                                                                           Write(Model.State.ToBool() ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(4186, 400, true);
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
                BeginContext(4665, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(4699, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be1b31378a6f4b128aca96ea3626a01f", async() => {
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
                BeginContext(4791, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4797, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca68fa11e32249aa8aed51b143ceeec5", async() => {
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
                BeginContext(4899, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4905, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb8ae22a6e6149e38f52222ac98766c8", async() => {
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
                BeginContext(5008, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5014, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f00a81c6cbe2462cb47418d8c3e654d5", async() => {
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
                BeginContext(5112, 563, true);
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
                    $.mainu.getMemberRank(""");
                EndContext();
                BeginContext(5676, 12, false);
#line 115 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
                                      Write(Model.RankID);

#line default
#line hidden
                EndContext();
                BeginContext(5688, 108, true);
                WriteLiteral("\");\r\n                },\r\n                getMemberRank: function (rankid) {\r\n                    var url = \"");
                EndContext();
                BeginContext(5797, 27, false);
#line 118 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\MemberAccount\Add.cshtml"
                          Write(Url.Action("rank-list-get"));

#line default
#line hidden
                EndContext();
                BeginContext(5824, 3419, true);
                WriteLiteral(@""";
                    $.ajaxSetup({ cache: false });
                    $.get(url, { state: true }, function (result) {
                        var state = result.state;
                        var message = result.message;
                        var strOption = '<option value="""">请选择会员等级</option>';
                        if (state == ""success"") {
                            var list = result.data;
                            for (var i = 0; i < list.length; i++) {
                                if (rankid == list[i].id)
                                    strOption += '<option value=""' + list[i].id + '"" selected>' + list[i].name + '</option>';
                                else
                                    strOption += '<option value=""' + list[i].id + '"">' + list[i].name + '</option>';
                            }
                        }
                        $(""#fRankId"").html(strOption);
                    });
                },
                formSubmit: function () {");
                WriteLiteral(@"
                    $(""#form-add"").validate({
                        rules: {
                            fRankId: {
                                required: true
                            },
                            fName: {
                                required: true
                            },
                            fPhone: {
                                required: true
                            }
                        },
                        onkeyup: false,
                        focusCleanup: true,
                        success: ""valid"",
                        submitHandler: function (form) {
                            var fRankName = $(""select[name='fRankId']"").find(""option:selected"").text();
                            var fState = $(""input[name='fState']"").is(':checked');
                            $(form).ajaxSubmit({
                                type: ""POST"",
                                cache: false,
                                data:");
                WriteLiteral(@" { fRankName: fRankName, fState: fState },
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
                                        var index = parent.layer.getFrameIndex(window.name);
                                        parent.location.reload();
                                        parent.layer.close(index);
                                    } else {
                                        layer.alert(message, { icon: 5 });
 ");
                WriteLiteral(@"                                   }
                                }
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
            BeginContext(9246, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ld_Member_Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
