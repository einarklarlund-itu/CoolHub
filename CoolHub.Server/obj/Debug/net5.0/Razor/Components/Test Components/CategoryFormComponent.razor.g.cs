#pragma checksum "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50a24ae7814b314ad4678a58e7efcb49b82e9276"
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
#line 1 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
using CoolHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
using CoolHub.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    public partial class CategoryFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"Tutorials-header\">Create new category</h3>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
                  Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
                                            CreateCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-4");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label for=\"name\">Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "id", "name");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
                                                                   Category.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Name = __value, Category.Name))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label for=\"notes\">Description</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(25);
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "id", "notes");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
                                                                        Category.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Description = __value, Category.Description))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "type", "submit");
                __builder2.AddAttribute(34, "class", "btn btn-primary");
                __builder2.AddAttribute(35, "disabled", 
#nullable restore
#line 26 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
                                                                 AllCategoriesViewModel.IsBusy

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(36, "Save");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\CategoryFormComponent.razor"
       
    [CascadingParameter(Name = "AllCategoriesViewModel")]
    AllCategoriesViewModel AllCategoriesViewModel { get; set; }

    private CategoryCreateDTO Category = new CategoryCreateDTO();

    private void CreateCategory()
    {
        AllCategoriesViewModel.CreateCategory(new CategoryCreateDTO()
        {
            Name = Category.Name,
            Description = Category.Description
        });

        Category = new CategoryCreateDTO(); 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
