#pragma checksum "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82d5580f085769538f5473cbf92ce9601b61e2a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorChatSample.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using BlazorChatSample.Client;

#line default
#line hidden
#line 7 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using BlazorChatSample.Client.Shared;

#line default
#line hidden
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 5 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\App.razor"
                     typeof(Program).Assembly

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#line 7 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\App.razor"
                              routeData

#line default
#line hidden
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 7 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\App.razor"
                                                        typeof(MainLayout)

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.AddMarkupContent(10, "<h1>Page not found</h1>\n        ");
                __builder2.AddMarkupContent(11, "<p>Sorry, but there\'s nothing here!</p>\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591