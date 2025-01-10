// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_PROCESS_FILTER
{
    D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS = 0,
    D3D12_VIDEO_PROCESS_FILTER_CONTRAST = 1,
    D3D12_VIDEO_PROCESS_FILTER_HUE = 2,
    D3D12_VIDEO_PROCESS_FILTER_SATURATION = 3,
    D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION = 4,
    D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT = 5,
    D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING = 6,
    D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT = 7,
}
