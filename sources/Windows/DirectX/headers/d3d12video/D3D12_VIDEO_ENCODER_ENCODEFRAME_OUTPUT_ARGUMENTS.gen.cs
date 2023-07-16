// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.Bitstream"]/*'/>
    public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM Bitstream;
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.ReconstructedPicture"]/*'/>
    public D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE ReconstructedPicture;
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.EncoderOutputMetadata"]/*'/>
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER EncoderOutputMetadata;
}