// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "LUNARG", 0)]
[NativeName("PFN_vkGetInstanceProcAddrLUNARG")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct GetInstanceProcAddrLUNARG : IDisposable
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2> Handle =>
        (delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2>)Pointer;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public GetInstanceProcAddrLUNARG(
        delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public GetInstanceProcAddrLUNARG(GetInstanceProcAddrDelegateLUNARG proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public static implicit operator GetInstanceProcAddrLUNARG(
        delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public static implicit operator delegate* unmanaged<
        InstanceHandle,
        sbyte*,
        GetInstanceProcAddrLunargP2>(GetInstanceProcAddrLUNARG pfn) =>
        (delegate* unmanaged<InstanceHandle, sbyte*, GetInstanceProcAddrLunargP2>)pfn.Pointer;
}
