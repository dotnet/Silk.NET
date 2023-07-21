// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW"]/*' />
public unsafe partial struct PRINTDLGEXW
{
    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.lStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.hDevMode"]/*' />
    public HGLOBAL hDevMode;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.hDevNames"]/*' />
    public HGLOBAL hDevNames;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.hDC"]/*' />
    public HDC hDC;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.Flags2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags2;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.ExclusionFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExclusionFlags;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.nPageRanges"]/*' />
    [NativeTypeName("DWORD")]
    public uint nPageRanges;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.nMaxPageRanges"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxPageRanges;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.lpPageRanges"]/*' />
    [NativeTypeName("LPPRINTPAGERANGE")]
    public PRINTPAGERANGE* lpPageRanges;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.nMinPage"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMinPage;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.nMaxPage"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxPage;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.nCopies"]/*' />
    [NativeTypeName("DWORD")]
    public uint nCopies;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.lpPrintTemplateName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpPrintTemplateName;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.lpCallback"]/*' />
    [NativeTypeName("LPUNKNOWN")]
    public IUnknown* lpCallback;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.nPropertyPages"]/*' />
    [NativeTypeName("DWORD")]
    public uint nPropertyPages;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.lphPropertyPages"]/*' />
    public HPROPSHEETPAGE* lphPropertyPages;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.nStartPage"]/*' />
    [NativeTypeName("DWORD")]
    public uint nStartPage;

    /// <include file='PRINTDLGEXW.xml' path='doc/member[@name="PRINTDLGEXW.dwResultAction"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwResultAction;
}
