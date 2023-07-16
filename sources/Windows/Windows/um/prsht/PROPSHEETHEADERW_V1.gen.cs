// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1"]/*'/>
public unsafe partial struct PROPSHEETHEADERW_V1
{
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.hwndParent"]/*'/>
    public HWND hwndParent;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L520_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.pszCaption"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszCaption;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.nPages"]/*'/>
    public uint nPages;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L520_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.Anonymous3"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L520_C5")]
    public _Anonymous3_e__Union Anonymous3;
    /// <include file='PROPSHEETHEADERW_V1.xml' path='doc/member[@name="PROPSHEETHEADERW_V1.pfnCallback"]/*'/>
    [NativeTypeName("PFNPROPSHEETCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, int> pfnCallback;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hIcon"]/*'/>
    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.hIcon;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszIcon"]/*'/>
    [UnscopedRef]
    public ref ushort* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pszIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.nStartPage"]/*'/>
    [UnscopedRef]
    public ref uint nStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.nStartPage;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pStartPage"]/*'/>
    [UnscopedRef]
    public ref ushort* pStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pStartPage;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*'/>
    [UnscopedRef]
    public ref PROPSHEETPAGEW* ppsp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.ppsp;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.phpage"]/*'/>
    [UnscopedRef]
    public ref HPROPSHEETPAGE* phpage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.phpage;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hIcon"]/*'/>
        [FieldOffset(0)]
        public HICON hIcon;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszIcon"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszIcon;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.nStartPage"]/*'/>
        [FieldOffset(0)]
        public uint nStartPage;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pStartPage"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pStartPage;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCPROPSHEETPAGEW")]
        public PROPSHEETPAGEW* ppsp;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.phpage"]/*'/>
        [FieldOffset(0)]
        public HPROPSHEETPAGE* phpage;
    }
}