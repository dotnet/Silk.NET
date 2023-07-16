// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA"]/*'/>
public unsafe partial struct TVITEMEXA
{
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.mask"]/*'/>
    public uint mask;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.hItem"]/*'/>
    public HTREEITEM hItem;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.state"]/*'/>
    public uint state;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.stateMask"]/*'/>
    public uint stateMask;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.iImage"]/*'/>
    public int iImage;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.iSelectedImage"]/*'/>
    public int iSelectedImage;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.cChildren"]/*'/>
    public int cChildren;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.iIntegral"]/*'/>
    public int iIntegral;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.uStateEx"]/*'/>
    public uint uStateEx;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.iExpandedImage"]/*'/>
    public int iExpandedImage;
    /// <include file='TVITEMEXA.xml' path='doc/member[@name="TVITEMEXA.iReserved"]/*'/>
    public int iReserved;
}