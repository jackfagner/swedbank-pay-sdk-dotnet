#if NET35
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SwedbankPay.Sdk.JsonSerialization;
using System;

namespace System.Text.Json
{
    internal class JsonSerializer
    {
        internal static T Deserialize<T>(String json, JsonSerializerOptions options = null)
        {
            return JsonConvert.DeserializeObject<T>(json, 
                (options ?? JsonSerialization.Settings)?.Settings);
        }

        internal static String Serialize(Object obj, JsonSerializerOptions options = null)
        {
            return JsonConvert.SerializeObject(obj, 
                (options ?? JsonSerialization.Settings)?.Settings);
        }
    }
}
#endif