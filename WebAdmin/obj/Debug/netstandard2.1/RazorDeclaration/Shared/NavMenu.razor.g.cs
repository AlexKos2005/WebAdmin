#pragma checksum "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6856b92a27bfbf216e45cd1526b8a387837dc78e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebAdmin.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\.Net\Git\Blazor\WebAdmin\WebAdmin\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private void ClearUserToken()
    {
        UserToken.Jwt = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CwAuthorizationService.Dto.TokenDto UserToken { get; set; }
    }
}
#pragma warning restore 1591
