// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_ENCODER_PROFILE_HEVC
{
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN = 0,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10 = 1,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12 = 2,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_422 = 3,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_422 = 4,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN_444 = 5,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_444 = 6,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_444 = 7,
    D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN16_444 = 8,
}
