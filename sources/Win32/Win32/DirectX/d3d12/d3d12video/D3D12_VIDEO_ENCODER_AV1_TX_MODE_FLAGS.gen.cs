// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using static Silk.NET.DirectX.D3D12_VIDEO_ENCODER_AV1_TX_MODE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS
{
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_NONE = 0,
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_ONLY4x4 = (1 << D3D12_VIDEO_ENCODER_AV1_TX_MODE_ONLY4x4),
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_LARGEST = (1 << D3D12_VIDEO_ENCODER_AV1_TX_MODE_LARGEST),
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_SELECT = (1 << D3D12_VIDEO_ENCODER_AV1_TX_MODE_SELECT),
}
