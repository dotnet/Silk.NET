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
    [NativeName("Name", "D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS")]
    public unsafe partial struct VideoDecodeOutputStreamArguments
    {
        public VideoDecodeOutputStreamArguments
        (
            ID3D12Resource* pOutputTexture2D = default,
            uint outputSubresource = default,
            VideoDecodeConversionArguments conversionArguments = default
        )
        {
            POutputTexture2D = pOutputTexture2D;
            OutputSubresource = outputSubresource;
            ConversionArguments = conversionArguments;
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOutputTexture2D")]
        public ID3D12Resource* POutputTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputSubresource")]
        public uint OutputSubresource;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS")]
        [NativeName("Name", "ConversionArguments")]
        public VideoDecodeConversionArguments ConversionArguments;
    }
}
