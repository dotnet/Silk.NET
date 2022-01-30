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
