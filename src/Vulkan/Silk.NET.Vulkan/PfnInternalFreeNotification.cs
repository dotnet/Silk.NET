using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnInternalFreeNotification
    {
        public readonly delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void>
            Handle;

        public PfnInternalFreeNotification
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void> ptr) =>
            Handle = ptr;

        public PfnInternalFreeNotification
            (InternalFreeNotification func) => Handle =
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void>) SilkMarshal
                .DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType,
            SystemAllocationScope, void>(PfnInternalFreeNotification pfn) => pfn.Handle;

        public static implicit operator PfnInternalFreeNotification
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void> func) =>
            new(func);

        public static implicit operator PfnInternalFreeNotification(InternalFreeNotification func) => new(func);

        public static explicit operator InternalFreeNotification
            (PfnInternalFreeNotification pfn) => SilkMarshal.PtrToDelegate<InternalFreeNotification>
            ((IntPtr) pfn.Handle);
    }
}