// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC
{
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_I_FRAME = 0,
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_P_FRAME = 1,
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_B_FRAME = 2,
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_IDR_FRAME = 3,
}
