using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnInternalFreeNotification : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void>
            Handle =>
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void>) _handle;

        public PfnInternalFreeNotification
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void> ptr) =>
            _handle = ptr;

        public PfnInternalFreeNotification
            (InternalFreeNotification func) => _handle =
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void>) SilkMarshal
                .DelegateToPtr(func);

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType,
            SystemAllocationScope, void>(PfnInternalFreeNotification pfn) => pfn.Handle;

        public static implicit operator PfnInternalFreeNotification
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void> func) =>
            new(func);

        public static implicit operator PfnInternalFreeNotification(InternalFreeNotification func) => new(func);

        public static explicit operator InternalFreeNotification
            (PfnInternalFreeNotification pfn) => SilkMarshal.PtrToDelegate<InternalFreeNotification>
            ((nint) pfn.Handle);
    }
}
