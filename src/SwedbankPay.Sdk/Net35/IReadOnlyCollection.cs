#if NET35
using System;
using System.Collections.ObjectModel;
using System.Text;

namespace System.Collections.Generic
{
    /// <summary>
    /// .NET 3.5 polyfill
    /// </summary>
    public class IReadOnlyCollection<T> : List<T>
    {
        /// <summary>
        /// Convert from ReadOnlyCollection
        /// </summary>
        public static implicit operator IReadOnlyCollection<T>(ReadOnlyCollection<T> list)
        {
            return new IReadOnlyCollection<T>(list);
        }

        /// <summary>
        /// 
        /// </summary>
        public IReadOnlyCollection(IList<T> list) : base(list)
        {

        }
    }
}
#endif