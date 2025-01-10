// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG
{
    [NativeTypeName("UINT64")]
    public ulong BaseQIndex;

    [NativeTypeName("INT64")]
    public long YDCDeltaQ;

    [NativeTypeName("INT64")]
    public long UDCDeltaQ;

    [NativeTypeName("INT64")]
    public long UACDeltaQ;

    [NativeTypeName("INT64")]
    public long VDCDeltaQ;

    [NativeTypeName("INT64")]
    public long VACDeltaQ;

    [NativeTypeName("UINT64")]
    public ulong UsingQMatrix;

    [NativeTypeName("UINT64")]
    public ulong QMY;

    [NativeTypeName("UINT64")]
    public ulong QMU;

    [NativeTypeName("UINT64")]
    public ulong QMV;
}
