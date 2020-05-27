#pragma checksum "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80852184a4dced0270ceadc40bd3afcecdd5983e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorChatSample.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/_Imports.razor"
using BlazorChatSample.Client;

#line default
#line hidden
#line 7 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/_Imports.razor"
using BlazorChatSample.Client.Shared;

#line default
#line hidden
#line 1 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/Pages/Index.razor"
using BlazorChatSample.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 52 "/Users/honning69/Desktop/BlazorChatSample/BlazorChatSample.Client/Pages/Index.razor"
        
    bool chatting = false;
    string username = null;
    ChatClient client = null;
    string message = null;
    string newMessage = null;
    List<Message> messages = new List<Message>();

    async Task Chat()
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            message = "Please enter a name";
            return;
        };

        try
        {
            messages.Clear();

            string baseUrl = navigationManager.BaseUri;
            client = new ChatClient(username, baseUrl);

            client.MessageReceived += MessageReceived;

            Console.WriteLine("Index: chart starting...");
            await client.StartAsync();
            Console.WriteLine("Index: chart started?");

            chatting = true;
        }
        catch (Exception e)
        {
            message = $"ERROR: Failed to start chat client: {e.Message}";
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
    }

    void MessageReceived(object sender, MessageReceivedEventArgs e)
    {
        Console.WriteLine($"Blazor: receive {e.Username}: {e.Message}");
        bool isMine = false;
        if (!string.IsNullOrWhiteSpace(e.Username))
        {
            isMine = string.Equals(e.Username, username, StringComparison.CurrentCultureIgnoreCase);
        }

        var newMsg = new Message(e.Username, e.Message, isMine);
        messages.Add(newMsg);

        StateHasChanged();
    }

    async Task DisconnectAsync()
    {
        if (chatting)
        {
            await client.StopAsync();
            client = null;
            message = "chat ended";
            chatting = false;
        }
    }

    async Task SendAsync()
    {
        if (chatting && !string.IsNullOrWhiteSpace(newMessage))
        {
            await client.SendAsync(newMessage);
            newMessage = "";
        }
    }

    class Message
    {
        public Message(string username, string body, bool mine)
        {
            Username = username;
            Body = body;
            Mine = mine;
        }

        public string Username { get; set; }
        public string Body { get; set; }
        public bool Mine { get; set; }

        public string CSS
        {
            get
            {
                return Mine ? "sent" : "received";
            }
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591