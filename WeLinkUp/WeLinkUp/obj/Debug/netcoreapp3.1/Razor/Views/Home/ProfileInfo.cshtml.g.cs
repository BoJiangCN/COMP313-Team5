#pragma checksum "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9879e50a13cfbaa39ab2e2cfc1d185532cc65694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProfileInfo), @"mvc.1.0.view", @"/Views/Home/ProfileInfo.cshtml")]
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
#line 1 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\_ViewImports.cshtml"
using WeLinkUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\_ViewImports.cshtml"
using WeLinkUp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9879e50a13cfbaa39ab2e2cfc1d185532cc65694", @"/Views/Home/ProfileInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f643486ab6396a0e844b25da3645afec75c47987", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProfileInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeLinkUp.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
   ViewData["Title"] = "ProfileInfo"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<h1 class=\"w3-content\">Profile Information</h1>\r\n<div class=\"center\">\r\n    <div class=\"w3-content\">\r\n        <label>Profile picture</label>\r\n        <br />\r\n        <img class=\"profile\"");
            BeginWriteAttribute("src", " src=\"", 292, "\"", 384, 1);
#nullable restore
#line 12 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
WriteAttributeValue("", 298, Url.Content("http://softwareprojectnew2.s3.amazonaws.com/UserProfile/" + Model.Image), 298, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 385, "\"", 391, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"w3-content w3-margin w3-white\">\r\n            <label> Username: </label>\r\n\r\n            ");
#nullable restore
#line 16 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(ViewBag.user);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Email: </label>\r\n\r\n            ");
#nullable restore
#line 20 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>DateofBirth: </label>\r\n\r\n            ");
#nullable restore
#line 24 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.DateofBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label> Freetime:</label>\r\n            <br />\r\n\r\n\r\n            ");
#nullable restore
#line 30 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Sunday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 32 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Sunday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n\r\n            ");
#nullable restore
#line 36 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Monday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 38 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Monday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n\r\n            ");
#nullable restore
#line 42 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Tuesday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 44 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Tuesday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n\r\n            ");
#nullable restore
#line 48 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Wednesday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 50 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Wednesday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n\r\n            ");
#nullable restore
#line 54 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Thursday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 56 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Thursday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n\r\n            ");
#nullable restore
#line 60 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Friday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 62 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Friday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n\r\n            ");
#nullable restore
#line 66 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Saturday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 68 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Saturday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"w3-content\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9879e50a13cfbaa39ab2e2cfc1d185532cc6569410595", async() => {
                WriteLiteral("Edit");
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
#line 75 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Home\ProfileInfo.cshtml"
                                  WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeLinkUp.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
