#if NET35
using System;
using System.Linq;
using System.Net;

namespace System.Net.Http
{
    public class HttpRequestHeaders : WebHeaderCollection
    {
        public AuthenticationHeaderValue Authorization { get; set; } = new AuthenticationHeaderValue("Bearer", "");

        internal bool Contains(string key)
        {
            return this.AllKeys.Contains(key);
        }
    }
}
#endif