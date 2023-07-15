// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_OUTPUT_METADATA
{
    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA.EncodeErrorFlags"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong EncodeErrorFlags;
    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA.EncodeStats"]/*'/>
    public D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS EncodeStats;
    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA.EncodedBitstreamWrittenBytesCount"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong EncodedBitstreamWrittenBytesCount;
    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA.WrittenSubregionsCount"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong WrittenSubregionsCount;
}