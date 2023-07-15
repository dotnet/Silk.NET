// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW"]/*'/>
public unsafe partial struct LVITEMW
{
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.mask"]/*'/>
    public uint mask;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.iItem"]/*'/>
    public int iItem;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.iSubItem"]/*'/>
    public int iSubItem;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.state"]/*'/>
    public uint state;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.stateMask"]/*'/>
    public uint stateMask;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.iImage"]/*'/>
    public int iImage;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.iIndent"]/*'/>
    public int iIndent;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.iGroupId"]/*'/>
    public int iGroupId;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.cColumns"]/*'/>
    public uint cColumns;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.puColumns"]/*'/>
    [NativeTypeName("PUINT")]
    public uint* puColumns;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.piColFmt"]/*'/>
    public int* piColFmt;
    /// <include file='LVITEMW.xml' path='doc/member[@name="LVITEMW.iGroup"]/*'/>
    public int iGroup;
}