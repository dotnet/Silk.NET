// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS"]/*'/>
public unsafe partial struct D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS.pOutputTexture2D"]/*'/>

    public ID3D12Resource* pOutputTexture2D;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS.OutputSubresource"]/*'/>

    public uint OutputSubresource;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS.ConversionArguments"]/*'/>

    public D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS ConversionArguments;
}
