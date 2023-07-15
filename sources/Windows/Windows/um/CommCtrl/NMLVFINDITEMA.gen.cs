// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMLVFINDITEMA.xml' path='doc/member[@name="NMLVFINDITEMA"]/*'/>
public partial struct NMLVFINDITEMA
{
    /// <include file='NMLVFINDITEMA.xml' path='doc/member[@name="NMLVFINDITEMA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVFINDITEMA.xml' path='doc/member[@name="NMLVFINDITEMA.iStart"]/*'/>
    public int iStart;
    /// <include file='NMLVFINDITEMA.xml' path='doc/member[@name="NMLVFINDITEMA.lvfi"]/*'/>
    public LVFINDINFOA lvfi;
}