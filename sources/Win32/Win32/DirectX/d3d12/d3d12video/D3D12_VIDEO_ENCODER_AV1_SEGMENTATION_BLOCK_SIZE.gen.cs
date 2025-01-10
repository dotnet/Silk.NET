// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE
{
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_4x4 = 0,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_8x8 = 1,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_16x16 = 2,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_32x32 = 3,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_64x64 = 4,
}
