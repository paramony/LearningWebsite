#pragma checksum "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed3703b2cf759de7d4881f834ccc27bb2990aae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Index.cshtml", typeof(AspNetCore.Views_Course_Index))]
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
#line 1 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
using TopLearn.DataLayer.Entities.Course;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed3703b2cf759de7d4881f834ccc27bb2990aae", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e053f344d840e592988a6fe99c497cf4f1063565", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<TopLearn.Core.DTOs.Course.ShowCourseListItemViewModel>, int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "updatedate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(164, 399, true);
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">تاپ لرن</a></li>
            <li class=""breadcrumb-item active""><a href=""#"">دوره ها</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> برنامه نویسی وب </li>
        </ul>
    </nav>
</div>

<div class=""container"">
    ");
            EndContext();
            BeginContext(563, 6289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e36c7ba5fe54732aff606c54092cedf", async() => {
                BeginContext(615, 56, true);
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"pageid\" name=\"pageId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 671, "\"", 705, 1);
#line 19 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 679, ViewBag.pageId.ToString(), 679, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(706, 1584, true);
                WriteLiteral(@" />
        <section class=""term-categories"">

            <div class=""top-bar"">

                <header>
                    <h1> دوره های <span> برنامه نویسی وب </span> </h1> <span> 123 دوره </span>
                </header>

                <div class=""row"">
                    <div class=""col-md-4 col-sm-12 col-xs-12 pull-right"">
                        <div class=""input"">
                            <input type=""text"" name=""filter"" placeholder=""موضوع مورد نظر ..."">
                            <button><i class=""zmdi zmdi-search""></i></button>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-right"">
                        <div class=""switch-field available"">
                            <input id=""available-filter-1"" name=""getType"" value=""all"" checked="""" type=""radio"">
                            <label for=""available-filter-1""> همه </label>
                            <input id=""available-filter-2"" name=""getType""");
                WriteLiteral(@" value=""price"" type=""radio"">
                            <label for=""available-filter-2""> خریدنی </label>
                            <input id=""available-filter-3"" name=""getType"" value=""free"" type=""radio"">
                            <label for=""available-filter-3""> رایگان </label>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-left"">
                        <div class=""select-ddl"">
                            <select name=""orderByType"">
                                ");
                EndContext();
                BeginContext(2290, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79735cff50784ced8491e806b4710e09", async() => {
                    BeginContext(2311, 14, true);
                    WriteLiteral(" تاریخ انتشار ");
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
                BeginContext(2334, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2368, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "889f3877a1d44cdba97c906f87a3d9f7", async() => {
                    BeginContext(2395, 18, true);
                    WriteLiteral(" تاریخ بروز رسانی ");
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
                BeginContext(2422, 1405, true);
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">

                <aside class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">

                    <section class=""aside-section filter-by-price"">
                        <header>
                            <h3> فیلتر بر اساس قیمت </h3>
                        </header>
                        <div class=""price-range"">
                            <input type=""hidden"" value="""" id=""min-value"" name=""startPrice"">
                            <input type=""hidden"" value="""" id=""max-value"" name=""endPrice"">
                            <div class=""price-bar"">
                                <div id=""priceFilter""></div>
                            </div>
                            <div class=""max-price"">تا <span id=""max-text"">500000</span> تومان</div>
                            <div class=""min-price"">از <span id=""min-text"">20000</span> ");
                WriteLiteral(@"تومان</div>
                            <div class=""clearfix""></div>
                        </div>
                    </section>

                    <section class=""aside-section filter-by-category"">
                        <header>
                            <h3> دسته بندی موضوعات </h3>
                        </header>
                        <div class=""inner"">
");
                EndContext();
#line 81 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                              
                                List<CourseGroup> groups = ViewBag.Groups as List<CourseGroup>;
                                List<int> selected = ViewBag.selectedGroups as List<int>;
                            

#line default
#line hidden
                BeginContext(4078, 34, true);
                WriteLiteral("                            <ul>\r\n");
                EndContext();
#line 86 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                 foreach (var group in groups.Where(g => g.ParentId == null))
                                {

#line default
#line hidden
                BeginContext(4242, 130, true);
                WriteLiteral("                                    <li>\r\n                                        <input onchange=\"changeGroup()\" type=\"checkbox\" ");
                EndContext();
                BeginContext(4374, 56, false);
#line 89 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == group.GroupId) ? "checked" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(4431, 30, true);
                WriteLiteral(" name=\"selectedGroups\" value=\"");
                EndContext();
                BeginContext(4462, 13, false);
#line 89 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                                                                                                            Write(group.GroupId);

#line default
#line hidden
                EndContext();
                BeginContext(4475, 75, true);
                WriteLiteral("\" id=\"cat-1\">\r\n                                        <label for=\"cat-1\"> ");
                EndContext();
                BeginContext(4551, 16, false);
#line 90 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                       Write(group.GroupTitle);

#line default
#line hidden
                EndContext();
                BeginContext(4567, 11, true);
                WriteLiteral(" </label>\r\n");
                EndContext();
#line 91 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                         if (groups.Any(g => g.ParentId == group.GroupId))
                                        {

#line default
#line hidden
                BeginContext(4713, 50, true);
                WriteLiteral("                                            <ul>\r\n");
                EndContext();
#line 94 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                 foreach (var sub in groups.Where(g => g.ParentId == group.GroupId))
                                                {

#line default
#line hidden
                BeginContext(4932, 146, true);
                WriteLiteral("                                                    <li>\r\n                                                        <input onchange=\"changeGroup()\" ");
                EndContext();
                BeginContext(5080, 54, false);
#line 97 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == sub.GroupId) ? "checked" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(5135, 46, true);
                WriteLiteral(" type=\"checkbox\" name=\"selectedGroups\" value=\"");
                EndContext();
                BeginContext(5182, 11, false);
#line 97 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                                                                                                                          Write(sub.GroupId);

#line default
#line hidden
                EndContext();
                BeginContext(5193, 91, true);
                WriteLiteral("\" id=\"cat-1\">\r\n                                                        <label for=\"cat-1\"> ");
                EndContext();
                BeginContext(5285, 14, false);
#line 98 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                                       Write(sub.GroupTitle);

#line default
#line hidden
                EndContext();
                BeginContext(5299, 70, true);
                WriteLiteral(" </label>\r\n                                                    </li>\r\n");
                EndContext();
#line 100 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                }

#line default
#line hidden
                BeginContext(5420, 51, true);
                WriteLiteral("                                            </ul>\r\n");
                EndContext();
#line 102 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                        }

#line default
#line hidden
                BeginContext(5514, 45, true);
                WriteLiteral("\r\n                                    </li>\r\n");
                EndContext();
#line 105 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(5594, 294, true);
                WriteLiteral(@"                            </ul>
                        </div>
                    </section>

                </aside>

                <div class=""col-lg-9 col-md-8 col-sm-12 col-xs-12"">

                    <section class=""terms-items"">
                        <div class=""row"">
");
                EndContext();
#line 116 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                             foreach (var item in Model.Item1)
                            {

#line default
#line hidden
                BeginContext(5983, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(6015, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5bc2647d1d5248e8ab99aa0d3e296253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 118 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6058, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 119 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(6091, 36, true);
                WriteLiteral("                        </div>\r\n\r\n\r\n");
                EndContext();
#line 123 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                         if (Model.Item2 > 1)
                        {

#line default
#line hidden
                BeginContext(6201, 146, true);
                WriteLiteral("                            <nav aria-label=\"Page navigation\">\r\n                                <ul class=\"pagination justify-content-center\">\r\n\r\n");
                EndContext();
#line 128 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                     for (int i = 1; i <= (int)Model.Item2; i++)
                                    {

#line default
#line hidden
                BeginContext(6468, 82, true);
                WriteLiteral("                                        <li class=\"page-item\"><a class=\"page-link\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 6550, "\"", 6574, 3);
                WriteAttributeValue("", 6560, "changePage(", 6560, 11, true);
#line 130 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 6571, i, 6571, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 6573, ")", 6573, 1, true);
                EndWriteAttribute();
                BeginContext(6575, 10, true);
                WriteLiteral(" href=\"#\">");
                EndContext();
                BeginContext(6586, 1, false);
#line 130 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                                                Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(6587, 11, true);
                WriteLiteral("</a></li>\r\n");
                EndContext();
#line 131 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"

                                    }

#line default
#line hidden
                BeginContext(6639, 75, true);
                WriteLiteral("                                </ul>\r\n                            </nav>\r\n");
                EndContext();
#line 135 "C:\Users\paramony\Documents\Visual Studio 2017\Projects\TopLearn.Web\TopLearn.Web\Views\Course\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(6741, 104, true);
                WriteLiteral("\r\n                    </section>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6852, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6881, 2347, true);
                WriteLiteral(@"
    <script src=""/css/noUiSlider/nouislider.min.js""></script>
    <script src=""/js/script.js""></script>
    <script type=""text/javascript"">

        function changePage(pageid) {
            $(""#pageid"").val(pageid);
            $(""#formFilter"").submit();
        }

        $(function () {

            var slider = document.getElementById('priceFilter');
            noUiSlider.create(slider, {
                start: [20000, 100000],
                step: 5000,
                connect: true,
                direction: 'rtl',
                range: {
                    'min': 20000,
                    'max': 100000
                }
            });

            var marginMin = document.getElementById('min-text'),
                marginMax = document.getElementById('max-text');

            slider.noUiSlider.on('update', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    marginMax.innerHTML = xval");
                WriteLiteral(@"ue;
                } else {
                    marginMin.innerHTML = xvalue;
                }
                //console.log(values[handle]);
            });

            slider.noUiSlider.on('change', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    // setGetParameter('max_price', xvalue);
                    $('#max-value').val(xvalue);
                } else {
                    // setGetParameter('min_price', xvalue);
                    $('#min-value').val(xvalue);
                }
            });


            slider.noUiSlider.on('slide', function (values, handle) {

                console.log(values[0]);
                console.log(values[1]);

                var xvalue = Math.round(values[handle]);
                //updateSliderRange( Math.round(values[0]), Math.round(values[1]) );
            });



            function updateSliderRange(min, max) {
                slider.noUiSl");
                WriteLiteral(@"ider.updateOptions({
                    range: {
                        'min': min,
                        'max': max
                    }
                });
            }
        });

        function changeGroup() {
            $(""#formFilter"").submit();
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<TopLearn.Core.DTOs.Course.ShowCourseListItemViewModel>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
