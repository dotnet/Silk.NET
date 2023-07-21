// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264"]/*' />
public partial struct D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264
{
    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.ReconstructedPictureResourceIndex"]/*' />
    public uint ReconstructedPictureResourceIndex;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.IsLongTermReference"]/*' />
    public BOOL IsLongTermReference;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.LongTermPictureIdx"]/*' />
    public uint LongTermPictureIdx;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.PictureOrderCountNumber"]/*' />
    public uint PictureOrderCountNumber;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.FrameDecodingOrderNumber"]/*' />
    public uint FrameDecodingOrderNumber;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264.TemporalLayerIndex"]/*' />
    public uint TemporalLayerIndex;
}
