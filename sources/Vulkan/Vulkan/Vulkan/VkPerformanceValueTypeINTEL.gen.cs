// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPerformanceValueTypeINTEL
{
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = 0,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = 1,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = 2,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = 3,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = 4,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_VALUE_TYPE_MAX_ENUM_INTEL = 0x7FFFFFFF,
}
