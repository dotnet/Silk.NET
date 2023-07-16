// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA"]/*'/>
public unsafe partial struct PRINTDLGEXA
{
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.hDevMode"]/*'/>
    public HGLOBAL hDevMode;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.hDevNames"]/*'/>
    public HGLOBAL hDevNames;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.hDC"]/*'/>
    public HDC hDC;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.Flags2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags2;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.ExclusionFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExclusionFlags;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.nPageRanges"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nPageRanges;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.nMaxPageRanges"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxPageRanges;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.lpPageRanges"]/*'/>
    [NativeTypeName("LPPRINTPAGERANGE")]
    public PRINTPAGERANGE* lpPageRanges;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.nMinPage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMinPage;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.nMaxPage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxPage;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.nCopies"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nCopies;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.lpPrintTemplateName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpPrintTemplateName;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.lpCallback"]/*'/>
    [NativeTypeName("LPUNKNOWN")]
    public IUnknown* lpCallback;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.nPropertyPages"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nPropertyPages;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.lphPropertyPages"]/*'/>
    public HPROPSHEETPAGE* lphPropertyPages;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.nStartPage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nStartPage;
    /// <include file='PRINTDLGEXA.xml' path='doc/member[@name="PRINTDLGEXA.dwResultAction"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwResultAction;
}