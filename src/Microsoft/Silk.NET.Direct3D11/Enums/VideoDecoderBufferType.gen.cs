// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
    public enum VideoDecoderBufferType : int
    {
        [Obsolete("Deprecated in favour of \"PictureParameters\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS")]
        VideoDecoderBufferPictureParameters = 0x0,
        [Obsolete("Deprecated in favour of \"MacroblockControl\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL")]
        VideoDecoderBufferMacroblockControl = 0x1,
        [Obsolete("Deprecated in favour of \"ResidualDifference\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE")]
        VideoDecoderBufferResidualDifference = 0x2,
        [Obsolete("Deprecated in favour of \"DeblockingControl\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL")]
        VideoDecoderBufferDeblockingControl = 0x3,
        [Obsolete("Deprecated in favour of \"InverseQuantizationMatrix\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX")]
        VideoDecoderBufferInverseQuantizationMatrix = 0x4,
        [Obsolete("Deprecated in favour of \"SliceControl\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL")]
        VideoDecoderBufferSliceControl = 0x5,
        [Obsolete("Deprecated in favour of \"Bitstream\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_BITSTREAM")]
        VideoDecoderBufferBitstream = 0x6,
        [Obsolete("Deprecated in favour of \"MotionVector\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR")]
        VideoDecoderBufferMotionVector = 0x7,
        [Obsolete("Deprecated in favour of \"FilmGrain\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN")]
        VideoDecoderBufferFilmGrain = 0x8,
        [Obsolete("Deprecated in favour of \"HuffmanTable\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_HUFFMAN_TABLE")]
        VideoDecoderBufferHuffmanTable = 0x9,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS")]
        PictureParameters = 0x0,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL")]
        MacroblockControl = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE")]
        ResidualDifference = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL")]
        DeblockingControl = 0x3,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX")]
        InverseQuantizationMatrix = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL")]
        SliceControl = 0x5,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_BITSTREAM")]
        Bitstream = 0x6,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR")]
        MotionVector = 0x7,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN")]
        FilmGrain = 0x8,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_HUFFMAN_TABLE")]
        HuffmanTable = 0x9,
    }
}
