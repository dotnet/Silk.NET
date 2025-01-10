// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EMRGRADIENTFILL
{
    public EMR emr;
    public RECTL rclBounds;

    [NativeTypeName("DWORD")]
    public uint nVer;

    [NativeTypeName("DWORD")]
    public uint nTri;

    [NativeTypeName("ULONG")]
    public uint ulMode;

    [NativeTypeName("TRIVERTEX[1]")]
    public _Ver_e__FixedBuffer Ver;

    public partial struct _Ver_e__FixedBuffer
    {
        public TRIVERTEX e0;

        [UnscopedRef]
        public ref TRIVERTEX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<TRIVERTEX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
