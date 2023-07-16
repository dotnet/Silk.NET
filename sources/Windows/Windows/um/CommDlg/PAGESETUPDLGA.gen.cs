// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA"]/*'/>
public unsafe partial struct PAGESETUPDLGA
{
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.hDevMode"]/*'/>
    public HGLOBAL hDevMode;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.hDevNames"]/*'/>
    public HGLOBAL hDevNames;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.ptPaperSize"]/*'/>
    public POINT ptPaperSize;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.rtMinMargin"]/*'/>
    public RECT rtMinMargin;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.rtMargin"]/*'/>
    public RECT rtMargin;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.lpfnPageSetupHook"]/*'/>
    [NativeTypeName("LPPAGESETUPHOOK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPageSetupHook;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.lpfnPagePaintHook"]/*'/>
    [NativeTypeName("LPPAGEPAINTHOOK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPagePaintHook;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.lpPageSetupTemplateName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpPageSetupTemplateName;
    /// <include file='PAGESETUPDLGA.xml' path='doc/member[@name="PAGESETUPDLGA.hPageSetupTemplate"]/*'/>
    public HGLOBAL hPageSetupTemplate;
}