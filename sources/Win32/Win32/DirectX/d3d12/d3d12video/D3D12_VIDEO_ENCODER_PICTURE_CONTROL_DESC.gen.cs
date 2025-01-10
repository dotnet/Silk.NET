// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC
{
    public uint IntraRefreshFrameIndex;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA PictureControlCodecData;
    public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES ReferenceFrames;
}
