// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1"]/*' />
public unsafe partial struct PROPSHEETPAGEA_V1
{
    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_prsht_L198_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_prsht_L198_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.pszTitle"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszTitle;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.pfnDlgProc"]/*' />
    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> pfnDlgProc;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.pfnCallback"]/*' />
    [NativeTypeName("LPFNPSPCALLBACKA")]
    public delegate* unmanaged<HWND, uint, PROPSHEETPAGEA*, uint> pfnCallback;

    /// <include file='PROPSHEETPAGEA_V1.xml' path='doc/member[@name="PROPSHEETPAGEA_V1.pcRefParent"]/*' />
    public uint* pcRefParent;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*' />
    [UnscopedRef]
    public ref sbyte* pszTemplate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pszTemplate;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*' />
    [UnscopedRef]
    public ref DLGTEMPLATE* pResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pResource;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*' />
    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.hIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*' />
    [UnscopedRef]
    public ref sbyte* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pszIcon;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszTemplate;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
        public DLGTEMPLATE* pResource;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*' />
        [FieldOffset(0)]
        public HICON hIcon;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszIcon;
    }
}
