#pragma checksum "C:\Users\Admin\source\repos\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Company\CompanyAdded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb62b82bbdbb09d58125f58e7ec2d5738fc46f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_CompanyAdded), @"mvc.1.0.view", @"/Views/Company/CompanyAdded.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb62b82bbdbb09d58125f58e7ec2d5738fc46f1", @"/Views/Company/CompanyAdded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f0e01d906794e7d20db596d96f08e9d5ca555d", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_CompanyAdded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewBrandingStyleWeb.Models.CompanyAddedViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Ypur Company was successfully added</h1>\r\n<h5>Some stats:</h5>\r\n<div>Chars in Name: ");
#nullable restore
#line 5 "C:\Users\Admin\source\repos\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Company\CompanyAdded.cshtml"
               Write(Model.NumberOfCharInName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Chars in Description: ");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Company\CompanyAdded.cshtml"
                      Write(Model.NumberOfCharsInDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Is the Company currently hidden: ");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Company\CompanyAdded.cshtml"
                                  Write(Model.IsHidden ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewBrandingStyleWeb.Models.CompanyAddedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591