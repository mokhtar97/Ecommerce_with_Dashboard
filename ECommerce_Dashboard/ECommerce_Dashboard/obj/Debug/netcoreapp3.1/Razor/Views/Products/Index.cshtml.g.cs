#pragma checksum "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae850a803436afb33bb761e217be0c22ae4d458e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
using X.PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae850a803436afb33bb761e217be0c22ae4d458e", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140d645b188606a1263fe2a9307f4b640e67f8d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<WebApplication1.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<p>\r\n    <a onclick=\"createPoduct()\" class=\"btn btn-success\">+Create New</a>\r\n</p>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae850a803436afb33bb761e217be0c22ae4d458e6550", async() => {
                WriteLiteral("\r\n        <div class=\"form-actions no-color\">\r\n            <p>\r\n                Find by name: <input type=\"text\" id=\"search\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 401, "\"", 435, 1);
#nullable restore
#line 15 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue("", 409, ViewData["currentFilter"], 409, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <input type=""submit"" value=""Search"" href=""#"" onclick=""getProductsBySearch(document.getElementById('search').value)"" class=""btn btn-default"" /> |
                <a href=""#"" onclick=""getProducts()"" class=""btn btn-primary"">Back to List</a>
            </p>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Quntaty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 46 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quntaty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae850a803436afb33bb761e217be0c22ae4d458e12816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 59 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
                               WriteLiteral(item.picture);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 62 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
                   Write(ViewBag.CatID[@item.CatID - 1].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2611, "\"", 2642, 3);
            WriteAttributeValue("", 2621, "EditProduct(", 2621, 12, true);
#nullable restore
#line 71 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue("", 2633, item.ID, 2633, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2641, ")", 2641, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a> |\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2706, "\"", 2743, 3);
            WriteAttributeValue("", 2716, "getProductDetails(", 2716, 18, true);
#nullable restore
#line 72 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue("", 2734, item.ID, 2734, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2742, ")", 2742, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Details</a> |\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2810, "\"", 2843, 3);
            WriteAttributeValue("", 2820, "DeleteProduct(", 2820, 14, true);
#nullable restore
#line 73 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue("", 2834, item.ID, 2834, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2842, ")", 2842, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 76 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 80 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"text-align:center\">\r\n        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3186, "\"", 3233, 3);
            WriteAttributeValue("", 3196, "getProducts(", 3196, 12, true);
#nullable restore
#line 85 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue("", 3208, Model.PageNumber - 1, 3208, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3231, ");", 3231, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n           class=\"", 3234, "\"", 3283, 3);
            WriteAttributeValue("", 3254, "btn", 3254, 3, true);
            WriteAttributeValue(" ", 3257, "btn-default", 3258, 12, true);
#nullable restore
#line 86 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 3269, prevDisabled, 3270, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Previous\r\n        </a>\r\n\r\n        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3344, "\"", 3391, 3);
            WriteAttributeValue("", 3354, "getProducts(", 3354, 12, true);
#nullable restore
#line 90 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue("", 3366, Model.PageNumber + 1, 3366, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3389, ");", 3389, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n           class=\"", 3392, "\"", 3441, 3);
            WriteAttributeValue("", 3412, "btn", 3412, 3, true);
            WriteAttributeValue(" ", 3415, "btn-default", 3416, 12, true);
#nullable restore
#line 91 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 3427, nextDisabled, 3428, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Next\r\n        </a>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.3/signalr.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae850a803436afb33bb761e217be0c22ae4d458e21227", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script type=""text/javascript"">
        $(function () {
            // Create a proxy to signalr hub on web server. It reference the hub.
            var connection = new signalR.HubConnectionBuilder().withUrl(""/notificationhubs"").build();

            // Connect to signalr hub
            $.connection.hub.start().done(function () {
                console.log(""Connection Started"");
                getProducts();
            });

            // Notify to client with the recent updates
        //    notificationFromHub.client.updatedClients = function () {
        //        getProducts();
        //    };
        //});


        connection.on(""updatedClients"", function () {
            getProducts();
        });

        connection.start().then(function () {
            console.log(""Connection Started"");
            getProducts();
        }).catch(function (err) {
            console.log(""Connection ERROR"");
        });
         function getProducts() {
            event.");
                WriteLiteral("preventDefault();\r\n            $.ajax({\r\n                url: \"");
#nullable restore
#line 134 "F:\iti_data\Graduation Project\ECommerce_Dashboard\ECommerce_Dashboard\Views\Products\Index.cshtml"
                 Write(Url.Action("Index", "Products"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                success: function (result) { $(\"#body\").html(result) },\r\n                error: function (err) { console.log(err) }\r\n                });\r\n         }\r\n\r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<WebApplication1.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591