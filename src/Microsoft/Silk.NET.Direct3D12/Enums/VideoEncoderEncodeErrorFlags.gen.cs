// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS")]
    public enum VideoEncoderEncodeErrorFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_NO_ERROR")]
        VideoEncoderEncodeErrorFlagNoError = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_CODEC_PICTURE_CONTROL_NOT_SUPPORTED")]
        VideoEncoderEncodeErrorFlagCodecPictureControlNotSupported = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_SUBREGION_LAYOUT_CONFIGURATION_NOT_SUPPORTED")]
        VideoEncoderEncodeErrorFlagSubregionLayoutConfigurationNotSupported = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_REFERENCE_PICTURES")]
        VideoEncoderEncodeErrorFlagInvalidReferencePictures = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_RECONFIGURATION_REQUEST_NOT_SUPPORTED")]
        VideoEncoderEncodeErrorFlagReconfigurationRequestNotSupported = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_METADATA_BUFFER_SOURCE")]
        VideoEncoderEncodeErrorFlagInvalidMetadataBufferSource = 0x10,
    }
}
