using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnFreeFunction
    {
        public readonly delegate* unmanaged[Cdecl]<void*, void*, void> Handle;
        public PfnFreeFunction(delegate* unmanaged[Cdecl]<void*, void*, void> ptr) => Handle = ptr;

        public static implicit operator IntPtr(PfnFreeFunction pfn) => (IntPtr) pfn.Handle;

        public PfnFreeFunction
            (FreeFunction func) => Handle = (delegate* unmanaged[Cdecl]<void*, void*, void>) SilkMarshal.DelegateToPtr
            (func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, void>
            (PfnFreeFunction pfn) => pfn.Handle;

        public static implicit operator PfnFreeFunction
            (delegate* unmanaged[Cdecl]<void*, void*, void> func) => new(func);

        public static implicit operator PfnFreeFunction(FreeFunction func) => new(func);

        public static explicit operator FreeFunction(PfnFreeFunction pfn) => SilkMarshal.PtrToDelegate<FreeFunction>
            ((IntPtr) pfn.Handle);
    }
}