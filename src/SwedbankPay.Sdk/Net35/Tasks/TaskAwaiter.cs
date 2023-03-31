#if NET35
using System;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    public class TaskAwaiter<T> : TaskAwaiter
    {
        private Task<T> _task;

        public override bool IsCompleted => true;

        public T GetResult()
        {
            return _task.Result;
        }

        public TaskAwaiter(Task<T> task) : base()
        {
            this._task = task;
        }
    }

    public abstract class TaskAwaiter : INotifyCompletion, ICriticalNotifyCompletion
    {
        public abstract Boolean IsCompleted { get; }

        protected TaskAwaiter()
        {
        }

        public void OnCompleted(Action continuation)
        {
        }

        public void UnsafeOnCompleted(Action continuation)
        {
        }
    }
}
#endif