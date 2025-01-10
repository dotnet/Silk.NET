// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR
{
    public uint ReconstructedPictureResourceIndex;
    public uint TemporalLayerIndexPlus1;
    public uint SpatialLayerIndexPlus1;
    public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE FrameType;
    public D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO WarpedMotionInfo;
    public uint OrderHint;
    public uint PictureIndex;
}
