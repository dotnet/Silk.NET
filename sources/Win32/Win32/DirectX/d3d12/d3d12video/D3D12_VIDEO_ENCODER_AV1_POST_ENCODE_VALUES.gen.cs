// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES
{
    [NativeTypeName("UINT64")]
    public ulong CompoundPredictionType;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG LoopFilter;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG LoopFilterDelta;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG Quantization;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG QuantizationDelta;
    public D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG CDEF;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG SegmentationConfig;

    [NativeTypeName("UINT64")]
    public ulong PrimaryRefFrame;

    [NativeTypeName("UINT64[7]")]
    public _ReferenceIndices_e__FixedBuffer ReferenceIndices;

    [InlineArray(7)]
    public partial struct _ReferenceIndices_e__FixedBuffer
    {
        public ulong e0;
    }
}
