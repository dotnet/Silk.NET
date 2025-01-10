// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROPSHEETPAGEW_V1
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HINSTANCE hInstance;

    [NativeTypeName("__AnonymousRecord_prsht_L244_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_prsht_L244_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszTitle;

    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> pfnDlgProc;
    public LPARAM lParam;

    [NativeTypeName("LPFNPSPCALLBACKW")]
    public delegate* unmanaged<HWND, uint, PROPSHEETPAGEW*, uint> pfnCallback;
    public uint* pcRefParent;

    [UnscopedRef]
    public ref ushort* pszTemplate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.pszTemplate; }
    }

    [UnscopedRef]
    public ref DLGTEMPLATE* pResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.pResource; }
    }

    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.hIcon; }
    }

    [UnscopedRef]
    public ref ushort* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pszIcon; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszTemplate;

        [FieldOffset(0)]
        [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
        public DLGTEMPLATE* pResource;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public HICON hIcon;

        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszIcon;
    }
}
