// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkOpticalFlowSessionCreateFlagsNV")]
    public enum OpticalFlowSessionCreateFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"EnableHintBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV")]
        OpticalFlowSessionCreateEnableHintBitNV = 1,
        [Obsolete("Deprecated in favour of \"EnableCostBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV")]
        OpticalFlowSessionCreateEnableCostBitNV = 2,
        [Obsolete("Deprecated in favour of \"EnableGlobalFlowBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV")]
        OpticalFlowSessionCreateEnableGlobalFlowBitNV = 4,
        [Obsolete("Deprecated in favour of \"AllowRegionsBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV")]
        OpticalFlowSessionCreateAllowRegionsBitNV = 8,
        [Obsolete("Deprecated in favour of \"BothDirectionsBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV")]
        OpticalFlowSessionCreateBothDirectionsBitNV = 16,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV")]
        EnableHintBitNV = 1,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV")]
        EnableCostBitNV = 2,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV")]
        EnableGlobalFlowBitNV = 4,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV")]
        AllowRegionsBitNV = 8,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV")]
        BothDirectionsBitNV = 16,
    }
}
