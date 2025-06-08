// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkGetInstanceProcAddrLUNARG : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<VkInstance_T*, sbyte*, PFN_vkGetInstanceProcAddrLUNARG_p2> Handle =>
        (delegate* unmanaged<VkInstance_T*, sbyte*, PFN_vkGetInstanceProcAddrLUNARG_p2>)_pointer;

    public PFN_vkGetInstanceProcAddrLUNARG(
        delegate* unmanaged<VkInstance_T*, sbyte*, PFN_vkGetInstanceProcAddrLUNARG_p2> ptr
    ) => _pointer = ptr;

    public PFN_vkGetInstanceProcAddrLUNARG(PFN_vkGetInstanceProcAddrLUNARGDelegate proc) =>
        _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkGetInstanceProcAddrLUNARG(
        delegate* unmanaged<VkInstance_T*, sbyte*, PFN_vkGetInstanceProcAddrLUNARG_p2> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        VkInstance_T*,
        sbyte*,
        PFN_vkGetInstanceProcAddrLUNARG_p2>(PFN_vkGetInstanceProcAddrLUNARG pfn) =>
        (delegate* unmanaged<VkInstance_T*, sbyte*, PFN_vkGetInstanceProcAddrLUNARG_p2>)
            pfn._pointer;
}
