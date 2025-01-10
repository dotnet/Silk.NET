// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_DECODE_STATUS
{
    D3D12_VIDEO_DECODE_STATUS_OK = 0,
    D3D12_VIDEO_DECODE_STATUS_CONTINUE = 1,
    D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY = 2,
    D3D12_VIDEO_DECODE_STATUS_RESTART = 3,
    D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED = 4,
}
