#pragma checksum "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d382ef29141ace1a749ca19665e40055f8ee13"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAdmin.Pages.Accounts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using WebAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\_Imports.razor"
using WebAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
using CwAuthorizationService.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
using CwAuthorizationService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newaccount")]
    public partial class NewAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adding New Account</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "st1");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n            <th>Role</th>\r\n            <th>Description</th>\r\n        </tr>\r\n        ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "placeholder", "Name");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
                                           createAccount.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createAccount.Name = __value, createAccount.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "placeholder", "Password");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
                                           createAccount.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createAccount.Password = __value, createAccount.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "placeholder", "Role");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
                                           createAccount.Role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createAccount.Role = __value, createAccount.Role));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "placeholder", "Description");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
                                           createAccount.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createAccount.Description = __value, createAccount.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
                                          PutNewAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Put new account ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "style", "text-align:center");
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "p");
            __builder.AddContent(50, 
#nullable restore
#line 29 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
        _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\Дела\От Александра Овчинникова\Админка\WebAdmin\WebAdmin\Pages\Accounts\NewAccount.razor"
       

    private string _message;

    public CreateAccountDto createAccount { get; set; } = new CreateAccountDto();

    protected override async Task OnInitializedAsync()
    {
    }


    private async Task PutNewAccount()
    {

        try
        {

            string account = JsonConvert.SerializeObject(createAccount);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = new HttpMethod("PUT");
            httpRequestMessage.RequestUri = new Uri("http://localhost:6060/api/Account");
            httpRequestMessage.Headers.Add("Authorization", "Bearer " + UserToken.Jwt);
            httpRequestMessage.Content = new StringContent(account);
            httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            var response = await Http.SendAsync(httpRequestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            if (responseStatusCode == System.Net.HttpStatusCode.OK)
            {
                _message = "Account is added successfuly!";
            }
            else
            {
                _message = responseStatusCode.ToString();
            }
        }
        catch (Exception e)
        {
            _message = e.Message;
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CwAuthorizationService.Dto.TokenDto UserToken { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
