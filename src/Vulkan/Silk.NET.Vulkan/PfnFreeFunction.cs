using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnFreeFunction : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void*, void*, void> Handle =>
            (delegate* unmanaged[Cdecl]<void*, void*, void>) _handle;

        public PfnFreeFunction(delegate* unmanaged[Cdecl]<void*, void*, void> ptr) => _handle = ptr;

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator nint(PfnFreeFunction pfn) => (nint) pfn.Handle;

        public PfnFreeFunction
            (FreeFunction func) => _handle = (delegate* unmanaged[Cdecl]<void*, void*, void>) SilkMarshal.DelegateToPtr
            (func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, void>
            (PfnFreeFunction pfn) => pfn.Handle;

        public static implicit operator PfnFreeFunction
            (delegate* unmanaged[Cdecl]<void*, void*, void> func) => new(func);

        public static implicit operator PfnFreeFunction(FreeFunction func) => new(func);

        public static explicit operator FreeFunction(PfnFreeFunction pfn) => SilkMarshal.PtrToDelegate<FreeFunction>
            ((nint) pfn.Handle);
    }
}
