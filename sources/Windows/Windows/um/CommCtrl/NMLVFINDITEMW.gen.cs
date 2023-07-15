// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMLVFINDITEMW.xml' path='doc/member[@name="NMLVFINDITEMW"]/*'/>
public partial struct NMLVFINDITEMW
{
    /// <include file='NMLVFINDITEMW.xml' path='doc/member[@name="NMLVFINDITEMW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVFINDITEMW.xml' path='doc/member[@name="NMLVFINDITEMW.iStart"]/*'/>
    public int iStart;
    /// <include file='NMLVFINDITEMW.xml' path='doc/member[@name="NMLVFINDITEMW.lvfi"]/*'/>
    public LVFINDINFOW lvfi;
}