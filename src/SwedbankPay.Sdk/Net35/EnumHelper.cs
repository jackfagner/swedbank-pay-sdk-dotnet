﻿#if NET35
using System;

namespace System
{
    internal static class EnumHelper<T1>
    {
        public static Func<T1, T1, bool> TestOverlapProc = initProc;
        public static bool Overlaps(SByte p1, SByte p2) { return (p1 & p2) != 0; }
        public static bool Overlaps(Byte p1, Byte p2) { return (p1 & p2) != 0; }
        public static bool Overlaps(Int16 p1, Int16 p2) { return (p1 & p2) != 0; }
        public static bool Overlaps(UInt16 p1, UInt16 p2) { return (p1 & p2) != 0; }
        public static bool Overlaps(Int32 p1, Int32 p2) { return (p1 & p2) != 0; }
        public static bool Overlaps(UInt32 p1, UInt32 p2) { return (p1 & p2) != 0; }
        public static bool Overlaps(Int64 p1, Int64 p2) { return (p1 & p2) != 0; }
        public static bool Overlaps(UInt64 p1, UInt64 p2) { return (p1 & p2) != 0; }
        public static bool initProc(T1 p1, T1 p2)
        {
            Type typ1 = typeof(T1);
            if (typ1 == typeof(Enum))
                typ1 = p1.GetType();
            if (typ1.IsEnum) typ1 = Enum.GetUnderlyingType(typ1);
            Type[] types = { typ1, typ1 };
            var method = typeof(EnumHelper<T1>).GetMethod("Overlaps", types);
            if (method == null) method = typeof(T1).GetMethod("Overlaps", types);
            if (method == null) throw new MissingMethodException("Unknown type of enum");
            return (bool)method.Invoke(null, new object[] { p1, p2 });
        }
    }

    internal static class EnumHelper
    {
        internal static bool Overlaps<T>(this T p1, T p2) where T : Enum
        {
            return EnumHelper<T>.TestOverlapProc(p1, p2);
        }
    }
}
#endif