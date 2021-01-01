// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS")]
    public enum VideoDecodeConfigurationFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_NONE")]
        VideoDecodeConfigurationFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_HEIGHT_ALIGNMENT_MULTIPLE_32_REQUIRED")]
        VideoDecodeConfigurationFlagHeightAlignmentMultiple32Required = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_POST_PROCESSING_SUPPORTED")]
        VideoDecodeConfigurationFlagPostProcessingSupported = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_REFERENCE_ONLY_ALLOCATIONS_REQUIRED")]
        VideoDecodeConfigurationFlagReferenceOnlyAllocationsRequired = 0x4,
        [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAG_ALLOW_RESOLUTION_CHANGE_ON_NON_KEY_FRAME")]
        VideoDecodeConfigurationFlagAllowResolutionChangeOnNonKeyFrame = 0x8,
    }
}
