// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA"]/*'/>
public unsafe partial struct REBARBANDINFOA
{
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.fMask"]/*'/>
    public uint fMask;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.fStyle"]/*'/>
    public uint fStyle;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.clrFore"]/*'/>
    public COLORREF clrFore;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.clrBack"]/*'/>
    public COLORREF clrBack;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.lpText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpText;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cch"]/*'/>
    public uint cch;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.iImage"]/*'/>
    public int iImage;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.hwndChild"]/*'/>
    public HWND hwndChild;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cxMinChild"]/*'/>
    public uint cxMinChild;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cyMinChild"]/*'/>
    public uint cyMinChild;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cx"]/*'/>
    public uint cx;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.hbmBack"]/*'/>
    public HBITMAP hbmBack;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.wID"]/*'/>
    public uint wID;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cyChild"]/*'/>
    public uint cyChild;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cyMaxChild"]/*'/>
    public uint cyMaxChild;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cyIntegral"]/*'/>
    public uint cyIntegral;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cxIdeal"]/*'/>
    public uint cxIdeal;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.cxHeader"]/*'/>
    public uint cxHeader;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.rcChevronLocation"]/*'/>
    public RECT rcChevronLocation;
    /// <include file='REBARBANDINFOA.xml' path='doc/member[@name="REBARBANDINFOA.uChevronState"]/*'/>
    public uint uChevronState;
}