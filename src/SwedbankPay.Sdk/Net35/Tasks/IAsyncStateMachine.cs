#if NET35
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Runtime.CompilerServices
{
    internal interface IAsyncStateMachine
    {
        void MoveNext();

        void SetStateMachine(IAsyncStateMachine stateMachine);
    }
}
#endif