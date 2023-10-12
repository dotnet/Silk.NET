// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkResolveModeFlags")]
    public enum ResolveModeFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_RESOLVE_MODE_NONE")]
        ResolveModeNone = 0,
        [Obsolete("Deprecated in favour of \"SampleZeroBit\"")]
        [NativeName("Name", "VK_RESOLVE_MODE_SAMPLE_ZERO_BIT")]
        ResolveModeSampleZeroBit = 1,
        [Obsolete("Deprecated in favour of \"AverageBit\"")]
        [NativeName("Name", "VK_RESOLVE_MODE_AVERAGE_BIT")]
        ResolveModeAverageBit = 2,
        [Obsolete("Deprecated in favour of \"MinBit\"")]
        [NativeName("Name", "VK_RESOLVE_MODE_MIN_BIT")]
        ResolveModeMinBit = 4,
        [Obsolete("Deprecated in favour of \"MaxBit\"")]
        [NativeName("Name", "VK_RESOLVE_MODE_MAX_BIT")]
        ResolveModeMaxBit = 8,
        [Obsolete("Deprecated in favour of \"ExternalFormatDownsampleAndroid\"")]
        [NativeName("Name", "VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID")]
        ResolveModeExternalFormatDownsampleAndroid = 16,
        [NativeName("Name", "VK_RESOLVE_MODE_NONE")]
        None = 0,
        [NativeName("Name", "VK_RESOLVE_MODE_SAMPLE_ZERO_BIT")]
        SampleZeroBit = 1,
        [NativeName("Name", "VK_RESOLVE_MODE_AVERAGE_BIT")]
        AverageBit = 2,
        [NativeName("Name", "VK_RESOLVE_MODE_MIN_BIT")]
        MinBit = 4,
        [NativeName("Name", "VK_RESOLVE_MODE_MAX_BIT")]
        MaxBit = 8,
        [NativeName("Name", "VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID")]
        ExternalFormatDownsampleAndroid = 16,
    }
}
