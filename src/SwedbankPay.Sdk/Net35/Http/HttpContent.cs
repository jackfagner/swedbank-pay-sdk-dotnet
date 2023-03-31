#if NET35
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace System.Net.Http
{
    /// <summary></summary>
    public abstract class HttpContent
    {
        private MemoryStream _ms = new MemoryStream();

        /// <summary></summary>
        public virtual String ContentType { get; internal set; }

        internal virtual String ReadAsString()
        {
            return Encoding.UTF8.GetString(_ms.ToArray());
        }

        internal virtual Task<String> ReadAsStringAsync()
        {
            return new Task<String>(ReadAsString());
        }

        internal virtual void WriteTo(Stream stream)
        {
            var data = _ms.ToArray();
            stream.Write(data, 0, data.Length);
        }
    }
}
#endif
