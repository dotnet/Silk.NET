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
    [NativeName("Name", "D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS")]
    public unsafe partial struct VideoDecodeOutputStreamArguments
    {
        public VideoDecodeOutputStreamArguments
        (
            ID3D12Resource* pOutputTexture2D = null,
            uint? outputSubresource = null,
            VideoDecodeConversionArguments? conversionArguments = null
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

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS")]
        [NativeName("Name", "ConversionArguments")]
        public VideoDecodeConversionArguments ConversionArguments;
    }
}
