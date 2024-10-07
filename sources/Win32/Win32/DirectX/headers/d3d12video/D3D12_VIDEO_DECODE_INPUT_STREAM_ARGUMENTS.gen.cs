// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS"]/*'/>
public unsafe partial struct D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.NumFrameArguments"]/*'/>

    public uint NumFrameArguments;

    /// <include file='D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.FrameArguments"]/*'/>

    [NativeTypeName("D3D12_VIDEO_DECODE_FRAME_ARGUMENT[10]")]
    public _FrameArguments_e__FixedBuffer FrameArguments;

    /// <include file='D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.ReferenceFrames"]/*'/>

    public D3D12_VIDEO_DECODE_REFERENCE_FRAMES ReferenceFrames;

    /// <include file='D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.CompressedBitstream"]/*'/>

    public D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM CompressedBitstream;

    /// <include file='D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS.pHeap"]/*'/>

    public ID3D12VideoDecoderHeap* pHeap;

    /// <include file='_FrameArguments_e__FixedBuffer.xml' path='doc/member[@name="_FrameArguments_e__FixedBuffer"]/*'/>

    [InlineArray(10)]
    public partial struct _FrameArguments_e__FixedBuffer
    {
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e0;
    }
}
