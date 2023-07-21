// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.SequenceControlDesc"]/*' />
    public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC SequenceControlDesc;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.PictureControlDesc"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC PictureControlDesc;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.pInputFrame"]/*' />
    public ID3D12Resource* pInputFrame;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.InputFrameSubresource"]/*' />
    public uint InputFrameSubresource;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.CurrentFrameBitstreamMetadataSize"]/*' />
    public uint CurrentFrameBitstreamMetadataSize;
}
