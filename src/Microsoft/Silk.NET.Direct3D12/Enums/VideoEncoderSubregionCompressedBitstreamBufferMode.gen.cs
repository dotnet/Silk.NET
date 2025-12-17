// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE")]
    public enum VideoEncoderSubregionCompressedBitstreamBufferMode : int
    {
        [Obsolete("Deprecated in favour of \"ArrayOfBuffers\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE_ARRAY_OF_BUFFERS")]
        VideoEncoderSubregionCompressedBitstreamBufferModeArrayOfBuffers = 0x0,
        [Obsolete("Deprecated in favour of \"SingleBuffer\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE_SINGLE_BUFFER")]
        VideoEncoderSubregionCompressedBitstreamBufferModeSingleBuffer = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE_ARRAY_OF_BUFFERS")]
        ArrayOfBuffers = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE_SINGLE_BUFFER")]
        SingleBuffer = 0x1,
    }
}
