#pragma checksum "C:\Users\PC\source\repos\School\Views\Home\AllCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0a078fd8231b6e882d1db9cbb32c0f2838fa68e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllCourses), @"mvc.1.0.view", @"/Views/Home/AllCourses.cshtml")]
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
#nullable restore
#line 1 "C:\Users\PC\source\repos\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\School\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a078fd8231b6e882d1db9cbb32c0f2838fa68e", @"/Views/Home/AllCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<School.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\source\repos\School\Views\Home\AllCourses.cshtml"
  
    ViewData["Title"] = "Courses";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kursy: </h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                CourseId
            </th>
            <th>
                Nazwa
            </th>
            <th>
                Ects
            </th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 25 "C:\Users\PC\source\repos\School\Views\Home\AllCourses.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\PC\source\repos\School\Views\Home\AllCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.CourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\PC\source\repos\School\Views\Home\AllCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\PC\source\repos\School\Views\Home\AllCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ects));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\PC\source\repos\School\Views\Home\AllCourses.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<School.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591