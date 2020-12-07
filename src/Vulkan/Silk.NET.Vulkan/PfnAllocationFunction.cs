using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnAllocationFunction
    {
        public readonly delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*> Handle;

        public PfnAllocationFunction
            (delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*> ptr) => Handle = ptr;

        public static implicit operator IntPtr(PfnAllocationFunction pfn) => (IntPtr) pfn.Handle;

        public PfnAllocationFunction
            (AllocationFunction func) => Handle =
            (delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*>) SilkMarshal.DelegateToPtr
                (func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*>
            (PfnAllocationFunction pfn) => pfn.Handle;

        public static implicit operator PfnAllocationFunction
            (delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*> func) => new(func);

        public static implicit operator PfnAllocationFunction(AllocationFunction func) => new(func);

        public static explicit operator AllocationFunction
            (PfnAllocationFunction pfn) => SilkMarshal.PtrToDelegate<AllocationFunction>((IntPtr) pfn.Handle);
    }
}