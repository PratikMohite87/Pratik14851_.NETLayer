#pragma checksum "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4e9f5b006d00e8aeeb6837a56a28d08312ca27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ModelDemo), @"mvc.1.0.view", @"/Views/Home/ModelDemo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4e9f5b006d00e8aeeb6837a56a28d08312ca27", @"/Views/Home/ModelDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e7a5a420d9bf604cdb0966080d61fb56565446", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ModelDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc4e9f5b006d00e8aeeb6837a56a28d08312ca273785", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ModelDemo</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc4e9f5b006d00e8aeeb6837a56a28d08312ca274848", async() => {
                WriteLiteral("\r\n    <h2>");
#nullable restore
#line 14 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
   Write(ViewBag.emp.EmployeeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <h2>");
#nullable restore
#line 15 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
   Write(ViewBag.emp.EmployeeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <h2>");
#nullable restore
#line 16 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
   Write(ViewBag.emp.EmployeeSal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
       
        Employee emp = ViewData["emp"] as Employee;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
Write(emp.EmployeeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
Write(emp.EmployeeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 24 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\Home\ModelDemo.cshtml"
Write(emp.EmployeeSal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
