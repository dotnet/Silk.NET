// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1"]/*'/>
public unsafe partial struct PROPSHEETHEADERA_V1
{
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.hwndParent"]/*'/>
    public HWND hwndParent;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L473_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.pszCaption"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszCaption;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.nPages"]/*'/>
    public uint nPages;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L473_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.Anonymous3"]/*'/>
    [NativeTypeName("__AnonymousRecord_prsht_L473_C5")]
    public _Anonymous3_e__Union Anonymous3;
    /// <include file='PROPSHEETHEADERA_V1.xml' path='doc/member[@name="PROPSHEETHEADERA_V1.pfnCallback"]/*'/>
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
    public ref sbyte* pszIcon
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
    public ref sbyte* pStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pStartPage;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*'/>
    [UnscopedRef]
    public ref PROPSHEETPAGEA* ppsp
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
        [NativeTypeName("LPCSTR")]
        public sbyte* pszIcon;
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
        [NativeTypeName("LPCSTR")]
        public sbyte* pStartPage;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCPROPSHEETPAGEA")]
        public PROPSHEETPAGEA* ppsp;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.phpage"]/*'/>
        [FieldOffset(0)]
        public HPROPSHEETPAGE* phpage;
    }
}