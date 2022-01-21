// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
    public enum VideoDecoderBufferType : int
    {
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS")]
        VideoDecoderBufferPictureParameters = 0x0,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL")]
        VideoDecoderBufferMacroblockControl = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE")]
        VideoDecoderBufferResidualDifference = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL")]
        VideoDecoderBufferDeblockingControl = 0x3,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX")]
        VideoDecoderBufferInverseQuantizationMatrix = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL")]
        VideoDecoderBufferSliceControl = 0x5,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_BITSTREAM")]
        VideoDecoderBufferBitstream = 0x6,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR")]
        VideoDecoderBufferMotionVector = 0x7,
        [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN")]
        VideoDecoderBufferFilmGrain = 0x8,
    }
}
