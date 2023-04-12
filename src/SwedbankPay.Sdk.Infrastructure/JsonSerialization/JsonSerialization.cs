#if NET35
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
#else
using SwedbankPay.Sdk.JsonSerialization.Converters;
#endif
using System.Text.Json;

namespace SwedbankPay.Sdk.JsonSerialization
{
    public static class JsonSerialization
    {
        static JsonSerialization()
        {
#if NET35
            Settings = new JsonSerializerOptions(new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new JsonConverter [] { new StringJsonConverter() },
                NullValueHandling = NullValueHandling.Ignore,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            });
#else
            Settings = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                MaxDepth = 64,
                IgnoreReadOnlyProperties = false
            };

            Settings.Converters.Add(new CustomDateTimeConverter());
            Settings.Converters.Add(new CustomMetadataDtoConverter());
#endif
        }

        public static JsonSerializerOptions Settings { get; private set; }
    }
}