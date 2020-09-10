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
    [NativeName("Name", "D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS")]
    public unsafe partial struct VideoDecodeInputStreamArguments
    {
        public VideoDecodeInputStreamArguments
        (
            uint numFrameArguments = default,
            VideoDecodeReferenceFrames referenceFrames = default,
            VideoDecodeCompressedBitstream compressedBitstream = default,
            ID3D12VideoDecoderHeap* pHeap = default
        )
        {
            NumFrameArguments = numFrameArguments;
           FrameArguments_0 = default;
           FrameArguments_1 = default;
           FrameArguments_2 = default;
           FrameArguments_3 = default;
           FrameArguments_4 = default;
           FrameArguments_5 = default;
           FrameArguments_6 = default;
           FrameArguments_7 = default;
           FrameArguments_8 = default;
           FrameArguments_9 = default;
            ReferenceFrames = referenceFrames;
            CompressedBitstream = compressedBitstream;
            PHeap = pHeap;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumFrameArguments")]
        public uint NumFrameArguments;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_0;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_1;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_2;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_3;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_4;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_5;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_6;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_7;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_8;
        
        [NativeName("Type", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT [10]")]
        [NativeName("Name", "FrameArguments")]
        public VideoDecodeFrameArgument FrameArguments_9;

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
