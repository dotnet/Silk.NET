// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE"]/*' />
public partial struct TTPOLYCURVE
{
    /// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE.wType"]/*' />
    [NativeTypeName("WORD")]
    public ushort wType;

    /// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE.cpfx"]/*' />
    [NativeTypeName("WORD")]
    public ushort cpfx;

    /// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE.apfx"]/*' />
    [NativeTypeName("POINTFX[1]")]
    public _apfx_e__FixedBuffer apfx;

    /// <include file='_apfx_e__FixedBuffer.xml' path='doc/member[@name="_apfx_e__FixedBuffer"]/*' />
    public partial struct _apfx_e__FixedBuffer
    {
        public POINTFX e0;

        [UnscopedRef]
        public ref POINTFX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINTFX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
