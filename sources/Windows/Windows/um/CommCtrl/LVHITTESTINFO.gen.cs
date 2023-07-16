// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LVHITTESTINFO.xml' path='doc/member[@name="LVHITTESTINFO"]/*'/>
public partial struct LVHITTESTINFO
{
    /// <include file='LVHITTESTINFO.xml' path='doc/member[@name="LVHITTESTINFO.pt"]/*'/>
    public POINT pt;
    /// <include file='LVHITTESTINFO.xml' path='doc/member[@name="LVHITTESTINFO.flags"]/*'/>
    public uint flags;
    /// <include file='LVHITTESTINFO.xml' path='doc/member[@name="LVHITTESTINFO.iItem"]/*'/>
    public int iItem;
    /// <include file='LVHITTESTINFO.xml' path='doc/member[@name="LVHITTESTINFO.iSubItem"]/*'/>
    public int iSubItem;
    /// <include file='LVHITTESTINFO.xml' path='doc/member[@name="LVHITTESTINFO.iGroup"]/*'/>
    public int iGroup;
}