// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDirectDriverLoadingModeLUNARG : uint
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG = 0,

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG = 1,

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    VK_DIRECT_DRIVER_LOADING_MODE_MAX_ENUM_LUNARG = 0x7FFFFFFF,
}
