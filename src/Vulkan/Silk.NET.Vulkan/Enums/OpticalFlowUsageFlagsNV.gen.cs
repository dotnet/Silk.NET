// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkOpticalFlowUsageFlagsNV")]
    public enum OpticalFlowUsageFlagsNV : int
    {
        [Obsolete("Deprecated in favour of \"UnknownNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV")]
        OpticalFlowUsageUnknownNV = 0,
        [Obsolete("Deprecated in favour of \"InputBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV")]
        OpticalFlowUsageInputBitNV = 1,
        [Obsolete("Deprecated in favour of \"OutputBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV")]
        OpticalFlowUsageOutputBitNV = 2,
        [Obsolete("Deprecated in favour of \"HintBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV")]
        OpticalFlowUsageHintBitNV = 4,
        [Obsolete("Deprecated in favour of \"CostBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_COST_BIT_NV")]
        OpticalFlowUsageCostBitNV = 8,
        [Obsolete("Deprecated in favour of \"GlobalFlowBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV")]
        OpticalFlowUsageGlobalFlowBitNV = 16,
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV")]
        UnknownNV = 0,
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV")]
        InputBitNV = 1,
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV")]
        OutputBitNV = 2,
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV")]
        HintBitNV = 4,
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_COST_BIT_NV")]
        CostBitNV = 8,
        [NativeName("Name", "VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV")]
        GlobalFlowBitNV = 16,
    }
}
