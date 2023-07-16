// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMIPADDRESS.xml' path='doc/member[@name="NMIPADDRESS"]/*'/>
public partial struct NMIPADDRESS
{
    /// <include file='NMIPADDRESS.xml' path='doc/member[@name="NMIPADDRESS.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMIPADDRESS.xml' path='doc/member[@name="NMIPADDRESS.iField"]/*'/>
    public int iField;
    /// <include file='NMIPADDRESS.xml' path='doc/member[@name="NMIPADDRESS.iValue"]/*'/>
    public int iValue;
}