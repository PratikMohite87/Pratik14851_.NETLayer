#pragma checksum "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a5bf4537c210e651b55f87d459033fddb3c1fd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dal_Index), @"mvc.1.0.view", @"/Views/Dal/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5bf4537c210e651b55f87d459033fddb3c1fd8", @"/Views/Dal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e7a5a420d9bf604cdb0966080d61fb56565446", @"/Views/_ViewImports.cshtml")]
    public class Views_Dal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Emp>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>EmpNo</th>\r\n        <th>EmpName</th>\r\n        <th>Hiredate</th>\r\n        <th>Sal</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml"
       
        foreach(Emp emp in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml"
               Write(emp.EmpNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml"
               Write(emp.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml"
               Write(emp.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml"
               Write(emp.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Dal\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Emp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
