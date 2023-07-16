// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW"]/*'/>
public unsafe partial struct COMBOBOXEXITEMW
{
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.mask"]/*'/>
    public uint mask;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.iItem"]/*'/>
    [NativeTypeName("INT_PTR")]
    public nint iItem;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.iImage"]/*'/>
    public int iImage;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.iSelectedImage"]/*'/>
    public int iSelectedImage;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.iOverlay"]/*'/>
    public int iOverlay;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.iIndent"]/*'/>
    public int iIndent;
    /// <include file='COMBOBOXEXITEMW.xml' path='doc/member[@name="COMBOBOXEXITEMW.lParam"]/*'/>
    public LPARAM lParam;
}