#pragma checksum "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5db64322d6b5faeb1aa2fa2700e888eb8f340a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
using DancingGoat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5db64322d6b5faeb1aa2fa2700e888eb8f340a", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchResultsModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
  
    ViewBag.Title = String.Format(HtmlLocalizer["Results for \"{0}\""].Value, Model.Query);
    ViewData["PageClass"] = "inverted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
Write(HtmlLocalizer["Results for \"{0}\"", Model.Query]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
 if (!Model.Items.Any())
{
    if (!String.IsNullOrWhiteSpace(Model.Query))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
   Write(HtmlLocalizer["Sorry, no results match {0}", Model.Query]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                                                                  
    }
}
else
{
    foreach (var item in Model.Items)
    {
        if (item is SearchResultProductItemModel)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
       Write(Html.DisplayFor(m => item, nameof(SearchResultProductItemModel)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                                                                             
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
       Write(Html.DisplayFor(m => item, nameof(SearchResultPageItemModel)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                                                                          
        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"pagination-container\">\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 35 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
             if (Model.CurrentPage > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"PagedList-skipToPrevious\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5db64322d6b5faeb1aa2fa2700e888eb8f340a7264", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 39 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                   Write(HtmlLocalizer["previous"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = Model.GetRouteData(Model.CurrentPage - 1);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 42 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
             for (int pageNumber = 1; pageNumber <= Model.NumberOfPages; pageNumber++)
            {
                if (pageNumber == Model.CurrentPage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"active\">\r\n                        <span>\r\n                            ");
#nullable restore
#line 50 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                       Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </li>\r\n");
#nullable restore
#line 53 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5db64322d6b5faeb1aa2fa2700e888eb8f340a10517", async() => {
#nullable restore
#line 57 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                                                                                                  Write(pageNumber);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 57 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = Model.GetRouteData(pageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 59 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
             if (Model.CurrentPage < Model.NumberOfPages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"PagedList-skipToNext\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5db64322d6b5faeb1aa2fa2700e888eb8f340a12994", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 66 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
                   Write(HtmlLocalizer["next"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 65 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = Model.GetRouteData(Model.CurrentPage + 1);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 69 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 72 "C:\inetpub\wwwroot\Kentico13Test\DancingGoatCore\Views\Search\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchResultsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
