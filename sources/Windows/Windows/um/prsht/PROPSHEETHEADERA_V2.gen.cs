// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2"]/*' />
public unsafe partial struct PROPSHEETHEADERA_V2
{
    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.hwndParent"]/*' />
    public HWND hwndParent;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_prsht_L479_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.pszCaption"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszCaption;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.nPages"]/*' />
    public uint nPages;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_prsht_L479_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.Anonymous3"]/*' />
    [NativeTypeName("__AnonymousRecord_prsht_L479_C5")]
    public _Anonymous3_e__Union Anonymous3;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.pfnCallback"]/*' />
    [NativeTypeName("PFNPROPSHEETCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, int> pfnCallback;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.Anonymous4"]/*' />
    [NativeTypeName("__AnonymousRecord_prsht_L480_C5")]
    public _Anonymous4_e__Union Anonymous4;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.hplWatermark"]/*' />
    public HPALETTE hplWatermark;

    /// <include file='PROPSHEETHEADERA_V2.xml' path='doc/member[@name="PROPSHEETHEADERA_V2.Anonymous5"]/*' />
    [NativeTypeName("__AnonymousRecord_prsht_L486_C5")]
    public _Anonymous5_e__Union Anonymous5;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hIcon"]/*' />
    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.hIcon;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszIcon"]/*' />
    [UnscopedRef]
    public ref sbyte* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pszIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.nStartPage"]/*' />
    [UnscopedRef]
    public ref uint nStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.nStartPage;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pStartPage"]/*' />
    [UnscopedRef]
    public ref sbyte* pStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pStartPage;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*' />
    [UnscopedRef]
    public ref PROPSHEETPAGEA* ppsp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.ppsp;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.phpage"]/*' />
    [UnscopedRef]
    public ref HPROPSHEETPAGE* phpage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.phpage;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.hbmWatermark"]/*' />
    [UnscopedRef]
    public ref HBITMAP hbmWatermark
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.hbmWatermark;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.pszbmWatermark"]/*' />
    [UnscopedRef]
    public ref sbyte* pszbmWatermark
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.pszbmWatermark;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.hbmHeader"]/*' />
    [UnscopedRef]
    public ref HBITMAP hbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.hbmHeader;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.pszbmHeader"]/*' />
    [UnscopedRef]
    public ref sbyte* pszbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.pszbmHeader;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hIcon"]/*' />
        [FieldOffset(0)]
        public HICON hIcon;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszIcon"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszIcon;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.nStartPage"]/*' />
        [FieldOffset(0)]
        public uint nStartPage;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pStartPage"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pStartPage;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCPROPSHEETPAGEA")]
        public PROPSHEETPAGEA* ppsp;

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.phpage"]/*' />
        [FieldOffset(0)]
        public HPROPSHEETPAGE* phpage;
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous4_e__Union
    {
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.hbmWatermark"]/*' />
        [FieldOffset(0)]
        public HBITMAP hbmWatermark;

        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.pszbmWatermark"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszbmWatermark;
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous5_e__Union
    {
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.hbmHeader"]/*' />
        [FieldOffset(0)]
        public HBITMAP hbmHeader;

        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.pszbmHeader"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszbmHeader;
    }
}
