#pragma checksum "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68b041324cb30ba4f1519a47a9c5ef442d48d732"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_EventDetail), @"mvc.1.0.view", @"/Views/Event/EventDetail.cshtml")]
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
#line 2 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b041324cb30ba4f1519a47a9c5ef442d48d732", @"/Views/Event/EventDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f643486ab6396a0e844b25da3645afec75c47987", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_EventDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeLinkUp.Models.EventDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-button w3-padding-large w3-white w3-border"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-light-grey"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
   ViewData["Title"] = "Event Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b041324cb30ba4f1519a47a9c5ef442d48d7325064", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">


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
            /*border: 1px solid #090808;*/
            width: 100%;
        }
        table td {
            text-align: center;
            vertical-align: middle;
        }
            table tr");
                WriteLiteral(":nth-child(2n) {\r\n                background-color: white;\r\n            }\r\n\r\n        table tr:nth-child(2n+1) {\r\n        background-color: #E1D1C2;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b041324cb30ba4f1519a47a9c5ef442d48d7327292", async() => {
                WriteLiteral("\r\n    <!-- Header -->\r\n    <br/>\r\n    <br/>\r\n    <header class=\"w3-container w3-center w3-padding-32\">\r\n        <h1><b>Event Detail</b></h1>\r\n        <p>Welcome to the event of <span class=\"w3-tag\">");
#nullable restore
#line 63 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                                   Write(Model.Host);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
    </header>
    <!-- Grid -->
    <div class=""w3-row"">

        <!-- Blog entries -->
        <div class=""w3-col l8 s12"">
            <!-- Blog entry -->
            <div class=""w3-card-4 w3-margin w3-white"">
                <div class=""image"">
                    <img");
                BeginWriteAttribute("src", " src=\"", 1933, "\"", 2026, 1);
#nullable restore
#line 73 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
WriteAttributeValue("", 1939, Url.Content("http://softwareprojectnew2.s3.amazonaws.com/EventPicture/" + Model.Image), 1939, 87, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2027, "\"", 2033, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\'height: 100%; width: 100%; object-fit: contain\'>\r\n\r\n                </div>\r\n                <div class=\"w3-container\">\r\n                    <h3><b>");
#nullable restore
#line 77 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                      Write(Model.EventTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></h3>\r\n                    <h5>");
#nullable restore
#line 78 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                </div>\r\n                <hr />\r\n\r\n                <div class=\"w3-container\">\r\n                    <h3><b>Invitation List</b></h3>\r\n\r\n                    <b># of invitation </b><span class=\"w3-tag\">");
#nullable restore
#line 85 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                                           Write(Model.NumberOfInvitation);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                    
                    <br />
                    <table>
                        <tr>
                            <th> </th>
                            <th> User </th>
                            <th> Status </th>
                        </tr>

");
#nullable restore
#line 95 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                         foreach (AttendeeList user in Model.AttendeeList)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img class=\"profile\"");
                BeginWriteAttribute("src", " src=\"", 3018, "\"", 3110, 1);
#nullable restore
#line 99 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
WriteAttributeValue("", 3024, Url.Content("http://softwareprojectnew2.s3.amazonaws.com/EventPicture/" + user.Image), 3024, 86, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3111, "\"", 3117, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </td>\r\n\r\n                               <td>");
#nullable restore
#line 102 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                              Write(user.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 103 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                               Write(user.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 107 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n              \r\n\r\n\r\n                </div>\r\n                <div class=\"w3-container\">\r\n                    <div class=\"w3-row\">\r\n                        <div class=\"w3-col m8 s12\">\r\n");
#nullable restore
#line 116 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                             if (DateTime.Compare(DateTime.Now.Date, Convert.ToDateTime(Model.Date)) > 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <br />\r\n                                <br />\r\n                                <h3>Event is already passed</h3>\r\n");
#nullable restore
#line 121 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                            }
                            else if (DateTime.Compare(DateTime.Now, Convert.ToDateTime(Model.Date)) == 0 && DateTime.Compare(DateTime.Now, Convert.ToDateTime(Model.EndTime)) > 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <br />\r\n                                <br />\r\n                                <h3>Event is already passed</h3>\r\n");
#nullable restore
#line 127 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                            }

                            else
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                 if (ViewData["Attendance"].ToString() == "1")
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                     if (ViewData["BlockTeenager"] != null && ViewData["BlockTeenager"].ToString() == "1")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <button disabled>This event is adult only</button>\r\n");
#nullable restore
#line 137 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                    }
                                    else
                                    {
                                        if (ViewData["Freeday"].ToString() == "0")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <br />\r\n                                            <button name=\"joinEvent\" id=\"btnJoinEvent\" class=\"w3-button w3-padding-large w3-white w3-border\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5135, "\"", 5248, 8);
                WriteAttributeValue("", 5145, "timeAlert();", 5145, 12, true);
                WriteAttributeValue(" ", 5157, "location.href", 5158, 14, true);
                WriteAttributeValue(" ", 5171, "=", 5172, 2, true);
                WriteAttributeValue(" ", 5173, "\'", 5174, 2, true);
#nullable restore
#line 143 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
WriteAttributeValue("", 5175, Url.Action("JoinEvent", new { eventId = Model.EventId }), 5175, 57, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5232, "\';", 5232, 2, true);
                WriteAttributeValue(" ", 5234, "return", 5235, 7, true);
                WriteAttributeValue(" ", 5241, "false;", 5242, 7, true);
                EndWriteAttribute();
                WriteLiteral("><b>Join Event</b></button>\r\n");
#nullable restore
#line 144 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <br />\r\n                                            <button name=\"joinEvent\" id=\"btnJoinEvent\" class=\"w3-button w3-padding-large w3-white w3-border\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5602, "\"", 5702, 7);
                WriteAttributeValue("", 5612, "location.href", 5612, 13, true);
                WriteAttributeValue(" ", 5625, "=", 5626, 2, true);
                WriteAttributeValue(" ", 5627, "\'", 5628, 2, true);
#nullable restore
#line 148 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
WriteAttributeValue("", 5629, Url.Action("JoinEvent", new { eventId = Model.EventId }), 5629, 57, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5686, "\';", 5686, 2, true);
                WriteAttributeValue(" ", 5688, "return", 5689, 7, true);
                WriteAttributeValue(" ", 5695, "false;", 5696, 7, true);
                EndWriteAttribute();
                WriteLiteral("><b>Join Event</b></button>\r\n");
#nullable restore
#line 149 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                     
                                }

                                else if (ViewData["Attendance"].ToString() == "2")
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p><b>You are coming to this event</b></p>\r\n");
#nullable restore
#line 156 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                }

                                else if (Model.HostId.Equals(signInManager.UserManager.GetUserId(User)))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <br />\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b041324cb30ba4f1519a47a9c5ef442d48d73219754", async() => {
                    WriteLiteral("Edit Event");
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
#line 161 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                                                WriteLiteral(Model.EventId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <button name=\"cancelEvent\" id=\"btnCancelEvent\" class=\"w3-button w3-padding-large w3-white w3-border\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6570, "\"", 6672, 7);
                WriteAttributeValue("", 6580, "location.href", 6580, 13, true);
                WriteAttributeValue(" ", 6593, "=", 6594, 2, true);
                WriteAttributeValue(" ", 6595, "\'", 6596, 2, true);
#nullable restore
#line 162 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
WriteAttributeValue("", 6597, Url.Action("CancelEvent", new { eventId = Model.EventId }), 6597, 59, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6656, "\';", 6656, 2, true);
                WriteAttributeValue(" ", 6658, "return", 6659, 7, true);
                WriteAttributeValue(" ", 6665, "false;", 6666, 7, true);
                EndWriteAttribute();
                WriteLiteral(">Cancel Event</button>\r\n");
#nullable restore
#line 163 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                 


                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <br />
                        </div>
                    </div>
                </div>
            </div>
            

        <hr>


        </div>

        <!-- Info -->
        <div class=""w3-col l4"">
            <!-- Location -->
            <div class=""w3-card w3-margin w3-margin-top"">
                <div class=""w3-container w3-white"">
                    <h4><b>Location</b></h4>
                    <p>");
#nullable restore
#line 185 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                  Write(Model.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
            </div><hr>
            <!-- DateTime -->
            <div class=""w3-card w3-margin w3-margin-top"">
                <div class=""w3-container w3-white"">
                    <h4><b>Date</b></h4>
                    <p>");
#nullable restore
#line 192 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                  Write(Model.DayOfWeek);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 192 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                    Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 193 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                  Write(Model.StartTimeToShow);

#line default
#line hidden
#nullable disable
                WriteLiteral(" To ");
#nullable restore
#line 193 "C:\SEMESTER6\Software Project2\FinalProject\Version5.12\COMP313-Team5\WeLinkUp\WeLinkUp\Views\Event\EventDetail.cshtml"
                                            Write(Model.EndTimeToShow);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div><hr>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n<script>\r\n    function timeAlert() {\r\n        alert(\"Warning! Time is confliect with your free time\");\r\n    }\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeLinkUp.Models.EventDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
