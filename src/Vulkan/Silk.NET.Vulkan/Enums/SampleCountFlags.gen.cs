// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSampleCountFlags")]
    public enum SampleCountFlags
    {
        [NativeName("Name", "VK_SAMPLE_COUNT_1_BIT")]
        SampleCount1Bit = 1,
        [NativeName("Name", "VK_SAMPLE_COUNT_2_BIT")]
        SampleCount2Bit = 2,
        [NativeName("Name", "VK_SAMPLE_COUNT_4_BIT")]
        SampleCount4Bit = 4,
        [NativeName("Name", "VK_SAMPLE_COUNT_8_BIT")]
        SampleCount8Bit = 8,
        [NativeName("Name", "VK_SAMPLE_COUNT_16_BIT")]
        SampleCount16Bit = 16,
        [NativeName("Name", "VK_SAMPLE_COUNT_32_BIT")]
        SampleCount32Bit = 32,
        [NativeName("Name", "VK_SAMPLE_COUNT_64_BIT")]
        SampleCount64Bit = 64,
    }
}
