// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkAntiLagModeAMD : uint
{
    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD = 0,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_ANTI_LAG_MODE_ON_AMD = 1,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_ANTI_LAG_MODE_OFF_AMD = 2,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_ANTI_LAG_MODE_MAX_ENUM_AMD = 0x7FFFFFFF,
}
