// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
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
    public partial struct _FrameArguments_e__FixedBuffer
    {
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e0;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e1;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e2;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e3;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e4;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e5;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e6;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e7;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e8;
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT e9;
        [UnscopedRef]
        public ref D3D12_VIDEO_DECODE_FRAME_ARGUMENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D12_VIDEO_DECODE_FRAME_ARGUMENT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 10);
    }
}