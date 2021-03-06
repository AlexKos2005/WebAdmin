#pragma checksum "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d9867ab286902e36ea1553b37a79118558cb54c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAdmin.Pages.ServiceCheck
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using WebAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\_Imports.razor"
using WebAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor"
using CwAuthorizationService.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor"
using CwAuthorizationService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/servicecheck")]
    public partial class ServiceCheck : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CheckService</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "st1");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "text-align:center");
            __builder.AddMarkupContent(6, "\r\n        \r\n            ");
            __builder.OpenElement(7, "h3");
            __builder.AddContent(8, "Status: ");
            __builder.AddContent(9, 
#nullable restore
#line 14 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor"
                         _checkMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n      \r\n\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor"
                                           Check

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "value", "Check CwAuth Service");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Pages\ServiceCheck\ServiceCheck.razor"
           
        private string _checkMessage;

        private async Task Check()
        {
            try
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method = new HttpMethod("GET");
                httpRequestMessage.RequestUri = new Uri("http://localhost:6060/api/Check");


                var response = await Http.SendAsync(httpRequestMessage);
                var responseStatusCode = response.StatusCode;
                var responseBody = await response.Content.ReadAsStringAsync();

                if (responseStatusCode.ToString() == "OK")
                {
                    _checkMessage = "CwAuthorizationService is working successfuly";
                }
                else
                {
                    _checkMessage = "Check the CwAuthorizationService is bad.";
                }

            }
            catch (Exception e)

            {
                _checkMessage = e.Message;
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
