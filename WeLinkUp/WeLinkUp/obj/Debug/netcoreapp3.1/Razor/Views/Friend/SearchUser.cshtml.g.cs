#pragma checksum "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16d2922810e6123893a035d4d55663e4eba3d4ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_SearchUser), @"mvc.1.0.view", @"/Views/Friend/SearchUser.cshtml")]
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
#line 1 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\_ViewImports.cshtml"
using WeLinkUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\_ViewImports.cshtml"
using WeLinkUp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16d2922810e6123893a035d4d55663e4eba3d4ff", @"/Views/Friend/SearchUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f643486ab6396a0e844b25da3645afec75c47987", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_SearchUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WeLinkUp.Models.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Friends", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
  
    ViewData["Title"] = "SearchUser";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d2922810e6123893a035d4d55663e4eba3d4ff4245", async() => {
                WriteLiteral(@"
    <style>
        body, h1, h2, h3, h4, h5 {
            font-family: ""Lato"", sans-serif
        }

        .image {
            height: 200px;
            width: 100%;
            object-fit: contain;
        }

        .w3-row {
            margin-left: 20%;
            width: 60%;
        }

        .w3-col l8 s12 {
            width: 20%;
        }

        img.profile {
            border-radius: 50%;
            height: 50px;
            width: 50px;
        }

        table {
            border-collapse: collapse;
            width: 100%;
        }

            table td {
                text-align: center;
                vertical-align: middle;
            }

            table tr:nth-child(2n) {
                background-color: white;
            }

            table tr:nth-child(2n+1) {
                background-color: #F7F3EF;
            }
        
        .text-danger {
            color: red;
        }    
</style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d2922810e6123893a035d4d55663e4eba3d4ff6207", async() => {
                WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n\r\n    <header class=\"w3-container w3-center w3-padding-32\">\r\n        <h1>SearchUser</h1>\r\n    </header>\r\n    <div class=\"w3-row\">\r\n        <div class=\"w3-container\">\r\n");
#nullable restore
#line 66 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
             if (ViewBag.result != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"text-danger\">");
#nullable restore
#line 68 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
                                     Write(ViewBag.result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 69 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <table>
                    <tr>
                        <th>
                            Profile picture
                        </th>
                        <th>
                            Username
                        </th>
                        <th>
                            Action
                        </th>
                    </tr>


");
#nullable restore
#line 86 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <img class=\"profile\"");
                BeginWriteAttribute("src", " src=\"", 2061, "\"", 2152, 1);
#nullable restore
#line 90 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
WriteAttributeValue("", 2067, Url.Content("http://softwareprojectnew2.s3.amazonaws.com/UserProfile/" + item.Image), 2067, 85, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2153, "\"", 2159, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 92 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                            <td> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d2922810e6123893a035d4d55663e4eba3d4ff9474", async() => {
                    WriteLiteral("Add");
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
#line 94 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
                                                            WriteLiteral(item.Id);

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
                WriteLiteral(" </td>\r\n                        </tr>\r\n");
#nullable restore
#line 96 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </table>");
#nullable restore
#line 98 "C:\SEMESTER6\Software Project2\FinalProject\Version5.11\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Friend\SearchUser.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WeLinkUp.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591