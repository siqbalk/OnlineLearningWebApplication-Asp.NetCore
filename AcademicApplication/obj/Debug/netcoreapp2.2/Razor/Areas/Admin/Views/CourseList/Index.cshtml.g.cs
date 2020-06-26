#pragma checksum "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92107a2c1e581734ed1a6f8ee68b0524c62cee30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CourseList_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CourseList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/CourseList/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_CourseList_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92107a2c1e581734ed1a6f8ee68b0524c62cee30", @"/Areas/Admin/Views/CourseList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CourseList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AcademicApplication.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 367, true);
            WriteLiteral(@"

<section class=""content-header"">
    <h1>
        CoursesList
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Tables</a></li>
        <li class=""active"">Data tables</li>
    </ol>
</section>

<div class=""text-center"" style=""margin-top:30px;margin-left:-450px"">

    ");
            EndContext();
            BeginContext(464, 28, false);
#line 20 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
Write(Html.Partial("Pages", Model));

#line default
#line hidden
            EndContext();
            BeginContext(492, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(543, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(554, 98, false);
#line 25 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
Write(await Component.InvokeAsync("AcademicApplication.Areas.Admin.ViewComponents.CoursesSearchByTitle"));

#line default
#line hidden
            EndContext();
            BeginContext(652, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(657, 91, false);
#line 27 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
Write(await Component.InvokeAsync("AcademicApplication.Areas.Admin.ViewComponents.CoursesSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(748, 177, true);
            WriteLiteral("\r\n\r\n<div class=\"box-body\">\r\n    <div id=\"example1_wrapper\" class=\"dataTables_wrapper form-inline dt-bootstrap\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n");
            EndContext();
#line 33 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
            BeginContext(981, 127, true);
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        Empty Data Found..\r\n                    </div>\r\n");
            EndContext();
#line 38 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                }
                else
                {



#line default
#line hidden
            BeginContext(1172, 1423, true);
            WriteLiteral(@"                    <table id=""example1"" class=""table table-bordered table-striped dataTable"" role=""grid"" aria-describedby=""example1_info"" style=""margin-top:25px;"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"" style=""width: 150px;"">Course Id</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"" style=""width: 200px;"">Title</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Platform(s): activate to sort column ascending"" style=""width: 160px;"">Price</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label");
            WriteLiteral(@"=""Engine version: activate to sort column ascending"" style=""width: 130px;"">Subject</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"" style=""width: 150px;"">Actions</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 54 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                             foreach (var course in Model)
                            {



#line default
#line hidden
            BeginContext(2690, 119, true);
            WriteLiteral("                                <tr role=\"row\" class=\"odd\">\r\n                                    <td class=\"sorting_1\">");
            EndContext();
            BeginContext(2810, 15, false);
#line 59 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                                                     Write(course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(2825, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2873, 12, false);
#line 60 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                                   Write(course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2885, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2933, 12, false);
#line 61 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                                   Write(course.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2945, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2993, 19, false);
#line 62 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                                   Write(course.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3012, 791, true);
            WriteLiteral(@"</td>
                                    <td style=""margin-left:-100px"">
                                        <a class=""btn btn-warning js-update"" href=""#"">
                                            <i class=""fa fa-pencil""></i>
                                        </a>
                                        <a class=""btn btn-danger js-user-delete"" href=""#"">
                                            <i class=""fa fa-trash""></i>
                                        </a>
                                        <a class=""btn btn-primary js-userroledetail"" href=""#"">
                                            <i class=""fa fa-list""></i>
                                        </a>
                                    </td>
                                </tr>
");
            EndContext();
#line 75 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(3836, 66, true);
            WriteLiteral("                        </tbody>\r\n\r\n                    </table>\r\n");
            EndContext();
#line 80 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3921, 141, true);
            WriteLiteral("\r\n            </div>\r\n        </div><div class=\"row\"></div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"text-center\" style=\"margin-left:-450px\">\r\n    ");
            EndContext();
            BeginContext(4063, 28, false);
#line 88 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\CourseList\Index.cshtml"
Write(Html.Partial("Pages", Model));

#line default
#line hidden
            EndContext();
            BeginContext(4091, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AcademicApplication.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591