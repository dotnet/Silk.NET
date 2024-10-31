// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS")]
    public enum VideoDecodeConfigurationFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_NONE")]
        VideoDecodeConfigurationFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"HeightAlignmentMultiple32Required\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_HEIGHT_ALIGNMENT_MULTIPLE_32_REQUIRED")]
        VideoDecodeConfigurationFlagHeightAlignmentMultiple32Required = 0x1,
        [Obsolete("Deprecated in favour of \"PostProcessingSupported\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_POST_PROCESSING_SUPPORTED")]
        VideoDecodeConfigurationFlagPostProcessingSupported = 0x2,
        [Obsolete("Deprecated in favour of \"ReferenceOnlyAllocationsRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_REFERENCE_ONLY_ALLOCATIONS_REQUIRED")]
        VideoDecodeConfigurationFlagReferenceOnlyAllocationsRequired = 0x4,
        [Obsolete("Deprecated in favour of \"AllowResolutionChangeOnNonKeyFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_ALLOW_RESOLUTION_CHANGE_ON_NON_KEY_FRAME")]
        VideoDecodeConfigurationFlagAllowResolutionChangeOnNonKeyFrame = 0x8,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_HEIGHT_ALIGNMENT_MULTIPLE_32_REQUIRED")]
        HeightAlignmentMultiple32Required = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_POST_PROCESSING_SUPPORTED")]
        PostProcessingSupported = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_REFERENCE_ONLY_ALLOCATIONS_REQUIRED")]
        ReferenceOnlyAllocationsRequired = 0x4,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_ALLOW_RESOLUTION_CHANGE_ON_NON_KEY_FRAME")]
        AllowResolutionChangeOnNonKeyFrame = 0x8,
    }
}
