// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE")]
    public enum VideoEncoderAV1SegmentationBlockSize : int
    {
        [Obsolete("Deprecated in favour of \"Size4x4\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_4x4")]
        VideoEncoderAV1SegmentationBlockSize4x4 = 0x0,
        [Obsolete("Deprecated in favour of \"Size8x8\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_8x8")]
        VideoEncoderAV1SegmentationBlockSize8x8 = 0x1,
        [Obsolete("Deprecated in favour of \"Size16x16\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_16x16")]
        VideoEncoderAV1SegmentationBlockSize16x16 = 0x2,
        [Obsolete("Deprecated in favour of \"Size32x32\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_32x32")]
        VideoEncoderAV1SegmentationBlockSize32x32 = 0x3,
        [Obsolete("Deprecated in favour of \"Size64x64\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_64x64")]
        VideoEncoderAV1SegmentationBlockSize64x64 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_4x4")]
        Size4x4 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_8x8")]
        Size8x8 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_16x16")]
        Size16x16 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_32x32")]
        Size32x32 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_64x64")]
        Size64x64 = 0x4,
    }
}
