#pragma checksum "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcb62de43972ed7996daea2dd9d5bfce891267b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SubjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SubjectList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SubjectList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SubjectList_Default))]
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
#line 1 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\_ViewImports.cshtml"
using AcademicApplication;

#line default
#line hidden
#line 2 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\_ViewImports.cshtml"
using AcademicApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb62de43972ed7996daea2dd9d5bfce891267b9", @"/Views/Shared/Components/SubjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42987af25e7f27b4ba70865e7c0dd2469cf48093", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SubjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AcademicApplication.ViewModels.SubjectListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CourseList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-SubjectList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(128, 79, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        Empty Data Found..\r\n    </div>\r\n");
            EndContext();
#line 12 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
}
else
{

    

#line default
#line hidden
#line 16 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
     foreach (var subject in Model)
    {


#line default
#line hidden
            BeginContext(267, 72, true);
            WriteLiteral("    <li class=\"control \" style=\"color:black\" id=\"SubjectList\">\r\n        ");
            EndContext();
            BeginContext(339, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcb62de43972ed7996daea2dd9d5bfce891267b96093", async() => {
                BeginContext(455, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(470, 19, false);
#line 21 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
       Write(subject.SubjectName);

#line default
#line hidden
                EndContext();
                BeginContext(489, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#line 20 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
                                                                          Write(subject.SubjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(503, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 24 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
 

    }

#line default
#line hidden
#line 26 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Views\Shared\Components\SubjectList\Default.cshtml"
     

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AcademicApplication.ViewModels.SubjectListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
