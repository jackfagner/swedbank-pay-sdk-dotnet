#if NET35
using System;
using System.IO;
using System.Text;

namespace System.Net.Http
{
    /// <summary></summary>
    public class HttpResponseMessage : IDisposable
    {
        #region fields

        private HttpWebResponse _response;

        #endregion


        #region properties

        /// <summary></summary>
        public Boolean IsSuccessStatusCode
        {
            get
            {
                var intCode = (Int32)this.StatusCode;
                return intCode >= 200 && intCode <= 299;
            }
        }

        /// <summary></summary>
        public HttpStatusCode StatusCode { get { return _response.StatusCode; } }

        /// <summary></summary>
        internal HttpContent Content { get; private set; }

        #endregion


        #region methods

        private HttpContent GetContent()
        {
            var contentType = _response.ContentType;
            //var encoding = _response.ContentEncoding;
            var encoding = Encoding.UTF8;
            using (var responseStream = _response.GetResponseStream())
            using (var sr = new StreamReader(responseStream, encoding))
            {
                return new StringContent(sr.ReadToEnd(), encoding, contentType);
            }
        }

        #endregion


        #region construction

        /// <summary></summary>
        public void Dispose()
        {
            _response?.Close();
        }

        internal HttpResponseMessage(HttpWebResponse webResponse)
        {
            _response = webResponse;
            this.Content = GetContent();
        }

        #endregion
    }
}
#endif