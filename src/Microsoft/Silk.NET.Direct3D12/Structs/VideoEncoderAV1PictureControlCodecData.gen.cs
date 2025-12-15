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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA")]
    public unsafe partial struct VideoEncoderAV1PictureControlCodecData
    {
        public VideoEncoderAV1PictureControlCodecData
        (
            VideoEncoderAV1PictureControlFlags? flags = null,
            VideoEncoderAV1FrameType? frameType = null,
            VideoEncoderAV1CompPredictionType? compoundPredictionType = null,
            VideoEncoderAV1InterpolationFilters? interpolationFilter = null,
            VideoEncoderAV1RestorationConfig? frameRestorationConfig = null,
            VideoEncoderAV1TXMode? txMode = null,
            uint? superResDenominator = null,
            uint? orderHint = null,
            uint? pictureIndex = null,
            uint? temporalLayerIndexPlus1 = null,
            uint? spatialLayerIndexPlus1 = null,
            uint? primaryRefFrame = null,
            uint? refreshFrameFlags = null,
            VideoEncoderCodecAV1LoopFilterConfig? loopFilter = null,
            VideoEncoderCodecAV1LoopFilterDeltaConfig? loopFilterDelta = null,
            VideoEncoderCodecAV1QuantizationConfig? quantization = null,
            VideoEncoderCodecAV1QuantizationDeltaConfig? quantizationDelta = null,
            VideoEncoderAV1CdefConfig? cDEF = null,
            uint? qPMapValuesCount = null,
            short* pRateControlQPMap = null,
            VideoEncoderAV1SegmentationConfig? customSegmentation = null,
            VideoEncoderAV1SegmentationMap? customSegmentsMap = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (frameType is not null)
            {
                FrameType = frameType.Value;
            }

            if (compoundPredictionType is not null)
            {
                CompoundPredictionType = compoundPredictionType.Value;
            }

            if (interpolationFilter is not null)
            {
                InterpolationFilter = interpolationFilter.Value;
            }

            if (frameRestorationConfig is not null)
            {
                FrameRestorationConfig = frameRestorationConfig.Value;
            }

            if (txMode is not null)
            {
                TxMode = txMode.Value;
            }

            if (superResDenominator is not null)
            {
                SuperResDenominator = superResDenominator.Value;
            }

            if (orderHint is not null)
            {
                OrderHint = orderHint.Value;
            }

            if (pictureIndex is not null)
            {
                PictureIndex = pictureIndex.Value;
            }

            if (temporalLayerIndexPlus1 is not null)
            {
                TemporalLayerIndexPlus1 = temporalLayerIndexPlus1.Value;
            }

            if (spatialLayerIndexPlus1 is not null)
            {
                SpatialLayerIndexPlus1 = spatialLayerIndexPlus1.Value;
            }

            if (primaryRefFrame is not null)
            {
                PrimaryRefFrame = primaryRefFrame.Value;
            }

            if (refreshFrameFlags is not null)
            {
                RefreshFrameFlags = refreshFrameFlags.Value;
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

            if (qPMapValuesCount is not null)
            {
                QPMapValuesCount = qPMapValuesCount.Value;
            }

            if (pRateControlQPMap is not null)
            {
                PRateControlQPMap = pRateControlQPMap;
            }

            if (customSegmentation is not null)
            {
                CustomSegmentation = customSegmentation.Value;
            }

            if (customSegmentsMap is not null)
            {
                CustomSegmentsMap = customSegmentsMap.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderAV1PictureControlFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE")]
        [NativeName("Name", "FrameType")]
        public VideoEncoderAV1FrameType FrameType;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE")]
        [NativeName("Name", "CompoundPredictionType")]
        public VideoEncoderAV1CompPredictionType CompoundPredictionType;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS")]
        [NativeName("Name", "InterpolationFilter")]
        public VideoEncoderAV1InterpolationFilters InterpolationFilter;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG")]
        [NativeName("Name", "FrameRestorationConfig")]
        public VideoEncoderAV1RestorationConfig FrameRestorationConfig;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_TX_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE")]
        [NativeName("Name", "TxMode")]
        public VideoEncoderAV1TXMode TxMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SuperResDenominator")]
        public uint SuperResDenominator;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OrderHint")]
        public uint OrderHint;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PictureIndex")]
        public uint PictureIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TemporalLayerIndexPlus1")]
        public uint TemporalLayerIndexPlus1;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SpatialLayerIndexPlus1")]
        public uint SpatialLayerIndexPlus1;
        
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR[8]")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR[8]")]
        [NativeName("Name", "ReferenceFramesReconPictureDescriptors")]
        public ReferenceFramesReconPictureDescriptorsBuffer ReferenceFramesReconPictureDescriptors;

        public struct ReferenceFramesReconPictureDescriptorsBuffer
        {
            public VideoEncoderAV1ReferencePictureDescriptor Element0;
            public VideoEncoderAV1ReferencePictureDescriptor Element1;
            public VideoEncoderAV1ReferencePictureDescriptor Element2;
            public VideoEncoderAV1ReferencePictureDescriptor Element3;
            public VideoEncoderAV1ReferencePictureDescriptor Element4;
            public VideoEncoderAV1ReferencePictureDescriptor Element5;
            public VideoEncoderAV1ReferencePictureDescriptor Element6;
            public VideoEncoderAV1ReferencePictureDescriptor Element7;
            public ref VideoEncoderAV1ReferencePictureDescriptor this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoEncoderAV1ReferencePictureDescriptor* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoEncoderAV1ReferencePictureDescriptor> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }

        [NativeName("Type", "UINT[7]")]
        [NativeName("Type.Name", "UINT[7]")]
        [NativeName("Name", "ReferenceIndices")]
        public fixed uint ReferenceIndices[7];

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrimaryRefFrame")]
        public uint PrimaryRefFrame;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RefreshFrameFlags")]
        public uint RefreshFrameFlags;

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

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "QPMapValuesCount")]
        public uint QPMapValuesCount;

        [NativeName("Type", "INT16 *")]
        [NativeName("Type.Name", "INT16 *")]
        [NativeName("Name", "pRateControlQPMap")]
        public short* PRateControlQPMap;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG")]
        [NativeName("Name", "CustomSegmentation")]
        public VideoEncoderAV1SegmentationConfig CustomSegmentation;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP")]
        [NativeName("Name", "CustomSegmentsMap")]
        public VideoEncoderAV1SegmentationMap CustomSegmentsMap;
    }
}
