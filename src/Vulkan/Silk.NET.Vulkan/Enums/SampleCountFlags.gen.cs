// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSampleCountFlags")]
    public enum SampleCountFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Count1Bit\"")]
        [NativeName("Name", "VK_SAMPLE_COUNT_1_BIT")]
        SampleCount1Bit = 1,
        [Obsolete("Deprecated in favour of \"Count2Bit\"")]
        [NativeName("Name", "VK_SAMPLE_COUNT_2_BIT")]
        SampleCount2Bit = 2,
        [Obsolete("Deprecated in favour of \"Count4Bit\"")]
        [NativeName("Name", "VK_SAMPLE_COUNT_4_BIT")]
        SampleCount4Bit = 4,
        [Obsolete("Deprecated in favour of \"Count8Bit\"")]
        [NativeName("Name", "VK_SAMPLE_COUNT_8_BIT")]
        SampleCount8Bit = 8,
        [Obsolete("Deprecated in favour of \"Count16Bit\"")]
        [NativeName("Name", "VK_SAMPLE_COUNT_16_BIT")]
        SampleCount16Bit = 16,
        [Obsolete("Deprecated in favour of \"Count32Bit\"")]
        [NativeName("Name", "VK_SAMPLE_COUNT_32_BIT")]
        SampleCount32Bit = 32,
        [Obsolete("Deprecated in favour of \"Count64Bit\"")]
        [NativeName("Name", "VK_SAMPLE_COUNT_64_BIT")]
        SampleCount64Bit = 64,
        [NativeName("Name", "VK_SAMPLE_COUNT_1_BIT")]
        Count1Bit = 1,
        [NativeName("Name", "VK_SAMPLE_COUNT_2_BIT")]
        Count2Bit = 2,
        [NativeName("Name", "VK_SAMPLE_COUNT_4_BIT")]
        Count4Bit = 4,
        [NativeName("Name", "VK_SAMPLE_COUNT_8_BIT")]
        Count8Bit = 8,
        [NativeName("Name", "VK_SAMPLE_COUNT_16_BIT")]
        Count16Bit = 16,
        [NativeName("Name", "VK_SAMPLE_COUNT_32_BIT")]
        Count32Bit = 32,
        [NativeName("Name", "VK_SAMPLE_COUNT_64_BIT")]
        Count64Bit = 64,
    }
}
