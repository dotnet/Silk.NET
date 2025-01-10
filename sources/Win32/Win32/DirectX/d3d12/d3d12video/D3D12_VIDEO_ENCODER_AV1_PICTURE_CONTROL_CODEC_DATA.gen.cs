// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA
{
    public D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE FrameType;
    public D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE CompoundPredictionType;
    public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS InterpolationFilter;
    public D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG FrameRestorationConfig;
    public D3D12_VIDEO_ENCODER_AV1_TX_MODE TxMode;
    public uint SuperResDenominator;
    public uint OrderHint;
    public uint PictureIndex;
    public uint TemporalLayerIndexPlus1;
    public uint SpatialLayerIndexPlus1;

    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR[8]")]
    public _ReferenceFramesReconPictureDescriptors_e__FixedBuffer ReferenceFramesReconPictureDescriptors;

    [NativeTypeName("UINT[7]")]
    public _ReferenceIndices_e__FixedBuffer ReferenceIndices;
    public uint PrimaryRefFrame;
    public uint RefreshFrameFlags;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG LoopFilter;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG LoopFilterDelta;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG Quantization;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG QuantizationDelta;
    public D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG CDEF;
    public uint QPMapValuesCount;

    [NativeTypeName("INT16 *")]
    public short* pRateControlQPMap;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG CustomSegmentation;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP CustomSegmentsMap;

    [InlineArray(8)]
    public partial struct _ReferenceFramesReconPictureDescriptors_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR e0;
    }

    [InlineArray(7)]
    public partial struct _ReferenceIndices_e__FixedBuffer
    {
        public uint e0;
    }
}
