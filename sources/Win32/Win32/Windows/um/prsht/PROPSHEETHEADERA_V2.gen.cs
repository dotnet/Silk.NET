// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROPSHEETHEADERA_V2
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HWND hwndParent;
    public HINSTANCE hInstance;

    [NativeTypeName("__AnonymousRecord_prsht_L479_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("LPCSTR")]
    public sbyte* pszCaption;
    public uint nPages;

    [NativeTypeName("__AnonymousRecord_prsht_L479_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("__AnonymousRecord_prsht_L479_C5")]
    public _Anonymous3_e__Union Anonymous3;

    [NativeTypeName("PFNPROPSHEETCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, int> pfnCallback;

    [NativeTypeName("__AnonymousRecord_prsht_L480_C5")]
    public _Anonymous4_e__Union Anonymous4;
    public HPALETTE hplWatermark;

    [NativeTypeName("__AnonymousRecord_prsht_L486_C5")]
    public _Anonymous5_e__Union Anonymous5;

    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.hIcon; }
    }

    [UnscopedRef]
    public ref sbyte* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.pszIcon; }
    }

    [UnscopedRef]
    public ref uint nStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.nStartPage; }
    }

    [UnscopedRef]
    public ref sbyte* pStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pStartPage; }
    }

    [UnscopedRef]
    public ref PROPSHEETPAGEA* ppsp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.ppsp; }
    }

    [UnscopedRef]
    public ref HPROPSHEETPAGE* phpage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.phpage; }
    }

    [UnscopedRef]
    public ref HBITMAP hbmWatermark
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.hbmWatermark; }
    }

    [UnscopedRef]
    public ref sbyte* pszbmWatermark
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.pszbmWatermark; }
    }

    [UnscopedRef]
    public ref HBITMAP hbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.hbmHeader; }
    }

    [UnscopedRef]
    public ref sbyte* pszbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.pszbmHeader; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public HICON hIcon;

        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszIcon;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint nStartPage;

        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pStartPage;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LPCPROPSHEETPAGEA")]
        public PROPSHEETPAGEA* ppsp;

        [FieldOffset(0)]
        public HPROPSHEETPAGE* phpage;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public HBITMAP hbmWatermark;

        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszbmWatermark;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public HBITMAP hbmHeader;

        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszbmHeader;
    }
}
