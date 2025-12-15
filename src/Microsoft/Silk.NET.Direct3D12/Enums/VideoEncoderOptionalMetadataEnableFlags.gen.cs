// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS")]
    public enum VideoEncoderOptionalMetadataEnableFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_NONE")]
        VideoEncoderOptionalMetadataEnableFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"QPMap\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_QP_MAP")]
        VideoEncoderOptionalMetadataEnableFlagQPMap = 0x1,
        [Obsolete("Deprecated in favour of \"SatdMap\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_SATD_MAP")]
        VideoEncoderOptionalMetadataEnableFlagSatdMap = 0x2,
        [Obsolete("Deprecated in favour of \"RCBitAllocationMap\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_RC_BIT_ALLOCATION_MAP")]
        VideoEncoderOptionalMetadataEnableFlagRCBitAllocationMap = 0x4,
        [Obsolete("Deprecated in favour of \"FramePsnr\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_FRAME_PSNR")]
        VideoEncoderOptionalMetadataEnableFlagFramePsnr = 0x8,
        [Obsolete("Deprecated in favour of \"SubregionsPsnr\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_SUBREGIONS_PSNR")]
        VideoEncoderOptionalMetadataEnableFlagSubregionsPsnr = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_QP_MAP")]
        QPMap = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_SATD_MAP")]
        SatdMap = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_RC_BIT_ALLOCATION_MAP")]
        RCBitAllocationMap = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_FRAME_PSNR")]
        FramePsnr = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAG_SUBREGIONS_PSNR")]
        SubregionsPsnr = 0x10,
    }
}
