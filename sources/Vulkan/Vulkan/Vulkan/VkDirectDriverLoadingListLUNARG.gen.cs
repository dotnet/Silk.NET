// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDirectDriverLoadingListLUNARG
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public void* pNext;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public VkDirectDriverLoadingModeLUNARG mode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public uint driverCount;

    [NativeTypeName("const VkDirectDriverLoadingInfoLUNARG *")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public VkDirectDriverLoadingInfoLUNARG* pDrivers;
}
