// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW"]/*'/>
public partial struct NMLISTVIEW
{
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.iItem"]/*'/>
    public int iItem;
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.iSubItem"]/*'/>
    public int iSubItem;
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.uNewState"]/*'/>
    public uint uNewState;
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.uOldState"]/*'/>
    public uint uOldState;
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.uChanged"]/*'/>
    public uint uChanged;
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.ptAction"]/*'/>
    public POINT ptAction;
    /// <include file='NMLISTVIEW.xml' path='doc/member[@name="NMLISTVIEW.lParam"]/*'/>
    public LPARAM lParam;
}