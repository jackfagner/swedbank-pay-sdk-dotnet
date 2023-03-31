#if NET35
using System;

namespace System.Runtime.CompilerServices
{
    public interface ICriticalNotifyCompletion
    {
        void UnsafeOnCompleted(Action continuation);
    }
}
#endif