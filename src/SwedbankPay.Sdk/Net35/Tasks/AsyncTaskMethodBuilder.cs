#if NET35
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    internal class AsyncTaskMethodBuilder<T>
    {
        public Task<T> Task { get; private set; }

        public void SetException(Exception exception)
        {
            throw exception;
        }

        public void SetResult(T result)
        {
            Task.Result = result;
        }

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) 
            where TAwaiter : INotifyCompletion 
            where TStateMachine : IAsyncStateMachine
        {
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) 
            where TAwaiter : ICriticalNotifyCompletion 
            where TStateMachine : IAsyncStateMachine
        {
        }

        public void Start<TStateMachine>(ref TStateMachine stateMachine) 
            where TStateMachine : IAsyncStateMachine
        {
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }

        public static AsyncTaskMethodBuilder<T> Create()
        {
            return new AsyncTaskMethodBuilder<T>();
        }
    }
}
#endif