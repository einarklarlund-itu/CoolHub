#pragma checksum "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5474bd25783b25aad152a3f3b4e8963d9ca4ad35"
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
#line 1 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using CoolHub.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using CoolHub.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
using CoolHub.Models;

#line default
#line hidden
#nullable disable
    public partial class ToDoListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
 if (ViewModel?.ToDoItemList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 13 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
         foreach (var todoitem in ViewModel.ToDoItemList.OrderBy(i => i.Date).ThenBy(i=>i.Done))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card" + " mb-3" + " " + (
#nullable restore
#line 15 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
                                    todoitem.Done ? "bg-light" : "text-white bg-dark" 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "style", "min-width: 18rem; max-width: 18rem;");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.AddContent(8, 
#nullable restore
#line 16 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
                                           todoitem.Date?.ToShortDateString() ?? string.Empty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "card-title");
            __builder.AddContent(14, 
#nullable restore
#line 18 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
                                            todoitem.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "card-text");
            __builder.AddContent(18, 
#nullable restore
#line 19 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
                                          todoitem.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "disabled", 
#nullable restore
#line 20 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
                                       ViewModel.IsBusy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "btn" + " " + (
#nullable restore
#line 20 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
                                                                      todoitem.Done ? "btn-secondary" : "btn-primary"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
                                                                                                                                    () => SetToDoItem(todoitem)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoListComponent.razor"
       
    [CascadingParameter(Name = "ViewModel")]
    IToDoViewModel ViewModel { get; set; }

    void SetToDoItem(ToDoItem todoitem)
    {
        ViewModel.ToDoItem = todoitem;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
