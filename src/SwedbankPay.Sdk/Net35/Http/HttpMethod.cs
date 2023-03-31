#if NET35
using System;

namespace System.Net.Http
{
    /// <summary></summary>
    public class HttpMethod
    {
        /// <summary></summary>
        public static HttpMethod Get = new HttpMethod("GET");

        /// <summary></summary>
        public static HttpMethod Post = new HttpMethod("POST");

        private String _method;

        /// <summary></summary>
        public override String ToString()
        {
            return _method;
        }

        /// <summary></summary>
        public HttpMethod(String method)
        {
            _method = method?.ToUpper() ?? "GET";
        }
    }
}
#endif