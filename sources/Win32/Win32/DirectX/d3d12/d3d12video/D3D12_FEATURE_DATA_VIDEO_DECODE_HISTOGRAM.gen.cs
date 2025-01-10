// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM
{
    public uint NodeIndex;
    public Guid DecodeProfile;
    public uint Width;
    public uint Height;
    public DXGI_FORMAT DecodeFormat;
    public D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS Components;
    public uint BinCount;
    public uint CounterBitDepth;
}
