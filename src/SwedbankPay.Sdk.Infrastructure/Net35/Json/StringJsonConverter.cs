#if NET35
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Text.Json
{
    internal class StringJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            if (objectType != null &&
                objectType.Assembly.FullName.StartsWith("SwedbankPay.Sdk") &&
                objectType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(m => 
                    m.Name == "ToString" && m.GetParameters().Length == 0).Count() == 1 &&
                objectType.GetConstructor(new Type[] { typeof(String) }) != null
                )
            {
                return true;
            }
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var value = reader.ReadAsString();
            return Activator.CreateInstance(objectType, new Object[] { value });
        }

        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            writer.WriteValue(value?.ToString());
        }
    }
}
#endif