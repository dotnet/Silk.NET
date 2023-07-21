// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA"]/*' />
public unsafe partial struct CHOOSEFONTA
{
    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.lStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.hDC"]/*' />
    public HDC hDC;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.lpLogFont"]/*' />
    [NativeTypeName("LPLOGFONTA")]
    public LOGFONTA* lpLogFont;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.iPointSize"]/*' />
    public int iPointSize;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.rgbColors"]/*' />
    public COLORREF rgbColors;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.lCustData"]/*' />
    public LPARAM lCustData;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.lpfnHook"]/*' />
    [NativeTypeName("LPCFHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.lpTemplateName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.lpszStyle"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpszStyle;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.nFontType"]/*' />
    [NativeTypeName("WORD")]
    public ushort nFontType;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.___MISSING_ALIGNMENT__"]/*' />
    [NativeTypeName("WORD")]
    public ushort ___MISSING_ALIGNMENT__;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.nSizeMin"]/*' />
    public int nSizeMin;

    /// <include file='CHOOSEFONTA.xml' path='doc/member[@name="CHOOSEFONTA.nSizeMax"]/*' />
    public int nSizeMax;
}
