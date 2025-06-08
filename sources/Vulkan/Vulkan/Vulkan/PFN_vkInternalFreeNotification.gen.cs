// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkInternalFreeNotification : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<
        void*,
        nuint,
        VkInternalAllocationType,
        VkSystemAllocationScope,
        void> Handle =>
        (delegate* unmanaged<
            void*,
            nuint,
            VkInternalAllocationType,
            VkSystemAllocationScope,
            void>)_pointer;

    public PFN_vkInternalFreeNotification(
        delegate* unmanaged<
            void*,
            nuint,
            VkInternalAllocationType,
            VkSystemAllocationScope,
            void> ptr
    ) => _pointer = ptr;

    public PFN_vkInternalFreeNotification(PFN_vkInternalFreeNotificationDelegate proc) =>
        _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkInternalFreeNotification(
        delegate* unmanaged<
            void*,
            nuint,
            VkInternalAllocationType,
            VkSystemAllocationScope,
            void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void*,
        nuint,
        VkInternalAllocationType,
        VkSystemAllocationScope,
        void>(PFN_vkInternalFreeNotification pfn) =>
        (delegate* unmanaged<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void>)
            pfn._pointer;
}
