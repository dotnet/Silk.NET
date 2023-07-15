// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMTREEVIEWW.xml' path='doc/member[@name="NMTREEVIEWW"]/*'/>
public partial struct NMTREEVIEWW
{
    /// <include file='NMTREEVIEWW.xml' path='doc/member[@name="NMTREEVIEWW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTREEVIEWW.xml' path='doc/member[@name="NMTREEVIEWW.action"]/*'/>
    public uint action;
    /// <include file='NMTREEVIEWW.xml' path='doc/member[@name="NMTREEVIEWW.itemOld"]/*'/>
    public TVITEMW itemOld;
    /// <include file='NMTREEVIEWW.xml' path='doc/member[@name="NMTREEVIEWW.itemNew"]/*'/>
    public TVITEMW itemNew;
    /// <include file='NMTREEVIEWW.xml' path='doc/member[@name="NMTREEVIEWW.ptDrag"]/*'/>
    public POINT ptDrag;
}