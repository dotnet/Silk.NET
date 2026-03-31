// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkGetInstanceProcAddrLUNARG")]
[NameAffix("Suffix", "KhronosVendor", "LUNARG")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct PfnVkGetInstanceProcAddrLUNARG : IDisposable
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrLunargP2> Handle =>
        (delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrLunargP2>)Pointer;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public PfnVkGetInstanceProcAddrLUNARG(
        delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrLunargP2> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public PfnVkGetInstanceProcAddrLUNARG(PfnVkGetInstanceProcAddrLUNARGDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public static implicit operator PfnVkGetInstanceProcAddrLUNARG(
        delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrLunargP2> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public static implicit operator delegate* unmanaged<
        VkInstanceHandle,
        sbyte*,
        PfnVkGetInstanceProcAddrLunargP2>(PfnVkGetInstanceProcAddrLUNARG pfn) =>
        (delegate* unmanaged<VkInstanceHandle, sbyte*, PfnVkGetInstanceProcAddrLunargP2>)
            pfn.Pointer;
}
