// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW"]/*' />
public unsafe partial struct PRINTDLGW
{
    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.lStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.hDevMode"]/*' />
    public HGLOBAL hDevMode;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.hDevNames"]/*' />
    public HGLOBAL hDevNames;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.hDC"]/*' />
    public HDC hDC;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.nFromPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nFromPage;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.nToPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nToPage;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.nMinPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nMinPage;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.nMaxPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nMaxPage;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.nCopies"]/*' />
    [NativeTypeName("WORD")]
    public ushort nCopies;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.lCustData"]/*' />
    public LPARAM lCustData;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.lpfnPrintHook"]/*' />
    [NativeTypeName("LPPRINTHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPrintHook;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.lpfnSetupHook"]/*' />
    [NativeTypeName("LPSETUPHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnSetupHook;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.lpPrintTemplateName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpPrintTemplateName;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.lpSetupTemplateName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpSetupTemplateName;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.hPrintTemplate"]/*' />
    public HGLOBAL hPrintTemplate;

    /// <include file='PRINTDLGW.xml' path='doc/member[@name="PRINTDLGW.hSetupTemplate"]/*' />
    public HGLOBAL hSetupTemplate;
}
