#pragma checksum "C:\sesionV\ProyBaseMuestra\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94af37369766be21e8cf83f2b5ffb05cf7d8f7b5"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestra.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\sesionV\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\sesionV\ProyBaseMuestra\Client\Pages\Index.razor"
using ProyBaseMuestra.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProyBaseMuestra.Client.Pages.Components.CardMoviesComponent>(0);
            __builder.AddAttribute(1, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProyBaseMuestra.Shared.Entity.Movie>>(
#nullable restore
#line 4 "C:\sesionV\ProyBaseMuestra\Client\Pages\Index.razor"
                             Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\sesionV\ProyBaseMuestra\Client\Pages\Index.razor"
       
    private List<Movie> Movies;
    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
