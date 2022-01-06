// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAGS")]
    public enum VideoEncoderValidationFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_NONE")]
        VideoEncoderValidationFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_NOT_SUPPORTED")]
        VideoEncoderValidationFlagCodecNotSupported = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INPUT_FORMAT_NOT_SUPPORTED")]
        VideoEncoderValidationFlagInputFormatNotSupported = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_CONFIGURATION_NOT_SUPPORTED")]
        VideoEncoderValidationFlagCodecConfigurationNotSupported = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_MODE_NOT_SUPPORTED")]
        VideoEncoderValidationFlagRateControlModeNotSupported = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_CONFIGURATION_NOT_SUPPORTED")]
        VideoEncoderValidationFlagRateControlConfigurationNotSupported = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INTRA_REFRESH_MODE_NOT_SUPPORTED")]
        VideoEncoderValidationFlagIntraRefreshModeNotSupported = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_MODE_NOT_SUPPORTED")]
        VideoEncoderValidationFlagSubregionLayoutModeNotSupported = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RESOLUTION_NOT_SUPPORTED_IN_LIST")]
        VideoEncoderValidationFlagResolutionNotSupportedInList = 0x200,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAG_GOP_STRUCTURE_NOT_SUPPORTED")]
        VideoEncoderValidationFlagGopStructureNotSupported = 0x800,
    }
}
