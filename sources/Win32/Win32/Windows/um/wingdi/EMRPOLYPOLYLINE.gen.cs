// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EMRPOLYPOLYLINE
{
    public EMR emr;
    public RECTL rclBounds;

    [NativeTypeName("DWORD")]
    public uint nPolys;

    [NativeTypeName("DWORD")]
    public uint cptl;

    [NativeTypeName("DWORD[1]")]
    public _aPolyCounts_e__FixedBuffer aPolyCounts;

    [NativeTypeName("POINTL[1]")]
    public _aptl_e__FixedBuffer aptl;

    public partial struct _aPolyCounts_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }

    public partial struct _aptl_e__FixedBuffer
    {
        public POINTL e0;

        [UnscopedRef]
        public ref POINTL this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINTL> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
