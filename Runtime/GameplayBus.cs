using System;
using System.Collections.Generic;
using UnityEngine;

namespace Plyground.Gameplay.Runtime
{
    public static class GameplayBus
    {
        private static event Action<GameplayMessage> MessagePublished;
        private static readonly List<Subscription> Subscriptions = new List<Subscription>();

        public static IDisposable Subscribe<TMessage>(Action<TMessage> handler) where TMessage : GameplayMessage
        {
            if (handler == null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            var subscription = new Subscription(typeof(TMessage), handler, message => handler((TMessage)message));
            Subscriptions.Add(subscription);
            MessagePublished += subscription.Handle;
            return subscription;
        }

        public static void Publish(GameplayMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            var listeners = MessagePublished;
            if (listeners == null)
            {
                return;
            }

            foreach (Action<GameplayMessage> listener in listeners.GetInvocationList())
            {
                try
                {
                    listener(message);
                }
                catch (Exception exception)
                {
                    Debug.LogException(exception);
                }
            }
        }

        public static void Unsubscribe<TMessage>(Action<TMessage> handler) where TMessage : GameplayMessage
        {
            if (handler == null)
            {
                return;
            }

            for (var index = Subscriptions.Count - 1; index >= 0; index--)
            {
                var subscription = Subscriptions[index];
                if (subscription.MessageType == typeof(TMessage) && subscription.Handler == handler)
                {
                    subscription.Dispose();
                }
            }
        }

        private sealed class Subscription : IDisposable
        {
            public Type MessageType { get; }
            public Delegate Handler { get; }
            private readonly Action<GameplayMessage> invoke;
            private bool disposed;

            public Subscription(Type messageType, Delegate handler, Action<GameplayMessage> invoke)
            {
                MessageType = messageType;
                Handler = handler;
                this.invoke = invoke;
            }

            public void Handle(GameplayMessage message)
            {
                if (message != null && MessageType.IsInstanceOfType(message))
                {
                    invoke(message);
                }
            }

            public void Dispose()
            {
                if (disposed)
                {
                    return;
                }

                disposed = true;
                MessagePublished -= Handle;
                Subscriptions.Remove(this);
            }
        }
    }
}
