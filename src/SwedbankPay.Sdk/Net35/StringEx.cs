#if NET35
using System;

namespace System
{
    internal static class StringEx
    {
        internal static bool IsNullOrWhiteSpace(this String s)
        {
            if (s == null) return true;

            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsWhiteSpace(s[i])) return false;
            }

            return true;
        }


    }
}
#endif