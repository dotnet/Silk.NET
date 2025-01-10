// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_DECODE_CONFIGURATION
{
    public Guid DecodeProfile;
    public D3D12_BITSTREAM_ENCRYPTION_TYPE BitstreamEncryption;
    public D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE InterlaceType;
}
