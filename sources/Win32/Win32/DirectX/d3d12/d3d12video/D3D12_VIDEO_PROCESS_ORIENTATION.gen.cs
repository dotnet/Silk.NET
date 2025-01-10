// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_PROCESS_ORIENTATION
{
    D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT = 0,
    D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL = 1,
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90 = 2,
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL = 3,
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180 = 4,
    D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL = 5,
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270 = 6,
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL = 7,
}
