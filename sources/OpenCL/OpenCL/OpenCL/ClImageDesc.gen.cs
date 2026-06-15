// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_image_desc")]
public unsafe partial struct ClImageDesc
{
    [NativeName("image_type")]
    public uint ImageType;

    [NativeName("image_width")]
    public nuint ImageWidth;

    [NativeName("image_height")]
    public nuint ImageHeight;

    [NativeName("image_depth")]
    public nuint ImageDepth;

    [NativeName("image_array_size")]
    public nuint ImageArraySize;

    [NativeName("image_row_pitch")]
    public nuint ImageRowPitch;

    [NativeName("image_slice_pitch")]
    public nuint ImageSlicePitch;

    [NativeName("num_mip_levels")]
    public uint NumMipLevels;

    [NativeName("num_samples")]
    public uint NumSamples;

    [NativeName("Anonymous")]
    public AnonymousEUnion Anonymous;

    [NativeName("buffer")]
    [UnscopedRef]
    public ref _cl_mem* Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Buffer; }
    }

    [NativeName("mem_object")]
    [UnscopedRef]
    public ref _cl_mem* MemObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.MemObject; }
    }

    [NativeName("_Anonymous_e__Union")]
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AnonymousEUnion
    {
        [NativeName("buffer")]
        [FieldOffset(0)]
        public _cl_mem* Buffer;

        [NativeName("mem_object")]
        [FieldOffset(0)]
        public _cl_mem* MemObject;
    }
}
