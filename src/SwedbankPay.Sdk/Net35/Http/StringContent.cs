#if NET35
using System;
using System.IO;
using System.Text;

namespace System.Net.Http
{
    /// <summary></summary>
    public class StringContent : HttpContent
    {
        #region properties

        /// <summary></summary>
        public String Content { get; }
        /// <summary></summary>
        public Encoding Encoding { get; }
        /// <summary></summary>
        public override String ContentType { get; internal set; }

        #endregion

        #region methods

        internal override String ReadAsString()
        {
            return this.Content;
        }

        internal override void WriteTo(Stream stream)
        {
            var data = this.Encoding.GetBytes(this.Content);
            stream.Write(data, 0, data.Length);
        }

        #endregion


        #region construction

        /// <summary></summary>
        public StringContent(String content, Encoding encoding, String contentType)
        {
            this.Content = content;
            this.Encoding = encoding;
            this.ContentType = contentType;
        }

        #endregion
    }
}
#endif