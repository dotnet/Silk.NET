// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES"]/*' />
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12video_L7759_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MaxBytesPerSlice"]/*' />
    [UnscopedRef]
    public ref uint MaxBytesPerSlice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.MaxBytesPerSlice;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfCodingUnitsPerSlice"]/*' />
    [UnscopedRef]
    public ref uint NumberOfCodingUnitsPerSlice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumberOfCodingUnitsPerSlice;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfRowsPerSlice"]/*' />
    [UnscopedRef]
    public ref uint NumberOfRowsPerSlice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumberOfRowsPerSlice;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfSlicesPerFrame"]/*' />
    [UnscopedRef]
    public ref uint NumberOfSlicesPerFrame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumberOfSlicesPerFrame;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MaxBytesPerSlice"]/*' />
        [FieldOffset(0)]
        public uint MaxBytesPerSlice;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfCodingUnitsPerSlice"]/*' />
        [FieldOffset(0)]
        public uint NumberOfCodingUnitsPerSlice;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfRowsPerSlice"]/*' />
        [FieldOffset(0)]
        public uint NumberOfRowsPerSlice;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumberOfSlicesPerFrame"]/*' />
        [FieldOffset(0)]
        public uint NumberOfSlicesPerFrame;
    }
}
