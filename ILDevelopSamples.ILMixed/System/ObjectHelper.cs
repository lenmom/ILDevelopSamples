using System.Runtime.CompilerServices;

namespace System
{
    public class ObjectHelper
    {
        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern int SizeOf<T>();
    }
}
