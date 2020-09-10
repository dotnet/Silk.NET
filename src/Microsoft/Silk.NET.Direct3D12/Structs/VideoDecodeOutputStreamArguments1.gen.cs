// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            ID3D12Resource* pOutputTexture2D = default,
            uint outputSubresource = default,
            VideoDecodeConversionArguments1 conversionArguments = default
        )
        {
            POutputTexture2D = pOutputTexture2D;
            OutputSubresource = outputSubresource;
            ConversionArguments = conversionArguments;
           Histograms_0 = default;
           Histograms_1 = default;
           Histograms_2 = default;
           Histograms_3 = default;
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
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Name", "Histograms")]
        public VideoDecodeOutputHistogram Histograms_0;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Name", "Histograms")]
        public VideoDecodeOutputHistogram Histograms_1;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Name", "Histograms")]
        public VideoDecodeOutputHistogram Histograms_2;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM [4]")]
        [NativeName("Name", "Histograms")]
        public VideoDecodeOutputHistogram Histograms_3;
    }
}
