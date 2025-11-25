// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DirectDriverLoadingInfoLunarg
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public StructureType SType;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public void* PNext;

    [NativeTypeName("VkDirectDriverLoadingFlagsLUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public uint Flags;

    [NativeTypeName("PFN_vkGetInstanceProcAddrLUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public PFNVkGetInstanceProcAddrLunarg PfnGetInstanceProcAddr;
}
