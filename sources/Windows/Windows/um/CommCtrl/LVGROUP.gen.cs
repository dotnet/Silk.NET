// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP"]/*'/>
public unsafe partial struct LVGROUP
{
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.mask"]/*'/>
    public uint mask;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.pszHeader"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszHeader;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cchHeader"]/*'/>
    public int cchHeader;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.pszFooter"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszFooter;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cchFooter"]/*'/>
    public int cchFooter;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.iGroupId"]/*'/>
    public int iGroupId;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.stateMask"]/*'/>
    public uint stateMask;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.state"]/*'/>
    public uint state;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.uAlign"]/*'/>
    public uint uAlign;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.pszSubtitle"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszSubtitle;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cchSubtitle"]/*'/>
    public uint cchSubtitle;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.pszTask"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszTask;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cchTask"]/*'/>
    public uint cchTask;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.pszDescriptionTop"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszDescriptionTop;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cchDescriptionTop"]/*'/>
    public uint cchDescriptionTop;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.pszDescriptionBottom"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszDescriptionBottom;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cchDescriptionBottom"]/*'/>
    public uint cchDescriptionBottom;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.iTitleImage"]/*'/>
    public int iTitleImage;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.iExtendedImage"]/*'/>
    public int iExtendedImage;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.iFirstItem"]/*'/>
    public int iFirstItem;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cItems"]/*'/>
    public uint cItems;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.pszSubsetTitle"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszSubsetTitle;
    /// <include file='LVGROUP.xml' path='doc/member[@name="LVGROUP.cchSubsetTitle"]/*'/>
    public uint cchSubsetTitle;
}