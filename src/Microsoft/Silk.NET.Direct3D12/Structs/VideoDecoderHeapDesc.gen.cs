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
    [NativeName("Name", "D3D12_VIDEO_DECODER_HEAP_DESC")]
    public unsafe partial struct VideoDecoderHeapDesc
    {
        public VideoDecoderHeapDesc
        (
            uint? nodeMask = null,
            VideoDecodeConfiguration? configuration = null,
            uint? decodeWidth = null,
            uint? decodeHeight = null,
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.DXGI.Rational? frameRate = null,
            uint? bitRate = null,
            uint? maxDecodePictureBufferCount = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (configuration is not null)
            {
                Configuration = configuration.Value;
            }

            if (decodeWidth is not null)
            {
                DecodeWidth = decodeWidth.Value;
            }

            if (decodeHeight is not null)
            {
                DecodeHeight = decodeHeight.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (bitRate is not null)
            {
                BitRate = bitRate.Value;
            }

            if (maxDecodePictureBufferCount is not null)
            {
                MaxDecodePictureBufferCount = maxDecodePictureBufferCount.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Name", "Configuration")]
        public VideoDecodeConfiguration Configuration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DecodeWidth")]
        public uint DecodeWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DecodeHeight")]
        public uint DecodeHeight;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "FrameRate")]
        public Silk.NET.DXGI.Rational FrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BitRate")]
        public uint BitRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxDecodePictureBufferCount")]
        public uint MaxDecodePictureBufferCount;
    }
}
