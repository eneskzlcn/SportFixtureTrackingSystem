#pragma checksum "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Point.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c5ef77a8f93b5d9acdefe41892c3ee5063692f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FixtureResults_Point), @"mvc.1.0.view", @"/Views/FixtureResults/Point.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5ef77a8f93b5d9acdefe41892c3ee5063692f", @"/Views/FixtureResults/Point.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a00addd179cdefeac1231a90b7fa99a4930a64", @"/Views/_ViewImports.cshtml")]
    public class Views_FixtureResults_Point : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Point.cshtml"
  
    Dictionary<Team, int> TeamPointPairs = ViewData["TeamPointPairs"] as Dictionary<Team, int>;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-center align-items-center h-100"">
    <h1 class=""mb-3"" style=""color:aliceblue"">Point Table</h1>

</div>

<table class=""table table-hover"" style=""background-color:#272727;"">
    <thead>
        <tr style=""color: aliceblue; text-align: center"">
            <th>
                Team
            </th>
            <th>
                Point
            </th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 26 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Point.cshtml"
         foreach (var item in TeamPointPairs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"color: aliceblue; text-align: center\">\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Point.cshtml"
               Write(Html.DisplayFor(modelItem => item.Key.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Point.cshtml"
               Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    \r\n                </td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\enesk\Homeworks-Projects\WebDesignProgramming\SportFixtureTracking\SportFixtureTracking\Views\FixtureResults\Point.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591