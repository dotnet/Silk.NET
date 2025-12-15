// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE")]
    public enum VideoEncoderInputMapType : int
    {
        [Obsolete("Deprecated in favour of \"QuantizationMatrix\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_QUANTIZATION_MATRIX")]
        VideoEncoderInputMapTypeQuantizationMatrix = 0x0,
        [Obsolete("Deprecated in favour of \"DirtyRegions\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_DIRTY_REGIONS")]
        VideoEncoderInputMapTypeDirtyRegions = 0x1,
        [Obsolete("Deprecated in favour of \"MotionVectors\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_MOTION_VECTORS")]
        VideoEncoderInputMapTypeMotionVectors = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_QUANTIZATION_MATRIX")]
        QuantizationMatrix = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_DIRTY_REGIONS")]
        DirtyRegions = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_MOTION_VECTORS")]
        MotionVectors = 0x2,
    }
}
