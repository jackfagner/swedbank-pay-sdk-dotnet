#if NET35
using System;

namespace System.Net.Http
{
    public class AuthenticationHeaderValue
    {
        public string Scheme { get; set; }
        public string Parameter { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Parameter))
                return Scheme;
            return Scheme + " " + Parameter;
        }

        public AuthenticationHeaderValue(string scheme, string parameter)
        {
            Scheme = scheme;
            Parameter = parameter;
        }
    }
}
#endif