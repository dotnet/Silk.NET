// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW"]/*'/>
public unsafe partial struct PAGESETUPDLGW
{
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.hDevMode"]/*'/>
    public HGLOBAL hDevMode;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.hDevNames"]/*'/>
    public HGLOBAL hDevNames;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.ptPaperSize"]/*'/>
    public POINT ptPaperSize;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.rtMinMargin"]/*'/>
    public RECT rtMinMargin;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.rtMargin"]/*'/>
    public RECT rtMargin;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.lpfnPageSetupHook"]/*'/>
    [NativeTypeName("LPPAGESETUPHOOK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPageSetupHook;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.lpfnPagePaintHook"]/*'/>
    [NativeTypeName("LPPAGEPAINTHOOK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPagePaintHook;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.lpPageSetupTemplateName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpPageSetupTemplateName;
    /// <include file='PAGESETUPDLGW.xml' path='doc/member[@name="PAGESETUPDLGW.hPageSetupTemplate"]/*'/>
    public HGLOBAL hPageSetupTemplate;
}