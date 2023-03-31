#if NET35
using System;
using System.Text;

namespace System.Net.Http
{
    /// <summary></summary>
    public class HttpRequestMessage : IDisposable
    {
        #region properties

        /// <summary></summary>
        public HttpMethod Method { get; private set; }

        /// <summary></summary>
        public Uri RequestUri { get; private set; }

        /// <summary></summary>
        public HttpContent Content { get; internal set; }

        /// <summary></summary>
        public WebHeaderCollection Headers { get; internal set; } = new WebHeaderCollection();

        internal Uri BaseAddress { get; set; }

        #endregion


        #region methods

        internal HttpResponseMessage GetResponse()
        {
            var fullUri = this.RequestUri;
            Uri.TryCreate(this.BaseAddress, this.RequestUri, out fullUri);
            var httpRequest = HttpWebRequest.Create(fullUri) as HttpWebRequest;
            httpRequest.Method = this.Method.ToString();
            httpRequest.Timeout = 20000;
            httpRequest.ReadWriteTimeout = 20000;
            if (!String.IsNullOrEmpty(this.Headers[HttpRequestHeader.Accept]))
            {
                httpRequest.Accept = this.Headers[HttpRequestHeader.Accept];
                this.Headers.Remove(HttpRequestHeader.Accept);
            }
            if (!String.IsNullOrEmpty(this.Headers[HttpRequestHeader.UserAgent]))
            {
                httpRequest.UserAgent = this.Headers[HttpRequestHeader.UserAgent];
                this.Headers.Remove(HttpRequestHeader.UserAgent);
            }
            httpRequest.Headers = this.Headers;
            if (this.Content != null)
            {
                if (!String.IsNullOrEmpty(this.Content.ContentType))
                    httpRequest.ContentType = this.Content.ContentType;
                using (var requestStream = httpRequest.GetRequestStream())
                    this.Content.WriteTo(requestStream);
            }
            HttpWebResponse response = null;
            try
            {
                response = httpRequest.GetResponse() as HttpWebResponse;
            }
            catch (WebException we)
            {
                response = we.Response as HttpWebResponse;
            }
            return new HttpResponseMessage(response);
        }

        #endregion


        #region construction 

        /// <summary></summary>
        public HttpRequestMessage(HttpMethod httpMethod, Uri uri)
        {
            this.Method = httpMethod;
            this.RequestUri = uri;
        }

        /// <summary></summary>
        public void Dispose()
        {
        }

        #endregion
    }
}
#endif