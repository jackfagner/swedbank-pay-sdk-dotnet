#if NET35
namespace System
{
    internal class Lazy<T>
    {
        private T _value;
        private Func<T> _func;
        private Boolean _isSet = false;

        internal T Value
        {
            get
            {
                if (!_isSet)
                {
                    _value = _func();
                    _isSet = true;
                }
                return _value;
            }
        }


        internal Lazy(Func<T> func)
        {
            _func = func;
        }
    }
}
#endif