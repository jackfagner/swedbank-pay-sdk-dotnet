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
            var task = Task;
            if (task != null)
                task.Exception = exception;
            else
                Task = new Task<T>(exception);
        }

        public void SetResult(T result)
        {
            var task = Task;
            if (task != null)
                task.Result = result;
            else
                Task = new Task<T>(result);
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
            try
            {
                stateMachine.MoveNext();
            }
            catch (Exception)
            {

            }
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