// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW"]/*'/>
public unsafe partial struct CHOOSEFONTW
{
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.hDC"]/*'/>
    public HDC hDC;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.lpLogFont"]/*'/>
    [NativeTypeName("LPLOGFONTW")]
    public LOGFONTW* lpLogFont;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.iPointSize"]/*'/>
    public int iPointSize;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.rgbColors"]/*'/>
    public COLORREF rgbColors;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.lpfnHook"]/*'/>
    [NativeTypeName("LPCFHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.lpTemplateName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpTemplateName;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.lpszStyle"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszStyle;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.nFontType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nFontType;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.___MISSING_ALIGNMENT__"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ___MISSING_ALIGNMENT__;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.nSizeMin"]/*'/>
    public int nSizeMin;
    /// <include file='CHOOSEFONTW.xml' path='doc/member[@name="CHOOSEFONTW.nSizeMax"]/*'/>
    public int nSizeMax;
}