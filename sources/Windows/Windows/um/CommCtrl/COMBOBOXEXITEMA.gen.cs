// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA"]/*'/>
public unsafe partial struct COMBOBOXEXITEMA
{
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.mask"]/*'/>
    public uint mask;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.iItem"]/*'/>
    [NativeTypeName("INT_PTR")]
    public nint iItem;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.iImage"]/*'/>
    public int iImage;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.iSelectedImage"]/*'/>
    public int iSelectedImage;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.iOverlay"]/*'/>
    public int iOverlay;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.iIndent"]/*'/>
    public int iIndent;
    /// <include file='COMBOBOXEXITEMA.xml' path='doc/member[@name="COMBOBOXEXITEMA.lParam"]/*'/>
    public LPARAM lParam;
}