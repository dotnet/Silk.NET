// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA"]/*'/>
public unsafe partial struct TVITEMA
{
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.mask"]/*'/>
    public uint mask;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.hItem"]/*'/>
    public HTREEITEM hItem;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.state"]/*'/>
    public uint state;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.stateMask"]/*'/>
    public uint stateMask;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.iImage"]/*'/>
    public int iImage;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.iSelectedImage"]/*'/>
    public int iSelectedImage;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.cChildren"]/*'/>
    public int cChildren;
    /// <include file='TVITEMA.xml' path='doc/member[@name="TVITEMA.lParam"]/*'/>
    public LPARAM lParam;
}