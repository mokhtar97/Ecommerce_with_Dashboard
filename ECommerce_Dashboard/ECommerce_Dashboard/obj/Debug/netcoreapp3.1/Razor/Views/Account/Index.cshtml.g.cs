#pragma checksum "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff30b247b87e3b48a2103ff2ea3b6d4af6a58588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\_ViewImports.cshtml"
using ECommerce_Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\_ViewImports.cshtml"
using ECommerce_Dashboard.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff30b247b87e3b48a2103ff2ea3b6d4af6a58588", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140d645b188606a1263fe2a9307f4b640e67f8d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce_Dashboard.Models.UserData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    <a onclick=\"createUser()\" class=\"btn btn-success\">+Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 980, "\"", 1010, 3);
            WriteAttributeValue("", 990, "EditUser(\'", 990, 10, true);
#nullable restore
#line 35 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
WriteAttributeValue("", 1000, item.ID, 1000, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1008, "\')", 1008, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a> |\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1070, "\"", 1106, 3);
            WriteAttributeValue("", 1080, "getUserDetails(\'", 1080, 16, true);
#nullable restore
#line 36 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
WriteAttributeValue("", 1096, item.ID, 1096, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1104, "\')", 1104, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Details</a> |\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1169, "\"", 1201, 3);
            WriteAttributeValue("", 1179, "DeleteUser(\'", 1179, 12, true);
#nullable restore
#line 37 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
WriteAttributeValue("", 1191, item.ID, 1191, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1199, "\')", 1199, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Account\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerce_Dashboard.Models.UserData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
