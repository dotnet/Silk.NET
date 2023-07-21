// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1
{
    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.pOutputTexture2D"]/*' />
    public ID3D12Resource* pOutputTexture2D;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.OutputSubresource"]/*' />
    public uint OutputSubresource;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.ConversionArguments"]/*' />
    public D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1 ConversionArguments;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1.Histograms"]/*' />
    [NativeTypeName("D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM[4]")]
    public _Histograms_e__FixedBuffer Histograms;

    /// <include file='_Histograms_e__FixedBuffer.xml' path='doc/member[@name="_Histograms_e__FixedBuffer"]/*' />
    public partial struct _Histograms_e__FixedBuffer
    {
        public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e0;
        public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e1;
        public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e2;
        public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM e3;

        [UnscopedRef]
        public ref D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
    }
}
