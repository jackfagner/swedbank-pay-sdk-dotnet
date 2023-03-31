#if NET35
using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
    /// <summary>
    /// Task polyfill for .NET 3.5
    /// </summary>
    /// <typeparam name="T">Task type</typeparam>
    public class Task<T>
    {
        private T _result = default(T);

        internal Exception Exception { get; set; }

        public T Result
        {
            get
            {
                var e = this.Exception;
                if (e != null)
                    throw e;
                return _result;
            }
            set
            {
                _result = value;
            }
        }

        internal TaskAwaiter<T> GetAwaiter()
        {
            return new TaskAwaiter<T>(this);
        }

        public Task(T result)
        {
            this.Result = result;
        }

        internal Task(Exception exception)
        {
            this.Exception = exception;
        }
    }
}
#endif