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
    [NativeName("Name", "D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS")]
    public unsafe partial struct VideoDecodeInputStreamArguments
    {
        public VideoDecodeInputStreamArguments
        (
            uint? numFrameArguments = null,
            VideoDecodeReferenceFrames? referenceFrames = null,
            VideoDecodeCompressedBitstream? compressedBitstream = null,
            ID3D12VideoDecoderHeap* pHeap = null
        ) : this()
        {
            if (numFrameArguments is not null)
            {
                NumFrameArguments = numFrameArguments.Value;
            }

            if (referenceFrames is not null)
            {
                ReferenceFrames = referenceFrames.Value;
            }

            if (compressedBitstream is not null)
            {
                CompressedBitstream = compressedBitstream.Value;
            }

            if (pHeap is not null)
            {
                PHeap = pHeap;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumFrameArguments")]
        public uint NumFrameArguments;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT[10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT[10]")]
        [NativeName("Name", "FrameArguments")]
        public FrameArgumentsBuffer FrameArguments;

        public struct FrameArgumentsBuffer
        {
            public VideoDecodeFrameArgument Element0;
            public VideoDecodeFrameArgument Element1;
            public VideoDecodeFrameArgument Element2;
            public VideoDecodeFrameArgument Element3;
            public VideoDecodeFrameArgument Element4;
            public VideoDecodeFrameArgument Element5;
            public VideoDecodeFrameArgument Element6;
            public VideoDecodeFrameArgument Element7;
            public VideoDecodeFrameArgument Element8;
            public VideoDecodeFrameArgument Element9;
            public ref VideoDecodeFrameArgument this[int index]
            {
                get
                {
                    if (index > 9 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoDecodeFrameArgument* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoDecodeFrameArgument> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 10);
#endif
        }


        [NativeName("Type", "D3D12_VIDEO_DECODE_REFERENCE_FRAMES")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_REFERENCE_FRAMES")]
        [NativeName("Name", "ReferenceFrames")]
        public VideoDecodeReferenceFrames ReferenceFrames;

        [NativeName("Type", "D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM")]
        [NativeName("Name", "CompressedBitstream")]
        public VideoDecodeCompressedBitstream CompressedBitstream;

        [NativeName("Type", "ID3D12VideoDecoderHeap *")]
        [NativeName("Type.Name", "ID3D12VideoDecoderHeap *")]
        [NativeName("Name", "pHeap")]
        public ID3D12VideoDecoderHeap* PHeap;
    }
}
