// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDirectDriverLoadingInfoLUNARG")]
[NameAffix("Suffix", "KhronosVendor", "LUNARG")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDirectDriverLoadingInfoLUNARG
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkDirectDriverLoadingFlagsLUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public uint Flags;

    [NativeName("pfnGetInstanceProcAddr")]
    [NativeTypeName("PFN_vkGetInstanceProcAddrLUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public PfnVkGetInstanceProcAddrLUNARG PfnGetInstanceProcAddr;
}
