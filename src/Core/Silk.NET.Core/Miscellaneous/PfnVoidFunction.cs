using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Core
{
    public readonly unsafe struct PfnVoidFunction
    {
        public readonly delegate* unmanaged[Cdecl]<void> Handle;
        public PfnVoidFunction(delegate* unmanaged[Cdecl]<void> ptr) => Handle = ptr;

        public static implicit operator IntPtr(PfnVoidFunction pfn) => (IntPtr) pfn.Handle;

        public PfnVoidFunction
            (Delegate func) => Handle = (delegate* unmanaged[Cdecl]<void>) SilkMarshal.DelegateToPtr
            (func);

        public static implicit operator delegate* unmanaged[Cdecl]<void>
            (PfnVoidFunction pfn) => pfn.Handle;

        public static implicit operator PfnVoidFunction
            (delegate* unmanaged[Cdecl]<void> func) => new(func);

        public static implicit operator PfnVoidFunction(Delegate func) => new(func);
    }
}