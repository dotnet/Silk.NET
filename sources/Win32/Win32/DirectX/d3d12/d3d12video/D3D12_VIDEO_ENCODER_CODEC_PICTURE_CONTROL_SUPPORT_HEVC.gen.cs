// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC
{
    public uint MaxL0ReferencesForP;
    public uint MaxL0ReferencesForB;
    public uint MaxL1ReferencesForB;
    public uint MaxLongTermReferences;
    public uint MaxDPBCapacity;
}
