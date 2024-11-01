// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAGS")]
    public enum VideoEncoderAV1PostEncodeValuesFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_NONE")]
        VideoEncoderAV1PostEncodeValuesFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Quantization\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_QUANTIZATION")]
        VideoEncoderAV1PostEncodeValuesFlagQuantization = 0x1,
        [Obsolete("Deprecated in favour of \"QuantizationDelta\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_QUANTIZATION_DELTA")]
        VideoEncoderAV1PostEncodeValuesFlagQuantizationDelta = 0x2,
        [Obsolete("Deprecated in favour of \"LoopFilter\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_LOOP_FILTER")]
        VideoEncoderAV1PostEncodeValuesFlagLoopFilter = 0x4,
        [Obsolete("Deprecated in favour of \"LoopFilterDelta\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_LOOP_FILTER_DELTA")]
        VideoEncoderAV1PostEncodeValuesFlagLoopFilterDelta = 0x8,
        [Obsolete("Deprecated in favour of \"CdefData\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_CDEF_DATA")]
        VideoEncoderAV1PostEncodeValuesFlagCdefData = 0x10,
        [Obsolete("Deprecated in favour of \"ContextUpdateTileID\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_CONTEXT_UPDATE_TILE_ID")]
        VideoEncoderAV1PostEncodeValuesFlagContextUpdateTileID = 0x20,
        [Obsolete("Deprecated in favour of \"CompoundPredictionMode\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_COMPOUND_PREDICTION_MODE")]
        VideoEncoderAV1PostEncodeValuesFlagCompoundPredictionMode = 0x40,
        [Obsolete("Deprecated in favour of \"PrimaryRefFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_PRIMARY_REF_FRAME")]
        VideoEncoderAV1PostEncodeValuesFlagPrimaryRefFrame = 0x80,
        [Obsolete("Deprecated in favour of \"ReferenceIndices\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_REFERENCE_INDICES")]
        VideoEncoderAV1PostEncodeValuesFlagReferenceIndices = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_QUANTIZATION")]
        Quantization = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_QUANTIZATION_DELTA")]
        QuantizationDelta = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_LOOP_FILTER")]
        LoopFilter = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_LOOP_FILTER_DELTA")]
        LoopFilterDelta = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_CDEF_DATA")]
        CdefData = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_CONTEXT_UPDATE_TILE_ID")]
        ContextUpdateTileID = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_COMPOUND_PREDICTION_MODE")]
        CompoundPredictionMode = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_PRIMARY_REF_FRAME")]
        PrimaryRefFrame = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAG_REFERENCE_INDICES")]
        ReferenceIndices = 0x100,
    }
}
