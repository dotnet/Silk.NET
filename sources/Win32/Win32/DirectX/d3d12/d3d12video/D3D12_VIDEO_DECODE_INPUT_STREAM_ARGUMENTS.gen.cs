// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS
{
    public uint NumFrameArguments;

    [NativeTypeName("D3D12_VIDEO_DECODE_FRAME_ARGUMENT[10]")]
    public _FrameArguments_e__FixedBuffer FrameArguments;
    public D3D12_VIDEO_DECODE_REFERENCE_FRAMES ReferenceFrames;
    public D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM CompressedBitstream;
    public ID3D12VideoDecoderHeap pHeap;

    [InlineArray(10)]
    public partial struct _FrameArguments_e__FixedBuffer
    {
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e0;
    }
}
