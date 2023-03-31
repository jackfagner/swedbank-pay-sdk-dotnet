using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace SwedbankPay.Sdk
{
    /// <summary></summary>
    public static class TypeExtensions
    {
        /// <summary></summary>
        public static IList<TFieldType> GetFieldsOfType<TFieldType>(this Type type)
        {
            return type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Where(p => type.IsAssignableFrom(p.FieldType))
                .Select(pi => (TFieldType)pi.GetValue(null))
                .ToList();
        }

        /// <summary></summary>
        public static Boolean IsNullOrWhiteSpace(this String s)
        {
#if NET35
            if (s == null) return true;
            for (int i = 0; i < s.Length; i++)
                if (!Char.IsWhiteSpace(s[i])) return false;
            return true;
#else
            return String.IsNullOrWhiteSpace(s);
#endif
        }

#if NET35
        /// <summary></summary>
        public static T GetCustomAttribute<T>(this Assembly assembly)
        {
            var attributes = assembly.GetCustomAttributes(typeof(T), true).OfType<T>().ToArray();
            if (attributes == null || attributes.Length == 0)
                return default(T);
            if (attributes.Length == 1)
                return attributes[0];
            throw new AmbiguousMatchException();
        }

        /// <summary></summary>
        public static bool HasFlag<T>(this T e1, T e2) where T: Enum
        {
            return EnumHelper.Overlaps<T>(e1, e2);
        }
#endif
    }
}