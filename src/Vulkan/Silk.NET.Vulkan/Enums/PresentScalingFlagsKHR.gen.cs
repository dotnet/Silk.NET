// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPresentScalingFlagsKHR")]
    public enum PresentScalingFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"OneToOneBitKhr\"")]
        [NativeName("Name", "VK_PRESENT_SCALING_ONE_TO_ONE_BIT_KHR")]
        PresentScalingOneToOneBitKhr = 1,
        [Obsolete("Deprecated in favour of \"OneToOneBitExt\"")]
        [NativeName("Name", "VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT")]
        PresentScalingOneToOneBitExt = 1,
        [Obsolete("Deprecated in favour of \"AspectRatioStretchBitKhr\"")]
        [NativeName("Name", "VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_KHR")]
        PresentScalingAspectRatioStretchBitKhr = 2,
        [Obsolete("Deprecated in favour of \"AspectRatioStretchBitExt\"")]
        [NativeName("Name", "VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT")]
        PresentScalingAspectRatioStretchBitExt = 2,
        [Obsolete("Deprecated in favour of \"StretchBitKhr\"")]
        [NativeName("Name", "VK_PRESENT_SCALING_STRETCH_BIT_KHR")]
        PresentScalingStretchBitKhr = 4,
        [Obsolete("Deprecated in favour of \"StretchBitExt\"")]
        [NativeName("Name", "VK_PRESENT_SCALING_STRETCH_BIT_EXT")]
        PresentScalingStretchBitExt = 4,
        [NativeName("Name", "VK_PRESENT_SCALING_ONE_TO_ONE_BIT_KHR")]
        OneToOneBitKhr = 1,
        [NativeName("Name", "VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT")]
        OneToOneBitExt = 1,
        [NativeName("Name", "VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_KHR")]
        AspectRatioStretchBitKhr = 2,
        [NativeName("Name", "VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT")]
        AspectRatioStretchBitExt = 2,
        [NativeName("Name", "VK_PRESENT_SCALING_STRETCH_BIT_KHR")]
        StretchBitKhr = 4,
        [NativeName("Name", "VK_PRESENT_SCALING_STRETCH_BIT_EXT")]
        StretchBitExt = 4,
    }
}
