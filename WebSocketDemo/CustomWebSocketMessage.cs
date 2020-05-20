using System;

namespace WebSocketDemo
{
    internal class CustomWebSocketMessage
    {
        public string Text { get; set; }
        public DateTime MessagDateTime { get; set; }
        public string Username { get; set; }
        public WSMessageType Type { get; set; }
    }

    public enum WSMessageType
    {
        anyType = 1
    }
}