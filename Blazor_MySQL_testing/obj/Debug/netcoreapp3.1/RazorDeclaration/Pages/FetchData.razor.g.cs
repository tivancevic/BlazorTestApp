// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_MySQL_testing.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Blazor_MySQL_testing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Blazor_MySQL_testing.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\FetchData.razor"
using Blazor_MySQL_testing.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
