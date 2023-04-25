#if NET35
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SwedbankPay.Sdk.JsonSerialization;
using System;
using System.IO;

namespace System.Text.Json
{
    internal class JsonSerializer
    {
        internal static T Deserialize<T>(String json, JsonSerializerOptions options = null)
        {
            if (!String.IsNullOrEmpty(options.OutputDebugPath) && Directory.Exists(options.OutputDebugPath))
                File.WriteAllText(Path.Combine(options.OutputDebugPath, "DeserializeInput_" + DateTime.Now.Ticks + ".json"), json, Encoding.UTF8);

            return JsonConvert.DeserializeObject<T>(json, 
                (options ?? JsonSerialization.Settings)?.Settings);
        }

        internal static String Serialize(Object obj, JsonSerializerOptions options = null)
        {
            var result = JsonConvert.SerializeObject(obj, 
                (options ?? JsonSerialization.Settings)?.Settings);

            if (!String.IsNullOrEmpty(options.OutputDebugPath) && Directory.Exists(options.OutputDebugPath))
                File.WriteAllText(Path.Combine(options.OutputDebugPath, "SerializeResult_" + DateTime.Now.Ticks + ".json"), result, Encoding.UTF8);

            return result;
        }
    }
}
#endif