// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE
{
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_DISABLED = 0,
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_32x32 = 1,
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_64x64 = 2,
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_128x128 = 3,
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_256x256 = 4,
}
