#pragma checksum "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7e743cdf96a65b096d92adfcd50e8ca8601b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmpDeptData), @"mvc.1.0.view", @"/Views/Employee/EmpDeptData.cshtml")]
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
#line 1 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\_ViewImports.cshtml"
using MVCWebApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\_ViewImports.cshtml"
using MVCWebApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\_ViewImports.cshtml"
using DataAccessLayerLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
using MVCWebApp1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7e743cdf96a65b096d92adfcd50e8ca8601b9e", @"/Views/Employee/EmpDeptData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e7a5a420d9bf604cdb0966080d61fb56565446", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmpDeptData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmptDeptViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
  
    ViewData["Title"] = "EmpDeptData";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>EmpDeptData</h1>

<table>
    <tr>
        <th>Employee No</th>
        <th>Employee Name</th>
        <th>Employee Job</th>
        <th>Employee Salary</th>
        <th>Employee yEARS</th>
        <th>Department Name</th>
        <th>Department Location</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
     foreach (EmptDeptViewModel data in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
           Write(data.Emp.Empno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
           Write(data.Emp.Ename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
           Write(data.Emp.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td");
            BeginWriteAttribute("style", " style=\"", 600, "\"", 631, 2);
            WriteAttributeValue("", 608, "color:", 608, 6, true);
#nullable restore
#line 25 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
WriteAttributeValue("", 614, data.SalaryColor, 614, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
                                           Write(data.Emp.Sal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
           Write(data.Years);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
           Write(data.Dept.Dname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
           Write(data.Dept.Loc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Employee\EmpDeptData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmptDeptViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
