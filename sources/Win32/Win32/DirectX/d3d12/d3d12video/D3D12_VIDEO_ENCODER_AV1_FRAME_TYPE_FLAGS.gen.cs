// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using static Silk.NET.DirectX.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS
{
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_NONE = 0,
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_KEY_FRAME =
        (1 << D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_KEY_FRAME),
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTER_FRAME =
        (1 << D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTER_FRAME),
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTRA_ONLY_FRAME =
        (1 << D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTRA_ONLY_FRAME),
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_SWITCH_FRAME =
        (1 << D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_SWITCH_FRAME),
}
