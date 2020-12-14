using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnReallocationFunction
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, SystemAllocationScope, void*> Handle =>
            (delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, SystemAllocationScope, void*>) _handle;

        public PfnReallocationFunction
            (delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, SystemAllocationScope, void*> ptr) => _handle = ptr;

        public static implicit operator IntPtr(PfnReallocationFunction pfn) => (IntPtr) pfn.Handle;

        public PfnReallocationFunction
            (ReallocationFunction func) => _handle =
            (delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, SystemAllocationScope, void*>) SilkMarshal
                .DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, SystemAllocationScope,
            void*>(PfnReallocationFunction pfn) => pfn.Handle;

        public static implicit operator PfnReallocationFunction
            (delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, SystemAllocationScope, void*> func) => new(func);

        public static implicit operator PfnReallocationFunction(ReallocationFunction func) => new(func);

        public static explicit operator ReallocationFunction
            (PfnReallocationFunction pfn) => SilkMarshal.PtrToDelegate<ReallocationFunction>((IntPtr) pfn.Handle);
    }
}