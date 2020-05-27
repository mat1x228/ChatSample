﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChatSample.Shared
{
    public class ChatClient : IAsyncDisposable
    {
        public const string HUBURL = "/ChatHub";

        private readonly string _hubUrl;
        private HubConnection _hubConnection;

        public ChatClient(string username, string siteUrl)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentNullException(nameof(username));
            if (string.IsNullOrWhiteSpace(siteUrl))
                throw new ArgumentNullException(nameof(siteUrl));
            _username = username;
            _hubUrl = siteUrl.TrimEnd('/') + HUBURL;
        }

        private readonly string _username;
        private bool _started = false;

        public async Task StartAsync()
        {
            if (!_started)
            {
                _hubConnection = new HubConnectionBuilder()
                    .WithUrl(_hubUrl)
                    .Build();
                Console.WriteLine("ChatClient: calling Start()");

                _hubConnection.On<string, string>(Messages.RECEIVE, (user, message) =>
                 {
                     HandleReceiveMessage(user, message);
                 });

                await _hubConnection.StartAsync();

                Console.WriteLine("ChatClient: Start returned");
                _started = true;

                await _hubConnection.SendAsync(Messages.REGISTER, _username);
            }
        }

        private void HandleReceiveMessage(string username, string message)
        {
            MessageReceived?.Invoke(this, new MessageReceivedEventArgs(username, message));
        }

        public event MessageReceivedEventHandler MessageReceived;

        public async Task SendAsync(string message)
        {
            if (!_started)
                throw new InvalidOperationException("Client not started");
            await _hubConnection.SendAsync(Messages.SEND, _username, message);
        }

        public async Task StopAsync()
        {
            if (_started)
            {
                await _hubConnection.StopAsync();
                await _hubConnection.DisposeAsync();
                _hubConnection = null;
                _started = false;
            }
        }

        public async ValueTask DisposeAsync()
        {
            Console.WriteLine("ChatClient: Disposing");
            await StopAsync();
        }
    }

    public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs e);

    public class MessageReceivedEventArgs : EventArgs
    {
        public MessageReceivedEventArgs(string username, string message)
        {
            Username = username;
            Message = message;
        }

        public string Username { get; set; }

        public string Message { get; set; }

    }

}

