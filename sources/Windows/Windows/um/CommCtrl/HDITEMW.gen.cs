// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW"]/*'/>
public unsafe partial struct HDITEMW
{
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.mask"]/*'/>
    public uint mask;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.cxy"]/*'/>
    public int cxy;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.hbm"]/*'/>
    public HBITMAP hbm;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.fmt"]/*'/>
    public int fmt;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.iImage"]/*'/>
    public int iImage;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.iOrder"]/*'/>
    public int iOrder;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.type"]/*'/>
    public uint type;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.pvFilter"]/*'/>
    public void* pvFilter;
    /// <include file='HDITEMW.xml' path='doc/member[@name="HDITEMW.state"]/*'/>
    public uint state;
}