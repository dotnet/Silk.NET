// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDirectDriverLoadingInfoLUNARG
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public void* pNext;

    [NativeTypeName("VkDirectDriverLoadingFlagsLUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public uint flags;

    [NativeTypeName("PFN_vkGetInstanceProcAddrLUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public PFN_vkGetInstanceProcAddrLUNARG pfnGetInstanceProcAddr;
}
