// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPastPresentationTimingFlagsEXT")]
    public enum PastPresentationTimingFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PartialResultsBitExt\"")]
        [NativeName("Name", "VK_PAST_PRESENTATION_TIMING_ALLOW_PARTIAL_RESULTS_BIT_EXT")]
        PastPresentationTimingAllowPartialResultsBitExt = 1,
        [Obsolete("Deprecated in favour of \"OutOfOrderResultsBitExt\"")]
        [NativeName("Name", "VK_PAST_PRESENTATION_TIMING_ALLOW_OUT_OF_ORDER_RESULTS_BIT_EXT")]
        PastPresentationTimingAllowOutOfOrderResultsBitExt = 2,
        [NativeName("Name", "VK_PAST_PRESENTATION_TIMING_ALLOW_PARTIAL_RESULTS_BIT_EXT")]
        PartialResultsBitExt = 1,
        [NativeName("Name", "VK_PAST_PRESENTATION_TIMING_ALLOW_OUT_OF_ORDER_RESULTS_BIT_EXT")]
        OutOfOrderResultsBitExt = 2,
    }
}
