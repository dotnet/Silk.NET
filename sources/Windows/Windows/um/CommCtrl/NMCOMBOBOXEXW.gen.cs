// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMCOMBOBOXEXW.xml' path='doc/member[@name="NMCOMBOBOXEXW"]/*'/>
public partial struct NMCOMBOBOXEXW
{
    /// <include file='NMCOMBOBOXEXW.xml' path='doc/member[@name="NMCOMBOBOXEXW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMCOMBOBOXEXW.xml' path='doc/member[@name="NMCOMBOBOXEXW.ceItem"]/*'/>
    public COMBOBOXEXITEMW ceItem;
}