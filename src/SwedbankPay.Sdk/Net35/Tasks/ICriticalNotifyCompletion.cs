#if NET35
using System;

namespace System.Runtime.CompilerServices
{
    internal interface ICriticalNotifyCompletion
    {
        void UnsafeOnCompleted(Action continuation);
    }
}
#endif