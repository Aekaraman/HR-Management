#pragma checksum "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22965e90a24df31a9be3dd5d6490edf82db4b129"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PublicHolidayEditList_default), @"mvc.1.0.view", @"/Views/Shared/Components/PublicHolidayEditList/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22965e90a24df31a9be3dd5d6490edf82db4b129", @"/Views/Shared/Components/PublicHolidayEditList/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb69b4319557e392d6ffc765455e9c01730f9e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PublicHolidayEditList_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HRManagement.Data.Entities.PublicHolidays>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .column {\r\n        float: left;\r\n        width: 20%;\r\n    }\r\n</style>\r\n<div class=\"card w-75\">\r\n    <div class=\"card-header\">\r\n        Resmi Tatiller\r\n    </div>\r\n    <div class=\"card-body \">\r\n\r\n        <table>\r\n");
#nullable restore
#line 16 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"column\"> ");
#nullable restore
#line 22 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"column\">");
#nullable restore
#line 23 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                               Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"column\">");
#nullable restore
#line 24 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                               Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"column\">");
#nullable restore
#line 25 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                               Write(Html.ActionLink("D??zenle", "Edit", new { ID = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"column\">");
#nullable restore
#line 26 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                               Write(Html.ActionLink("Sil", "Delete", new { ID = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 51 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                           

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\aek\VS\HRManagementv3\HRManagement\HRManagement.WebUI\Views\Shared\Components\PublicHolidayEditList\default.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HRManagement.Data.Entities.PublicHolidays>> Html { get; private set; }
    }
}
#pragma warning restore 1591
