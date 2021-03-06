#pragma checksum "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa39e56ad8f33ba24050b25fab79152e7d77b955"
// <auto-generated/>
#pragma warning disable 1591
namespace CoolHub
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using CoolHub.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using CoolHub.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
using CoolHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    public partial class CategoryListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
 if (AllCategoriesViewModel?.IsBusy == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 16 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
         foreach (var categoryDetails in AllCategoriesViewModel.Categories.OrderBy(c => c.Name).ThenBy(c => c.Description))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<CoolHub.CategoryComponent>(3);
            __builder.AddAttribute(4, "category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CoolHub.Models.CategoryDetailsDTO>(
#nullable restore
#line 18 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
                                         categoryDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryListComponent.razor"
       
    [CascadingParameter(Name = "AllCategoriesViewModel")]
    AllCategoriesViewModel AllCategoriesViewModel { get; set; }

    List<CategoryDetailsDTO> details = new List<CategoryDetailsDTO>();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
