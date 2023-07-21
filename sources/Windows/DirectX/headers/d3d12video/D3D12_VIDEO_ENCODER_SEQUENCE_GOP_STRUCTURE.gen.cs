// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE
{
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12video_L6919_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264GroupOfPictures"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264* pH264GroupOfPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pH264GroupOfPictures;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCGroupOfPictures"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC* pHEVCGroupOfPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pHEVCGroupOfPictures;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264GroupOfPictures"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264* pH264GroupOfPictures;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCGroupOfPictures"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC* pHEVCGroupOfPictures;
    }
}
