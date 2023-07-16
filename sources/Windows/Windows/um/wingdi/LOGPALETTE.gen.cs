// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='LOGPALETTE.xml' path='doc/member[@name="LOGPALETTE"]/*'/>
public partial struct LOGPALETTE
{
    /// <include file='LOGPALETTE.xml' path='doc/member[@name="LOGPALETTE.palVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort palVersion;
    /// <include file='LOGPALETTE.xml' path='doc/member[@name="LOGPALETTE.palNumEntries"]/*'/>
    [NativeTypeName("WORD")]
    public ushort palNumEntries;
    /// <include file='LOGPALETTE.xml' path='doc/member[@name="LOGPALETTE.palPalEntry"]/*'/>
    [NativeTypeName("PALETTEENTRY[1]")]
    public _palPalEntry_e__FixedBuffer palPalEntry;
    /// <include file='_palPalEntry_e__FixedBuffer.xml' path='doc/member[@name="_palPalEntry_e__FixedBuffer"]/*'/>
    public partial struct _palPalEntry_e__FixedBuffer
    {
        public PALETTEENTRY e0;
        [UnscopedRef]
        public ref PALETTEENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PALETTEENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}