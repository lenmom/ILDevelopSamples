using InlineIL;
using static InlineIL.IL.Emit;

namespace System
{
    public class GenericHelper
    {
        public static bool AreSame<T>(ref T a, ref T b)
        {
            Ldarg(nameof(a));
            Ldarg(nameof(b));
            Ceq();
            return IL.Return<bool>();
        }
    }
}
