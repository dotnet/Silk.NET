// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES
{
    [NativeTypeName("__AnonymousRecord_d3d12video_L7619_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint MaxBytesPerSlice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.MaxBytesPerSlice; }
    }

    [UnscopedRef]
    public ref uint NumberOfCodingUnitsPerSlice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NumberOfCodingUnitsPerSlice; }
    }

    [UnscopedRef]
    public ref uint NumberOfRowsPerSlice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NumberOfRowsPerSlice; }
    }

    [UnscopedRef]
    public ref uint NumberOfSlicesPerFrame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NumberOfSlicesPerFrame; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint MaxBytesPerSlice;

        [FieldOffset(0)]
        public uint NumberOfCodingUnitsPerSlice;

        [FieldOffset(0)]
        public uint NumberOfRowsPerSlice;

        [FieldOffset(0)]
        public uint NumberOfSlicesPerFrame;
    }
}
