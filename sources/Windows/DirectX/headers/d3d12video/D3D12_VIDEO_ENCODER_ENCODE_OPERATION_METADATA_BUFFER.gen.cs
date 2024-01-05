// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER"]/*'/>
public unsafe partial struct D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.pBuffer"]/*'/>

    public ID3D12Resource* pBuffer;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.Offset"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong Offset;
}
