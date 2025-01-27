// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES")]
    public unsafe partial struct VideoEncoderAV1PostEncodeValues
    {
        public VideoEncoderAV1PostEncodeValues
        (
            ulong? compoundPredictionType = null,
            VideoEncoderCodecAV1LoopFilterConfig? loopFilter = null,
            VideoEncoderCodecAV1LoopFilterDeltaConfig? loopFilterDelta = null,
            VideoEncoderCodecAV1QuantizationConfig? quantization = null,
            VideoEncoderCodecAV1QuantizationDeltaConfig? quantizationDelta = null,
            VideoEncoderAV1CdefConfig? cDEF = null,
            VideoEncoderAV1SegmentationConfig? segmentationConfig = null,
            ulong? primaryRefFrame = null
        ) : this()
        {
            if (compoundPredictionType is not null)
            {
                CompoundPredictionType = compoundPredictionType.Value;
            }

            if (loopFilter is not null)
            {
                LoopFilter = loopFilter.Value;
            }

            if (loopFilterDelta is not null)
            {
                LoopFilterDelta = loopFilterDelta.Value;
            }

            if (quantization is not null)
            {
                Quantization = quantization.Value;
            }

            if (quantizationDelta is not null)
            {
                QuantizationDelta = quantizationDelta.Value;
            }

            if (cDEF is not null)
            {
                CDEF = cDEF.Value;
            }

            if (segmentationConfig is not null)
            {
                SegmentationConfig = segmentationConfig.Value;
            }

            if (primaryRefFrame is not null)
            {
                PrimaryRefFrame = primaryRefFrame.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CompoundPredictionType")]
        public ulong CompoundPredictionType;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG")]
        [NativeName("Name", "LoopFilter")]
        public VideoEncoderCodecAV1LoopFilterConfig LoopFilter;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG")]
        [NativeName("Name", "LoopFilterDelta")]
        public VideoEncoderCodecAV1LoopFilterDeltaConfig LoopFilterDelta;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG")]
        [NativeName("Name", "Quantization")]
        public VideoEncoderCodecAV1QuantizationConfig Quantization;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG")]
        [NativeName("Name", "QuantizationDelta")]
        public VideoEncoderCodecAV1QuantizationDeltaConfig QuantizationDelta;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG")]
        [NativeName("Name", "CDEF")]
        public VideoEncoderAV1CdefConfig CDEF;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG")]
        [NativeName("Name", "SegmentationConfig")]
        public VideoEncoderAV1SegmentationConfig SegmentationConfig;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "PrimaryRefFrame")]
        public ulong PrimaryRefFrame;
        [NativeName("Type", "UINT64[7]")]
        [NativeName("Type.Name", "UINT64[7]")]
        [NativeName("Name", "ReferenceIndices")]
        public fixed ulong ReferenceIndices[7];
    }
}
