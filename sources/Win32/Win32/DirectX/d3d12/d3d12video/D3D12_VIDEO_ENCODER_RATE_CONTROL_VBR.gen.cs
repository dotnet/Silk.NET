// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR
{
    public uint InitialQP;
    public uint MinQP;
    public uint MaxQP;

    [NativeTypeName("UINT64")]
    public ulong MaxFrameBitSize;

    [NativeTypeName("UINT64")]
    public ulong TargetAvgBitRate;

    [NativeTypeName("UINT64")]
    public ulong PeakBitRate;

    [NativeTypeName("UINT64")]
    public ulong VBVCapacity;

    [NativeTypeName("UINT64")]
    public ulong InitialVBVFullness;
}
