// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW"]/*'/>
public unsafe partial struct PROPSHEETPAGEW
{
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L271_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L271_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.pszTitle"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszTitle;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.pfnDlgProc"]/*'/>
    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> pfnDlgProc;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.pfnCallback"]/*'/>
    [NativeTypeName("LPFNPSPCALLBACKW")]
    public delegate* unmanaged<HWND, uint, PROPSHEETPAGEW*, uint> pfnCallback;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.pcRefParent"]/*'/>
    public uint* pcRefParent;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.pszHeaderTitle"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszHeaderTitle;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.pszHeaderSubTitle"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszHeaderSubTitle;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.hActCtx"]/*'/>
    public HANDLE hActCtx;
    /// <include file='PROPSHEETPAGEW.xml' path='doc/member[@name="PROPSHEETPAGEW.Anonymous3"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L278_C5")]
    public _Anonymous3_e__Union Anonymous3;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*'/>
    [UnscopedRef]
    public ref ushort* pszTemplate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pszTemplate;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*'/>
    [UnscopedRef]
    public ref DLGTEMPLATE* pResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pResource;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*'/>
    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.hIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*'/>
    [UnscopedRef]
    public ref ushort* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pszIcon;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.hbmHeader"]/*'/>
    [UnscopedRef]
    public ref HBITMAP hbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.hbmHeader;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.pszbmHeader"]/*'/>
    [UnscopedRef]
    public ref ushort* pszbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.pszbmHeader;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszTemplate;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
        public DLGTEMPLATE* pResource;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*'/>
        [FieldOffset(0)]
        public HICON hIcon;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszIcon;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.hbmHeader"]/*'/>
        [FieldOffset(0)]
        public HBITMAP hbmHeader;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.pszbmHeader"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszbmHeader;
    }
}