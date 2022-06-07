using InlineIL;

namespace System;

public static class GenericHelper
{
    public static bool AreSame<T>(ref T a, ref T b)
    {
        IL.Emit.Ldarg(nameof(a));
        IL.Emit.Ldarg(nameof(b));
        IL.Emit.Ceq();
        return IL.Return<bool>();
    }
}