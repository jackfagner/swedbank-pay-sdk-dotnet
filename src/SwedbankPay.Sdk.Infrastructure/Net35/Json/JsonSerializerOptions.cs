#if NET35
using Newtonsoft.Json;
using System;

namespace System.Text.Json
{
    public class JsonSerializerOptions
    {
        public JsonSerializerSettings Settings { get; }

        public String OutputDebugPath { get; set; }

        public JsonSerializerOptions(JsonSerializerSettings settings)
        {
            this.Settings = settings;
        }
    }
}
#endif