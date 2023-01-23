using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnAllocationFunction : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*> Handle =>
            (delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*>) _handle;

        public PfnAllocationFunction
            (delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*> ptr) => _handle = ptr;

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator nint(PfnAllocationFunction pfn) => (nint) pfn.Handle;

        public PfnAllocationFunction
            (AllocationFunction func) => _handle =
            (delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*>) SilkMarshal.DelegateToPtr
                (func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*>
            (PfnAllocationFunction pfn) => pfn.Handle;

        public static implicit operator PfnAllocationFunction
            (delegate* unmanaged[Cdecl]<void*, nuint, nuint, SystemAllocationScope, void*> func) => new(func);

        public static implicit operator PfnAllocationFunction(AllocationFunction func) => new(func);

        public static explicit operator AllocationFunction
            (PfnAllocationFunction pfn) => SilkMarshal.PtrToDelegate<AllocationFunction>((nint) pfn.Handle);
    }
}
