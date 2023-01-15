// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkOpticalFlowExecuteFlagsNV")]
    public enum OpticalFlowExecuteFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DisableTemporalHintsBitNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV")]
        OpticalFlowExecuteDisableTemporalHintsBitNV = 1,
        [NativeName("Name", "VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV")]
        DisableTemporalHintsBitNV = 1,
    }
}
