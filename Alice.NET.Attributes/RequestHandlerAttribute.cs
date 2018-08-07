using System;

namespace Alice.NET.Attributes
{
    public class RequestHandlerAttribute : Attribute
    {
        public RequestHandlerAttribute(string url)
        {
            Url = url;
        }

        public string Url { get; }
    }
}
