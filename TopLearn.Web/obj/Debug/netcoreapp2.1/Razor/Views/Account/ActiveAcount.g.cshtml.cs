#pragma checksum "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Account\ActiveAcount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72fef19495d4135019719e9b30ebb69d9f785c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ActiveAcount), @"mvc.1.0.view", @"/Views/Account/ActiveAcount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ActiveAcount.cshtml", typeof(AspNetCore.Views_Account_ActiveAcount))]
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
#line 1 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\_ViewImports.cshtml"
using TopLearn.Core.DTOs;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72fef19495d4135019719e9b30ebb69d9f785c6a", @"/Views/Account/ActiveAcount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e053f344d840e592988a6fe99c497cf4f1063565", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ActiveAcount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Account\ActiveAcount.cshtml"
  
    ViewData["Title"] = "فعالسازی";

#line default
#line hidden
            BeginContext(46, 322, true);
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">فعال سازی حساب کاربری</li>
        </ul>
    </nav>
</div>

<div class=""container"">
");
            EndContext();
#line 16 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Account\ActiveAcount.cshtml"
     if (ViewBag.IsActive)
    {

#line default
#line hidden
            BeginContext(403, 204, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <p>حساب کاربری شما با موفقیت فعال شده است</p>\r\n            <p>\r\n                <a href=\"/login\">ورود به سایت</a>\r\n            </p>\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Account\ActiveAcount.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(631, 109, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p>حساب کاربری شما  فعال نشده است</p>\r\n        </div>\r\n");
            EndContext();
#line 30 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Account\ActiveAcount.cshtml"
    }

#line default
#line hidden
            BeginContext(747, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
