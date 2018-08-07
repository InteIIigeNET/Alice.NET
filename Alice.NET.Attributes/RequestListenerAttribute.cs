using System;

namespace Alice.NET.Attributes
{
    public class RequestListenerAttribute : Attribute
    {
        public RequestListenerAttribute(string url)
        {
            Url = url;
        }

        public string Url { get; }
    }
}
