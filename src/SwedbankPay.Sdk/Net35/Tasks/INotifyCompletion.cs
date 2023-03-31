#if NET35
using System;

namespace System.Runtime.CompilerServices
{
    internal interface INotifyCompletion
    {
        void OnCompleted(Action continuation);
    }
}
#endif