// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX"]/*' />
public partial struct CONSOLE_SCREEN_BUFFER_INFOEX
{
    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.dwSize"]/*' />
    public COORD dwSize;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.dwCursorPosition"]/*' />
    public COORD dwCursorPosition;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.wAttributes"]/*' />
    [NativeTypeName("WORD")]
    public ushort wAttributes;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.srWindow"]/*' />
    public SMALL_RECT srWindow;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.dwMaximumWindowSize"]/*' />
    public COORD dwMaximumWindowSize;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.wPopupAttributes"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPopupAttributes;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.bFullscreenSupported"]/*' />
    public BOOL bFullscreenSupported;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.ColorTable"]/*' />
    [NativeTypeName("COLORREF[16]")]
    public _ColorTable_e__FixedBuffer ColorTable;

    /// <include file='_ColorTable_e__FixedBuffer.xml' path='doc/member[@name="_ColorTable_e__FixedBuffer"]/*' />
    public partial struct _ColorTable_e__FixedBuffer
    {
        public COLORREF e0;
        public COLORREF e1;
        public COLORREF e2;
        public COLORREF e3;
        public COLORREF e4;
        public COLORREF e5;
        public COLORREF e6;
        public COLORREF e7;
        public COLORREF e8;
        public COLORREF e9;
        public COLORREF e10;
        public COLORREF e11;
        public COLORREF e12;
        public COLORREF e13;
        public COLORREF e14;
        public COLORREF e15;

        [UnscopedRef]
        public ref COLORREF this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<COLORREF> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}
