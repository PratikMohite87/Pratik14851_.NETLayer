#pragma checksum "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\BirthdayParty\Acknowledgment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a4a7d2d610a68aff6f61a7507da52fab315a330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BirthdayParty_Acknowledgment), @"mvc.1.0.view", @"/Views/BirthdayParty/Acknowledgment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a4a7d2d610a68aff6f61a7507da52fab315a330", @"/Views/BirthdayParty/Acknowledgment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e7a5a420d9bf604cdb0966080d61fb56565446", @"/Views/_ViewImports.cshtml")]
    public class Views_BirthdayParty_Acknowledgment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\BirthdayParty\Acknowledgment.cshtml"
  
    ViewData["Title"] = "Acknowledgment";
    Guest guest = ViewBag.guest;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>\r\n        Thankyou ");
#nullable restore
#line 9 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\BirthdayParty\Acknowledgment.cshtml"
            Write(guest.GuestName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" for your response.\r\n    </h3>\r\n    \r\n");
#nullable restore
#line 12 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\BirthdayParty\Acknowledgment.cshtml"
       
        if (guest.GuestDecision == "yes")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<h6 class=\"text-success\">Thankyou for coming</h6>\r\n");
#nullable restore
#line 16 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\BirthdayParty\Acknowledgment.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<h6 class=\"text-danger\">We will miss you</h6>\r\n");
#nullable restore
#line 20 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\MVCWebApp1\MVCWebApp1\Views\BirthdayParty\Acknowledgment.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
