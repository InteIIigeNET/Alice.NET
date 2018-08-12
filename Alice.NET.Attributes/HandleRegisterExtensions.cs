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
                var url = handlerPair.Key;
                var handler = handlerPair.Value;
                var handlerListeners = listeners.ContainsKey(url) ? listeners[url] : null;
                handleRegister.EnrolHandler(url, handler, handlerListeners?.ToArray());
            }
        }

        private static void GetHandlersAndListeners(Dictionary<string, IAliceHandler> handlers, Dictionary<string, List<IAliceListener>> listeners)
        {
            var assemblies = Assembly.GetCallingAssembly().GetApplicationAssemblies();
            var types = assemblies.SelectMany(item => item.GetExportedTypes());
            foreach (var type in types)
            {
                if (type.TryGetAttribute(out RequestHandlerAttribute requestHandlerAttribute)
                    && type.IsInheritInterface(nameof(IAliceHandler)))
                {
                    handlers.Add(requestHandlerAttribute.Url, type.CreateObject<IAliceHandler>());
                    continue;
                }
                if (type.TryGetAttribute(out RequestListenerAttribute requestListenerAttribute)
                    && type.IsInheritInterface(nameof(IAliceListener)))
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
                    continue;
                }
            }
        }
    }
}
