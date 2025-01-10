// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROPSHEETHEADERW_V1
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HWND hwndParent;
    public HINSTANCE hInstance;

    [NativeTypeName("__AnonymousRecord_prsht_L520_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszCaption;
    public uint nPages;

    [NativeTypeName("__AnonymousRecord_prsht_L520_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("__AnonymousRecord_prsht_L520_C5")]
    public _Anonymous3_e__Union Anonymous3;

    [NativeTypeName("PFNPROPSHEETCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, int> pfnCallback;

    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.hIcon; }
    }

    [UnscopedRef]
    public ref ushort* pszIcon
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
    public ref ushort* pStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pStartPage; }
    }

    [UnscopedRef]
    public ref PROPSHEETPAGEW* ppsp
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

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public HICON hIcon;

        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszIcon;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint nStartPage;

        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pStartPage;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LPCPROPSHEETPAGEW")]
        public PROPSHEETPAGEW* ppsp;

        [FieldOffset(0)]
        public HPROPSHEETPAGE* phpage;
    }
}
