// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMHEADERA.xml' path='doc/member[@name="NMHEADERA"]/*'/>
public unsafe partial struct NMHEADERA
{
    /// <include file='NMHEADERA.xml' path='doc/member[@name="NMHEADERA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMHEADERA.xml' path='doc/member[@name="NMHEADERA.iItem"]/*'/>
    public int iItem;
    /// <include file='NMHEADERA.xml' path='doc/member[@name="NMHEADERA.iButton"]/*'/>
    public int iButton;
    /// <include file='NMHEADERA.xml' path='doc/member[@name="NMHEADERA.pitem"]/*'/>
    public HDITEMA* pitem;
}