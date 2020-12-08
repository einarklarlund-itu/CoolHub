#pragma checksum "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99deb30961cfa1ee1f70be864950b6c57cc1a917"
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
#line 1 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
using CoolHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    public partial class TopicListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
 if (CategoryViewModel?.IsBusy == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 16 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
         foreach (var TopicDTO in CategoryViewModel.TopicDTOs.OrderBy(c => c.Name).ThenBy(c => c.Description))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card mb-3 bg-light");
            __builder.AddAttribute(5, "style", "min-width: 18rem; max-width: 18rem;");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.OpenElement(8, "h5");
            __builder.AddAttribute(9, "class", "card-title");
            __builder.AddContent(10, 
#nullable restore
#line 21 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
                                            TopicDTO.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "card-text");
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
                                          TopicDTO.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn" + " " + (
#nullable restore
#line 23 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
                                         "btn-primary"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
                                                                     () => NavigationManager.NavigateTo("topic/" + TopicDTO.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Open");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicListComponent.razor"
       
    [CascadingParameter(Name = "CategoryViewModel")]
    CategoryViewModel CategoryViewModel { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
