#pragma checksum "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d87f06e2a7ce557d3716933b1da542f6ca68425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices_Index), @"mvc.1.0.view", @"/Views/Devices/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d87f06e2a7ce557d3716933b1da542f6ca68425", @"/Views/Devices/Index.cshtml")]
    public class Views_Devices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.Device>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CoordX));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CoordY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CoordX));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CoordY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1146, "\"", 1169, 1);
#nullable restore
#line 46 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
WriteAttributeValue("", 1161, item.Id, 1161, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1222, "\"", 1245, 1);
#nullable restore
#line 47 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
WriteAttributeValue("", 1237, item.Id, 1237, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1300, "\"", 1323, 1);
#nullable restore
#line 48 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
WriteAttributeValue("", 1315, item.Id, 1315, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\laptop\Desktop\web2\PUSGS-Projekat\Back\WebApp\Views\Devices\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.Device>> Html { get; private set; }
    }
}
#pragma warning restore 1591