// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnInternalAllocationNotification
    {
        public readonly delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void>
            Handle;

        public PfnInternalAllocationNotification
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void> ptr) =>
            Handle = ptr;

        public PfnInternalAllocationNotification
            (InternalAllocationNotification func) => Handle =
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void>) SilkMarshal
                .DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType,
            SystemAllocationScope, void>(PfnInternalAllocationNotification pfn) => pfn.Handle;

        public static implicit operator PfnInternalAllocationNotification
            (delegate* unmanaged[Cdecl]<void*, nuint, InternalAllocationType, SystemAllocationScope, void> func) =>
            new(func);

        public static implicit operator PfnInternalAllocationNotification
            (InternalAllocationNotification func) => new(func);

        public static explicit operator InternalAllocationNotification
            (PfnInternalAllocationNotification pfn) => SilkMarshal.PtrToDelegate<InternalAllocationNotification>
            ((IntPtr) pfn.Handle);
    }
}
