#pragma checksum "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "151180a720ac458080101da9c8c2efd33e805765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylist_Details), @"mvc.1.0.view", @"/Views/Stylist/Details.cshtml")]
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
#line 1 "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151180a720ac458080101da9c8c2efd33e805765", @"/Views/Stylist/Details.cshtml")]
    public class Views_Stylist_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 4 "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml"
Write(Html.DisplayFor(model => model.StylistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml"
 if (@Model.Clients.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p> No clients have been added yet!</p>\r\n");
#nullable restore
#line 9 "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 12 "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml"
   foreach (Client client in @Model.Clients)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li> ");
#nullable restore
#line 14 "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml"
    Write(Html.ActionLink($"{client.ClientName}", "Details", new { id = client.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\Users\coltt\OneDrive\Desktop\Claires-Salon.Solution\HairSalon\Views\Stylist\Details.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
