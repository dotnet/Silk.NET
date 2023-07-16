// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB"]/*'/>
public unsafe partial struct BANDINFOSFB
{
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.dwStateMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStateMask;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.dwState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwState;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.crBkgnd"]/*'/>
    public COLORREF crBkgnd;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.crBtnLt"]/*'/>
    public COLORREF crBtnLt;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.crBtnDk"]/*'/>
    public COLORREF crBtnDk;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.wViewMode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wViewMode;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.wAlign"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wAlign;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.psf"]/*'/>
    public IShellFolder* psf;
    /// <include file='BANDINFOSFB.xml' path='doc/member[@name="BANDINFOSFB.pidl"]/*'/>
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidl;
}