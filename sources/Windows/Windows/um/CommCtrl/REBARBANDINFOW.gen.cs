// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW"]/*'/>
public unsafe partial struct REBARBANDINFOW
{
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.fMask"]/*'/>
    public uint fMask;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.fStyle"]/*'/>
    public uint fStyle;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.clrFore"]/*'/>
    public COLORREF clrFore;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.clrBack"]/*'/>
    public COLORREF clrBack;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.lpText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpText;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cch"]/*'/>
    public uint cch;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.iImage"]/*'/>
    public int iImage;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.hwndChild"]/*'/>
    public HWND hwndChild;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cxMinChild"]/*'/>
    public uint cxMinChild;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cyMinChild"]/*'/>
    public uint cyMinChild;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cx"]/*'/>
    public uint cx;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.hbmBack"]/*'/>
    public HBITMAP hbmBack;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.wID"]/*'/>
    public uint wID;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cyChild"]/*'/>
    public uint cyChild;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cyMaxChild"]/*'/>
    public uint cyMaxChild;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cyIntegral"]/*'/>
    public uint cyIntegral;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cxIdeal"]/*'/>
    public uint cxIdeal;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.cxHeader"]/*'/>
    public uint cxHeader;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.rcChevronLocation"]/*'/>
    public RECT rcChevronLocation;
    /// <include file='REBARBANDINFOW.xml' path='doc/member[@name="REBARBANDINFOW.uChevronState"]/*'/>
    public uint uChevronState;
}