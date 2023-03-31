#if NET35
using System;
using System.Threading.Tasks;

namespace System.Net.Http
{
    /// <summary></summary>
    public class HttpClient
    {
        #region properties

        /// <summary></summary>
        public Uri BaseAddress { get; set; }

        public HttpRequestHeaders DefaultRequestHeaders { get; internal set; } = new HttpRequestHeaders();

        #endregion

        #region methods

        private void AddHeaders(HttpRequestMessage httpRequestMessage)
        {
            
            if (DefaultRequestHeaders != null)
            {
                foreach (var key in DefaultRequestHeaders.AllKeys)
                    httpRequestMessage.Headers[key] = DefaultRequestHeaders[key];
            }
            var authorization = this.DefaultRequestHeaders?.Authorization?.ToString()?.Trim();
            if (!String.IsNullOrEmpty(authorization))
                httpRequestMessage.Headers[HttpRequestHeader.Authorization] = authorization;
        }

        internal HttpResponseMessage Get(Uri uri)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                return Send(request);
            }
        }

        internal Task<HttpResponseMessage> GetAsync(Uri uri)
        {
            return new Task<HttpResponseMessage>(Get(uri));
        }

        internal HttpResponseMessage Send(HttpRequestMessage httpRequestMessage)
        {
            AddHeaders(httpRequestMessage);
            httpRequestMessage.BaseAddress = this.BaseAddress;
            return httpRequestMessage.GetResponse();
        }

        internal Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage)
        {
            return new Task<HttpResponseMessage>(Send(httpRequestMessage));
        }

        #endregion


        #region construction

        public HttpClient()
        {
        }

        #endregion
    }
}
#endif