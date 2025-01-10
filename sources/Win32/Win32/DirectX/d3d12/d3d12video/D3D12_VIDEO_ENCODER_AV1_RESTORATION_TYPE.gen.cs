// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE
{
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_DISABLED = 0,
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SWITCHABLE = 1,
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_WIENER = 2,
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SGRPROJ = 3,
}
