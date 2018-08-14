using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Alice.NET.Attributes
{
    public static class HandleRegisterExtensions
    {
        public static void EnrolAttributedHandler(this HandleRegister handleRegister)
        {
            var handlers = new Dictionary<string, IAliceHandler>();
            var listeners = new Dictionary<string, List<IAliceListener>>();
            GetHandlersAndListeners(handlers, listeners);
            if (handlers.Count != listeners.Count)
                //TODO : castom error
                throw new ArgumentException();
            foreach (var handlerPair in handlers)
            {
                EnrolHandlerAndListeners(handleRegister, listeners, handlerPair);
            }
        }

        private static void EnrolHandlerAndListeners(HandleRegister handleRegister, Dictionary<string, List<IAliceListener>> listeners, KeyValuePair<string, IAliceHandler> handlerPair)
        {
            var url = handlerPair.Key;
            var handler = handlerPair.Value;
            if (listeners.ContainsKey(url))
            {
                handleRegister.EnrolHandler(url, handler, listeners[url].ToArray());
            }
            else
            {
                handleRegister.EnrolHandler(url, handler);
            }
        }

        private static void GetHandlersAndListeners(Dictionary<string, IAliceHandler> handlers, Dictionary<string, List<IAliceListener>> listeners)
        {
            foreach (var type in GetTypes())
            {
                if (TryGetAttributOnInheritInterfaceType<RequestHandlerAttribute, IAliceHandler>(type, out var requestHandlerAttribute))
                {
                    handlers.Add(requestHandlerAttribute.Url, type.CreateObject<IAliceHandler>());
                }
                else if (TryGetAttributOnInheritInterfaceType<RequestListenerAttribute, IAliceListener>(type, out var requestListenerAttribute))
                {
                    FillListeners(listeners, type, requestListenerAttribute);
                }
            }
        }

        private static void FillListeners(Dictionary<string, List<IAliceListener>> listeners, Type type, RequestListenerAttribute requestListenerAttribute)
        {
            var url = requestListenerAttribute.Url;
            var obj = type.CreateObject<IAliceListener>();
            if (listeners.ContainsKey(url))
            {
                listeners[url].Add(obj);
            }
            else
            {
                listeners.Add(url, new List<IAliceListener> { obj });
            }
        }

        private static bool TryGetAttributOnInheritInterfaceType<TAttribute, TInterface>(Type type, out TAttribute requestHandlerAttribute)
            where TAttribute : Attribute
        {
            return type.TryGetAttribute(out requestHandlerAttribute)
                                && type.IsInheritInterface(nameof(TInterface));
        }

        private static IEnumerable<Type> GetTypes()
        {
            var assemblies = Assembly.GetCallingAssembly().GetApplicationAssemblies();
            var types = assemblies.SelectMany(item => item.GetExportedTypes());
            return types;
        }
    }
}
