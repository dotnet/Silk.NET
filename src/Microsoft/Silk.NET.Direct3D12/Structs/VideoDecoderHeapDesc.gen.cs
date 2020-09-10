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
    [NativeName("Name", "D3D12_VIDEO_DECODER_HEAP_DESC")]
    public unsafe partial struct VideoDecoderHeapDesc
    {
        public VideoDecoderHeapDesc
        (
            uint nodeMask = default,
            VideoDecodeConfiguration configuration = default,
            uint decodeWidth = default,
            uint decodeHeight = default,
            Silk.NET.DXGI.Format format = default,
            Silk.NET.DXGI.Rational frameRate = default,
            uint bitRate = default,
            uint maxDecodePictureBufferCount = default
        )
        {
            NodeMask = nodeMask;
            Configuration = configuration;
            DecodeWidth = decodeWidth;
            DecodeHeight = decodeHeight;
            Format = format;
            FrameRate = frameRate;
            BitRate = bitRate;
            MaxDecodePictureBufferCount = maxDecodePictureBufferCount;
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
