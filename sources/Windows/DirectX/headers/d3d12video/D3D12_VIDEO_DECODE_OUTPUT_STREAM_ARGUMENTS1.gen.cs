// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1"]/*'/>
public unsafe partial struct D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1
{
    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.pOutputTexture2D"]/*'/>

    public ID3D12Resource* pOutputTexture2D;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.OutputSubresource"]/*'/>

    public uint OutputSubresource;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.ConversionArguments"]/*'/>

    public D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1 ConversionArguments;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.Histograms"]/*'/>

    [NativeTypeName("D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM[4]")]
    public _Histograms_e__FixedBuffer Histograms;

    /// <include file='_Histograms_e__FixedBuffer.xml' path='doc/member[@name="_Histograms_e__FixedBuffer"]/*'/>

    [InlineArray(4)]
    public partial struct _Histograms_e__FixedBuffer
    {
        public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e0;
    }
}
