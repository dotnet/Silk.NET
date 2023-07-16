// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET"]/*'/>
public partial struct GLYPHSET
{
    /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.cbThis"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbThis;
    /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.flAccel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint flAccel;
    /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.cGlyphsSupported"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cGlyphsSupported;
    /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.cRanges"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cRanges;
    /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.ranges"]/*'/>
    [NativeTypeName("WCRANGE[1]")]
    public _ranges_e__FixedBuffer ranges;
    /// <include file='_ranges_e__FixedBuffer.xml' path='doc/member[@name="_ranges_e__FixedBuffer"]/*'/>
    public partial struct _ranges_e__FixedBuffer
    {
        public WCRANGE e0;
        [UnscopedRef]
        public ref WCRANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<WCRANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}