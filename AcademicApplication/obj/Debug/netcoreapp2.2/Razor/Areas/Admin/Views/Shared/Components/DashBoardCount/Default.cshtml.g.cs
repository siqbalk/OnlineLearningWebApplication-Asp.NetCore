#pragma checksum "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d706d78fec395d042a5f7fd7cc8e6121f70ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_DashBoardCount_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/DashBoardCount/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/DashBoardCount/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_DashBoardCount_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d706d78fec395d042a5f7fd7cc8e6121f70ed9", @"/Areas/Admin/Views/Shared/Components/DashBoardCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_DashBoardCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AcademicApplication.Areas.Admin.ViewModels.DashBoardCountViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml"
  

    Layout = null;

#line default
#line hidden
            BeginContext(106, 303, true);
            WriteLiteral(@"

<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-aqua""><i class=""ion ion-android-person""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">User</span>
            <span class=""info-box-number"">");
            EndContext();
            BeginContext(410, 15, false);
#line 15 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml"
                                     Write(Model.UserCount);

#line default
#line hidden
            EndContext();
            BeginContext(425, 407, true);
            WriteLiteral(@"</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>

<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-yellow""><i class=""ion ion-person-add""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">Roles</span>
            <span class=""info-box-number"">");
            EndContext();
            BeginContext(833, 15, false);
#line 28 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml"
                                     Write(Model.RoleCount);

#line default
#line hidden
            EndContext();
            BeginContext(848, 426, true);
            WriteLiteral(@"</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>
<!-- /.col -->
<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-aqua-active""><i class=""ion ion-ios-book""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">Subject</span>
            <span class=""info-box-number"">");
            EndContext();
            BeginContext(1275, 18, false);
#line 41 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml"
                                     Write(Model.SubjectCount);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 403, true);
            WriteLiteral(@"</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>
<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-red""><i class=""fa fa-folder-open""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">Courses</span>
            <span class=""info-box-number"">");
            EndContext();
            BeginContext(1697, 17, false);
#line 53 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml"
                                     Write(Model.CourseCount);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 431, true);
            WriteLiteral(@"</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>

<!-- /.col -->
<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-fuchsia""><i class=""ion ion-ios-book-outline""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">Topics</span>
            <span class=""info-box-number"">");
            EndContext();
            BeginContext(2146, 16, false);
#line 67 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml"
                                     Write(Model.TopicCount);

#line default
#line hidden
            EndContext();
            BeginContext(2162, 495, true);
            WriteLiteral(@"</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>
<!-- fix for small devices only -->
<div class=""clearfix visible-sm-block""></div>

<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-green""><i class=""ion ion-ios-cart-outline""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">Cart</span>
            <span class=""info-box-number"">");
            EndContext();
            BeginContext(2658, 15, false);
#line 82 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\Shared\Components\DashBoardCount\Default.cshtml"
                                     Write(Model.CartCount);

#line default
#line hidden
            EndContext();
            BeginContext(2673, 979, true);
            WriteLiteral(@"</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>



<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-maroon""><i class=""ion ion-arrow-graph-down-right""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">Order</span>
            <span class=""info-box-number"">10</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>
<!-- /.col -->
<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-blue""><i class=""ion ion-ios-cart-outline""></i></span>

        <div class=""info-box-content"">
            <span class=""info-box-text"">Sale</span>
            <span class=""info-box-number"">5</span>
        </div>
        <!-- /.info-box-content -->
    </div>
    <!-- /.info-box -->
</div>




<!-- /.col -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcademicApplication.Areas.Admin.ViewModels.DashBoardCountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591