#pragma checksum "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78ea5c747b93e2a019775bc9df46d43d150c42c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_GetAll), @"mvc.1.0.view", @"/Views/Flight/GetAll.cshtml")]
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
#line 1 "C:\Users\bobid\source\repos\FlightManager\FlightManager\_ViewImports.cshtml"
using FlightManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
using FlightManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ea5c747b93e2a019775bc9df46d43d150c42c1", @"/Views/Flight/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f786fd48d4832d47c30e803e7f87b4fe4964de31", @"/_ViewImports.cshtml")]
    public class Views_Flight_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightManager.ViewModels.Flight.ListingPageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""py-5"">
    <div class=""container"">
        <h1 style=""margin: 2%; text-align: center;"">All Flights</h1>
        <div style=""padding: 5%;"">
            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">From</th>
                        <th scope=""col"">To</th>
                        <th scope=""col"">Departure Time</th>
                        <th scope=""col"">Travel Time</th>
                        <th scope=""col"">Passengers Seats</th>
                        <th scope=""col"">Business Seats</th>
                        <th scope=""col"">Details</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 20 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                     for (var i = 0; i < Model.Flights.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                                       Write(Model.Flights[i].From);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                           Write(Model.Flights[i].To);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                           Write(Model.Flights[i].DepartureTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                           Write(Model.Flights[i].TravelTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                           Write(Model.Flights[i].FreePassengersSeats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                           Write(Model.Flights[i].FreeBusinessSeats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <div class=\"button-holder\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1502, "\"", 1548, 2);
            WriteAttributeValue("", 1509, "/Flight/Details?id=", 1509, 19, true);
#nullable restore
#line 31 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
WriteAttributeValue("", 1528, Model.Flights[i].Id, 1528, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-uppercase\">Info</a>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n            <div class=\"d-flex flex-wrap align-items-center\">\r\n                <div class=\"pagination mx-auto\">\r\n");
#nullable restore
#line 42 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                      
                        var prevPage = Model.CurrentPage - 1;
                        var nextPage = Model.CurrentPage + 1;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                     if (Model.CurrentPage != 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2162, "\"", 2198, 2);
            WriteAttributeValue("", 2169, "/Flight/GetAll?page=", 2169, 20, true);
#nullable restore
#line 48 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
WriteAttributeValue("", 2189, prevPage, 2189, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary prev-arrow mx-1\"><i class=\"fas fa-arrow-left\"></i></a>\r\n");
#nullable restore
#line 49 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                     for (var j = 1; j <= (Model.TotalFlightsCount / GlobalConstants.FlightsPerPage) + 1; j++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                         if (j == Model.CurrentPage)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-primary active mx-1\"");
            BeginWriteAttribute("href", " href=\"", 2586, "\"", 2615, 2);
            WriteAttributeValue("", 2593, "/Flight/GetAll?page=", 2593, 20, true);
#nullable restore
#line 55 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
WriteAttributeValue("", 2613, j, 2613, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                                                                                            Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 56 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                        }
                        else if (j >= Model.CurrentPage - 4 && (j <= Model.CurrentPage + 4 && j <= Model.LastPage))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2826, "\"", 2855, 2);
            WriteAttributeValue("", 2833, "/Flight/GetAll?page=", 2833, 20, true);
#nullable restore
#line 59 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
WriteAttributeValue("", 2853, j, 2853, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mx-1\">");
#nullable restore
#line 59 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                                                                         Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 60 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                     if (Model.CurrentPage != Model.LastPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 3046, "\"", 3082, 2);
            WriteAttributeValue("", 3053, "/Flight/GetAll?page=", 3053, 20, true);
#nullable restore
#line 65 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
WriteAttributeValue("", 3073, nextPage, 3073, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary next-arrow mx-1\"><i class=\"fas fa-arrow-right\"></i></a>\r\n");
#nullable restore
#line 66 "C:\Users\bobid\source\repos\FlightManager\FlightManager\Views\Flight\GetAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightManager.ViewModels.Flight.ListingPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
