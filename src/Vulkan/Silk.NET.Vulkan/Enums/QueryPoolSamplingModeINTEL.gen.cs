// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueryPoolSamplingModeINTEL")]
    public enum QueryPoolSamplingModeINTEL : int
    {
        [Obsolete("Deprecated in favour of \"ManualIntel\"")]
        [NativeName("Name", "VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL")]
        QueryPoolSamplingModeManualIntel = 0,
        [NativeName("Name", "VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL")]
        ManualIntel = 0,
    }
}
