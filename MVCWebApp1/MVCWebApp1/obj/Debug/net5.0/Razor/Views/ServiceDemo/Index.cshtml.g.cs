#pragma checksum "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698b353a365476fbfee8b822d41f83ae0d43bc53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceDemo_Index), @"mvc.1.0.view", @"/Views/ServiceDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698b353a365476fbfee8b822d41f83ae0d43bc53", @"/Views/ServiceDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e7a5a420d9bf604cdb0966080d61fb56565446", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<div class=""text-center"">
    <h3>
        Dependency Injection Lifetime
    </h3>
</div>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Service Type</th>
            <th>First Instance Operation ID</th>
            <th>Second Instance Operation ID</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style=""background-color: lightgreen""> Transient </td>
            <td style=""background-color: lightgreen"">  ");
#nullable restore
#line 24 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml"
                                                  Write(ViewBag.transient1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td style=\"background-color: lightgreen\"> ");
#nullable restore
#line 25 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml"
                                                 Write(ViewBag.transient2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"background-color: lightgoldenrodyellow\">Scoped</td>\r\n            <td style=\"background-color: lightgoldenrodyellow\">");
#nullable restore
#line 29 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml"
                                                          Write(ViewBag.scoped1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"background-color: lightgoldenrodyellow\">");
#nullable restore
#line 30 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml"
                                                          Write(ViewBag.scoped2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"background-color: lightskyblue\"> Singleton </td>\r\n            <td style=\"background-color: lightskyblue\"> ");
#nullable restore
#line 34 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml"
                                                   Write(ViewBag.singleton1);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n            <td style=\"background-color: lightskyblue\"> ");
#nullable restore
#line 35 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\ServiceDemo\Index.cshtml"
                                                   Write(ViewBag.singleton2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </td>
        </tr>
    </tbody>
</table>
<h3> Observation from Request 1 and Request 2</h3>
<table>
    <tr>
        <td>
            AddTransient
        </td>
        <td>

            Transient service always returns a new instance even though it???s the same request, that is why operation Ids are different for first instance and second instance for both the requests (Request 1 and Request 2).
        </td>
    </tr>
    <tr>
        <td>
            AddScoped
        </td>
        <td>
            In the case of Scoped service, a single instance is created per request and the same instance is shared across the request. That is why operation Ids are the same for first instance as well as second instance of Request 1. But if we click on refresh button or load the UI on different tab of a browser (which is nothing but Request 2), new ids are generated.
        </td>
    </tr>
    <tr>
        <td>
            AddSingleton
        </td>
        <td>
            In the case of Sing");
            WriteLiteral(@"leton service, only one instance is created and shared across applications. If we click on refresh button or load the UI on the different tab of a browser (which is nothing but Request 2), those ids will remain the same.
        </td>
    </tr>
</table>

");
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
