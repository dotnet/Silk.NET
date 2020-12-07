// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceConfigurationTypeINTEL")]
    public enum PerformanceConfigurationTypeINTEL
    {
        [NativeName("Name", "VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL")]
        PerformanceConfigurationTypeCommandQueueMetricsDiscoveryActivatedIntel = 0,
    }
}
