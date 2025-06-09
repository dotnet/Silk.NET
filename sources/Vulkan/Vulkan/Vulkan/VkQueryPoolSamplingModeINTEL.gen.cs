// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkQueryPoolSamplingModeINTEL : uint
{
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = 0,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_QUERY_POOL_SAMPLING_MODE_MAX_ENUM_INTEL = 0x7FFFFFFF,
}
