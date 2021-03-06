#pragma checksum "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de989abfa3cb38f97da8f28fb7753ea21ab56cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FixtureResults_Index), @"mvc.1.0.view", @"/Views/FixtureResults/Index.cshtml")]
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
#line 1 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\_ViewImports.cshtml"
using SportFixtureTracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\_ViewImports.cshtml"
using SportFixtureTracking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de989abfa3cb38f97da8f28fb7753ea21ab56cf4", @"/Views/FixtureResults/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a00addd179cdefeac1231a90b7fa99a4930a64", @"/Views/_ViewImports.cshtml")]
    public class Views_FixtureResults_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SportFixtureTracking.Models.FixtureResult>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-center align-items-center h-100"">
    <h1 class=""mb-3"" style=""color:aliceblue"">Fixture Results</h1>

</div>
<table class=""table table-hover"" style=""background-color:#272727;"">
    <thead>
        <tr style=""color: aliceblue; text-align: center"">
            <th>
                Home Team
            </th>
            <th>
                Away Team
            </th>
            <th>
                Home Team Score
            </th>
            <th>
                Away Team Score
            </th>
            <th>
                Is Finished
            </th>
            <th>
                Winner Team
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 36 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"color: aliceblue; text-align: center\">\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fixture.HomeTeam.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fixture.AwayTeam.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HomeTeamScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AwayTeamScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
#nullable restore
#line 51 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
              if (item.Fixture.IsFinished.Contains('Y'))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <i class=\"fas fa-check\" style=\"color:#26b118\"></i>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.WinnerTeam.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 59 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <i class=\"fas fa-times\" style=\"color:#e44141\"></i>\r\n                    </td>\r\n                    <td>\r\n                 \r\n                    </td>\r\n");
#nullable restore
#line 68 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
                }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"color: aliceblue; text-align: center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de989abfa3cb38f97da8f28fb7753ea21ab56cf48576", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-edit\" style=\"color:#c6ab19\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
                                           WriteLiteral(item.ResultId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de989abfa3cb38f97da8f28fb7753ea21ab56cf410907", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-trash-alt\" style=\"color:#bb3939\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
                                             WriteLiteral(item.ResultId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SportFixtureTracking.Models.FixtureResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
