#pragma checksum "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2622f6ae2eece38fefaebefba4868c2fe2ca4155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AppUser_AllUserList), @"mvc.1.0.view", @"/Areas/Admin/Views/AppUser/AllUserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AppUser/AllUserList.cshtml", typeof(AspNetCore.Areas_Admin_Views_AppUser_AllUserList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2622f6ae2eece38fefaebefba4868c2fe2ca4155", @"/Areas/Admin/Views/AppUser/AllUserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AppUser_AllUserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AcademicApplication.Areas.Admin.ViewModels.UserListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AppUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAppUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddUserbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success js-userroledetail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AppUserRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
  
    ViewData["Title"] = "AllUserList";

#line default
#line hidden
            BeginContext(129, 625, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        UsersList
        <small>All Users</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Tables</a></li>
        <li class=""active"">Data tables</li>
    </ol>
</section>

<div class=""box-body"">
    <div id=""example1_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
        <div class=""row""><div class=""col-sm-6""><div class=""dataTables_length"" id=""example1_length""><label>Show <select name=""example1_length"" aria-controls=""example1"" class=""form-control input-sm"">");
            EndContext();
            BeginContext(754, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2622f6ae2eece38fefaebefba4868c2fe2ca41557925", async() => {
                BeginContext(773, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(784, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2622f6ae2eece38fefaebefba4868c2fe2ca41559191", async() => {
                BeginContext(803, 2, true);
                WriteLiteral("25");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(814, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2622f6ae2eece38fefaebefba4868c2fe2ca415510457", async() => {
                BeginContext(833, 2, true);
                WriteLiteral("50");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(844, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2622f6ae2eece38fefaebefba4868c2fe2ca415511724", async() => {
                BeginContext(864, 3, true);
                WriteLiteral("100");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(876, 341, true);
            WriteLiteral(@"</select> entries</label></div></div><div class=""col-sm-6""><div id=""example1_filter"" class=""dataTables_filter""><label>Search:<input type=""search"" class=""form-control input-sm"" placeholder="""" aria-controls=""example1""></label></div></div></div><div class=""row"">
            <div class=""form-group"" style=""margin-left:900px"">
                ");
            EndContext();
            BeginContext(1217, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2622f6ae2eece38fefaebefba4868c2fe2ca415513457", async() => {
                BeginContext(1338, 52, true);
                WriteLiteral("\r\n                    Add New User\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1394, 59, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-12\">\r\n");
            EndContext();
#line 26 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
            BeginContext(1509, 127, true);
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        Empty Data Found..\r\n                    </div>\r\n");
            EndContext();
#line 31 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1696, 1220, true);
            WriteLiteral(@"                    <table id=""example1"" class=""table table-bordered table-striped dataTable"" role=""grid"" aria-describedby=""example1_info"" style=""margin-top:25px;"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"" style=""width: 150px;"">User Name</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"" style=""width: 180px;"">EMail Address</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Engine version: activate to sort column ascending"" style=""width: 130px;"">Role</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" ");
            WriteLiteral("aria-label=\"CSS grade: activate to sort column ascending\" style=\"width: 150px;\">Actions</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 44 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                             foreach (var user in Model)
                            {


#line default
#line hidden
            BeginContext(3007, 119, true);
            WriteLiteral("                                <tr role=\"row\" class=\"odd\">\r\n                                    <td class=\"sorting_1\">");
            EndContext();
            BeginContext(3127, 14, false);
#line 48 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                                     Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3141, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3143, 13, false);
#line 48 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                                                     Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3156, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3204, 10, false);
#line 49 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                   Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3214, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 51 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                         if (user.role == null)
                                        {
                                            

#line default
#line hidden
#line 53 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                             foreach (var role in user.Roles)
                                            {

                                                

#line default
#line hidden
            BeginContext(3548, 4, false);
#line 56 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                           Write(role);

#line default
#line hidden
            EndContext();
#line 56 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                                     
                                            }

#line default
#line hidden
#line 57 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                             
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(3778, 9, false);
#line 61 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                       Write(user.role);

#line default
#line hidden
            EndContext();
#line 61 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                                      
                                        }

#line default
#line hidden
            BeginContext(3832, 789, true);
            WriteLiteral(@"
                                    </td>

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
                                        ");
            EndContext();
            BeginContext(4621, 253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2622f6ae2eece38fefaebefba4868c2fe2ca415522666", async() => {
                BeginContext(4767, 103, true);
                WriteLiteral("\r\n                                            <i>EditRole</i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                                                                                                                                                             WriteLiteral(user.AppUserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4874, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 81 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                            }

#line default
#line hidden
            BeginContext(4989, 72, true);
            WriteLiteral("\r\n\r\n\r\n                        </tbody>\r\n\r\n                    </table>\r\n");
            EndContext();
#line 88 "D:\HiaerNetdata\Asp.Net Core Web  Applications\AcademicApplication\AcademicApplication\Areas\Admin\Views\AppUser\AllUserList.cshtml"
                }

#line default
#line hidden
            BeginContext(5080, 1022, true);
            WriteLiteral(@"
            </div>
        </div><div class=""row""><div class=""col-sm-5""><div class=""dataTables_info"" id=""example1_info"" role=""status"" aria-live=""polite"">Showing 1 to 25 of 57 entries</div></div><div class=""col-sm-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""example1_paginate""><ul class=""pagination""><li class=""paginate_button previous disabled"" id=""example1_previous""><a href=""#"" aria-controls=""example1"" data-dt-idx=""0"" tabindex=""0"">Previous</a></li><li class=""paginate_button active""><a href=""#"" aria-controls=""example1"" data-dt-idx=""1"" tabindex=""0"">1</a></li><li class=""paginate_button ""><a href=""#"" aria-controls=""example1"" data-dt-idx=""2"" tabindex=""0"">2</a></li><li class=""paginate_button ""><a href=""#"" aria-controls=""example1"" data-dt-idx=""3"" tabindex=""0"">3</a></li><li class=""paginate_button next"" id=""example1_next""><a href=""#"" aria-controls=""example1"" data-dt-idx=""4"" tabindex=""0"">Next</a></li></ul></div></div></div>
    </div>
</div>

<div class=""modal"" id=""AdduserModal"">

</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6119, 634, true);
                WriteLiteral(@"
    <script>

       //Create
        $(function () {
            $(""#AddUserbtn"").on(""click"", function (e) {
                e.preventDefault();
                var btn = $(this);
                console.log(""Button 1 is working..."");
                $.ajax({
                    url: btn.attr('href'),
                    type: 'GET',
                    success: function (response) {
                        $(""#AdduserModal"").html(response);
                        $(""#AdduserModal"").modal('show');
                    }
                });
            });
        })
            
             </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AcademicApplication.Areas.Admin.ViewModels.UserListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
