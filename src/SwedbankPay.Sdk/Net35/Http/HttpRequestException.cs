#if NET35
using System;

namespace System.Net.Http
{
    /// <summary>
    /// .NET 3.5 polyfill
    /// </summary>
    public class HttpRequestException : Exception
    {
    }
}
#endif