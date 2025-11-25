// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceConfigurationTypeINTEL")]
[SupportedApiProfile("vulkan")]
public enum PerformanceConfigurationTypeIntel : uint
{
    [NativeName(
        "VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL"
    )]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    CommandQueueMetricsDiscoveryActivatedIntel = 0,
}
