// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW"]/*'/>
public unsafe partial struct TVITEMW
{
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.mask"]/*'/>
    public uint mask;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.hItem"]/*'/>
    public HTREEITEM hItem;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.state"]/*'/>
    public uint state;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.stateMask"]/*'/>
    public uint stateMask;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.iImage"]/*'/>
    public int iImage;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.iSelectedImage"]/*'/>
    public int iSelectedImage;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.cChildren"]/*'/>
    public int cChildren;
    /// <include file='TVITEMW.xml' path='doc/member[@name="TVITEMW.lParam"]/*'/>
    public LPARAM lParam;
}