﻿using EventBus.Core.Infrastructure;
using EventBus.Core.Internal;

namespace EventBus.Core
{
    public class EventDescriptor
    {
        public EventDescriptor(string routeKey, IMessage message, string exchange = null, object args = null)
        {
            RouteKey = routeKey;
            Message = message;
            ContentType = message.Content.GetType().FullName;
            Exchange = exchange ?? "default.exchange@feiniubus";
            Arguments = args == null ? null : new AnonymousObject(args);
        }

        public string Exchange { get; internal set; }

        public string RouteKey { get; internal set; }

        public IMessage Message { get; internal set; }

        public string ContentType { get; internal set; }

        public AnonymousObject Arguments { get; set; }
    }
}
