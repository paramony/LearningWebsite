#pragma checksum "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Shared\_BoxCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d06a69427789265a29a7dda53a6d914247c7fa4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxCourse), @"mvc.1.0.view", @"/Views/Shared/_BoxCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_BoxCourse.cshtml", typeof(AspNetCore.Views_Shared__BoxCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d06a69427789265a29a7dda53a6d914247c7fa4a", @"/Views/Shared/_BoxCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e053f344d840e592988a6fe99c497cf4f1063565", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BoxCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.Core.DTOs.Course.ShowCourseListItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 88, true);
            WriteLiteral("\r\n<div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n    <article>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 150, "\"", 184, 2);
            WriteAttributeValue("", 157, "/ShowCourse/", 157, 12, true);
#line 5 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Shared\_BoxCourse.cshtml"
WriteAttributeValue("", 169, Model.CourseId, 169, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(185, 19, true);
            WriteLiteral(" class=\"img-layer\">");
            EndContext();
            BeginContext(204, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3cbe388c84874fc7b8803f7029274a21", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 235, "~/Course/thumb/", 235, 15, true);
#line 5 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Shared\_BoxCourse.cshtml"
AddHtmlAttributeValue("", 250, Model.ImageName, 250, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(268, 20, true);
            WriteLiteral("</a>\r\n        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 288, "\"", 322, 2);
            WriteAttributeValue("", 295, "/ShowCourse/", 295, 12, true);
#line 6 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Shared\_BoxCourse.cshtml"
WriteAttributeValue("", 307, Model.CourseId, 307, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(323, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(326, 11, false);
#line 6 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Shared\_BoxCourse.cshtml"
                                              Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(337, 27, true);
            WriteLiteral(" </a></h2>\r\n        <span> ");
            EndContext();
            BeginContext(366, 59, false);
#line 7 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Shared\_BoxCourse.cshtml"
           Write((Model.Price == 0) ? "رایگان" : Model.Price.ToString("#,0"));

#line default
#line hidden
            EndContext();
            BeginContext(426, 21, true);
            WriteLiteral(" </span>\r\n        <i>");
            EndContext();
            BeginContext(448, 15, false);
#line 8 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Shared\_BoxCourse.cshtml"
      Write(Model.TotalTime);

#line default
#line hidden
            EndContext();
            BeginContext(463, 45, true);
            WriteLiteral("</i>\r\n    </article>\r\n</div>\r\n<!-- /col -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Core.DTOs.Course.ShowCourseListItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
