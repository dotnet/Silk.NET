// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueryPoolSamplingModeINTEL")]
    public enum QueryPoolSamplingModeINTEL
    {
        [NativeName("Name", "VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL")]
        QueryPoolSamplingModeManualIntel = 0,
    }
}
