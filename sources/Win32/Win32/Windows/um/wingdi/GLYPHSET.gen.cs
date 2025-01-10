// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct GLYPHSET
{
    [NativeTypeName("DWORD")]
    public uint cbThis;

    [NativeTypeName("DWORD")]
    public uint flAccel;

    [NativeTypeName("DWORD")]
    public uint cGlyphsSupported;

    [NativeTypeName("DWORD")]
    public uint cRanges;

    [NativeTypeName("WCRANGE[1]")]
    public _ranges_e__FixedBuffer ranges;

    public partial struct _ranges_e__FixedBuffer
    {
        public WCRANGE e0;

        [UnscopedRef]
        public ref WCRANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<WCRANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
