// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA"]/*' />
public unsafe partial struct PRINTDLGA
{
    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.lStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.hDevMode"]/*' />
    public HGLOBAL hDevMode;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.hDevNames"]/*' />
    public HGLOBAL hDevNames;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.hDC"]/*' />
    public HDC hDC;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.nFromPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nFromPage;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.nToPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nToPage;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.nMinPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nMinPage;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.nMaxPage"]/*' />
    [NativeTypeName("WORD")]
    public ushort nMaxPage;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.nCopies"]/*' />
    [NativeTypeName("WORD")]
    public ushort nCopies;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.lCustData"]/*' />
    public LPARAM lCustData;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.lpfnPrintHook"]/*' />
    [NativeTypeName("LPPRINTHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPrintHook;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.lpfnSetupHook"]/*' />
    [NativeTypeName("LPSETUPHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnSetupHook;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.lpPrintTemplateName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpPrintTemplateName;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.lpSetupTemplateName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpSetupTemplateName;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.hPrintTemplate"]/*' />
    public HGLOBAL hPrintTemplate;

    /// <include file='PRINTDLGA.xml' path='doc/member[@name="PRINTDLGA.hSetupTemplate"]/*' />
    public HGLOBAL hSetupTemplate;
}
