#pragma checksum "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab11ce15a296f5a1d56304e0a93253376969382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CompanyEdit_default), @"mvc.1.0.view", @"/Views/Shared/Components/CompanyEdit/default.cshtml")]
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
#line 1 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\_ViewImports.cshtml"
using HRManagement.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab11ce15a296f5a1d56304e0a93253376969382", @"/Views/Shared/Components/CompanyEdit/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb69b4319557e392d6ffc765455e9c01730f9e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CompanyEdit_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HRManagement.Data.Entities.Company>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<div class=""row"">
    <div class=""col-md-1"">

    </div>
    <div class=""col-md-11"">
        <table class=""table"">
            <thead>
                <tr>
                    
                    <th scope=""col"">Şirket Logo</th>
                    <th scope=""col"">Şirket Adı</th>
                    <th scope=""col"">Adres</th>
                    <th scope=""col"">Vergi Numarası</th>
                    <th scope=""col"">Telefon</th>
                </tr>
            </thead>

");
#nullable restore
#line 23 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <td>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 729, "\"", 745, 1);
#nullable restore
#line 28 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
WriteAttributeValue("", 735, item.Logo, 735, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50px; border-radius: 50%;\" />\r\n\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 31 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
                       Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 32 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
                       Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
                       Write(item.TaxNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
                       Write(item.TelNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <span>");
#nullable restore
#line 35 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
                         Write(Html.ActionLink("edit", "Edit", new { ID = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </tr>\r\n\r\n                </tbody>\r\n");
#nullable restore
#line 39 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\CompanyEdit\default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HRManagement.Data.Entities.Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
