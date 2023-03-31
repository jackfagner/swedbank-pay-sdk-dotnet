#if NET35
using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
    /// <summary>
    /// Task polyfill for .NET 3.5
    /// </summary>
    /// <typeparam name="T">Task type</typeparam>
    public class Task<T> : Task
    {
        public T Result { get; internal set; }

        public TaskAwaiter<T> GetAwaiter()
        {
            return new TaskAwaiter<T>(this);
        }

        public Task(T result)
        {
            this.Result = result;
        }
    }

    /// <summary>
    /// Task polyfill for .NET 3.5
    /// </summary>
    public class Task
    {
        
    }
}
#endif