// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPerformanceConfigurationTypeINTEL
{
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = 0,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_PERFORMANCE_CONFIGURATION_TYPE_MAX_ENUM_INTEL = 0x7FFFFFFF,
}
