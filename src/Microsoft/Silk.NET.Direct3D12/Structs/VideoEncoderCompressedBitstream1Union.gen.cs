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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L10217_C5")]
    public unsafe partial struct VideoEncoderCompressedBitstream1Union
    {
        public VideoEncoderCompressedBitstream1Union
        (
            VideoEncoderCompressedBitstream? frameOutputBuffer = null,
            VideoEncoderSubregionCompressedBitstream? subregionOutputBuffers = null
        ) : this()
        {
            if (frameOutputBuffer is not null)
            {
                FrameOutputBuffer = frameOutputBuffer.Value;
            }

            if (subregionOutputBuffers is not null)
            {
                SubregionOutputBuffers = subregionOutputBuffers.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM")]
        [NativeName("Name", "FrameOutputBuffer")]
        public VideoEncoderCompressedBitstream FrameOutputBuffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM")]
        [NativeName("Name", "SubregionOutputBuffers")]
        public VideoEncoderSubregionCompressedBitstream SubregionOutputBuffers;
    }
}
