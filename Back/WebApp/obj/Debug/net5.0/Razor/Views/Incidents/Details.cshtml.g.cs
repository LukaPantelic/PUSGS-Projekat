#pragma checksum "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62f4fa22887384a60ddf08930357b6f9f21696c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incidents_Details), @"mvc.1.0.view", @"/Views/Incidents/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62f4fa22887384a60ddf08930357b6f9f21696c", @"/Views/Incidents/Details.cshtml")]
    public class Views_Incidents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.Incident>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Incident</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Confirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Confirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ETA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ETA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ATA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ATA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ETR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ETR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AffectedCustomers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.AffectedCustomers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Voltage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Voltage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ScheduledTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ScheduledTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cause));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cause));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subcause));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subcause));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConstructionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ConstructionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Material));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2951, "\"", 2975, 1);
#nullable restore
#line 94 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Incidents\Details.cshtml"
WriteAttributeValue("", 2966, Model.Id, 2966, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.Incident> Html { get; private set; }
    }
}
#pragma warning restore 1591