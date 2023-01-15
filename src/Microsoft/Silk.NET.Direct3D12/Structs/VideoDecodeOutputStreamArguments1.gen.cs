// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1")]
    public unsafe partial struct VideoDecodeOutputStreamArguments1
    {
        public VideoDecodeOutputStreamArguments1
        (
            ID3D12Resource* pOutputTexture2D = null,
            uint? outputSubresource = null,
            VideoDecodeConversionArguments1? conversionArguments = null
        ) : this()
        {
            if (pOutputTexture2D is not null)
            {
                POutputTexture2D = pOutputTexture2D;
            }

            if (outputSubresource is not null)
            {
                OutputSubresource = outputSubresource.Value;
            }

            if (conversionArguments is not null)
            {
                ConversionArguments = conversionArguments.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOutputTexture2D")]
        public ID3D12Resource* POutputTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputSubresource")]
        public uint OutputSubresource;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1")]
        [NativeName("Name", "ConversionArguments")]
        public VideoDecodeConversionArguments1 ConversionArguments;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM[4]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM[4]")]
        [NativeName("Name", "Histograms")]
        public HistogramsBuffer Histograms;

        public struct HistogramsBuffer
        {
            public VideoDecodeOutputHistogram Element0;
            public VideoDecodeOutputHistogram Element1;
            public VideoDecodeOutputHistogram Element2;
            public VideoDecodeOutputHistogram Element3;
            public ref VideoDecodeOutputHistogram this[int index]
            {
                get
                {
                    if (index > 3 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoDecodeOutputHistogram* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoDecodeOutputHistogram> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 4);
#endif
        }

    }
}
