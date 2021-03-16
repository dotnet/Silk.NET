// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceConfigurationTypeINTEL")]
    public enum PerformanceConfigurationTypeINTEL : int
    {
        [NativeName("Name", "VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL")]
        PerformanceConfigurationTypeCommandQueueMetricsDiscoveryActivatedIntel = 0,
    }
}
