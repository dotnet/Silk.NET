// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMLVDISPINFOA.xml' path='doc/member[@name="NMLVDISPINFOA"]/*'/>
public partial struct NMLVDISPINFOA
{
    /// <include file='NMLVDISPINFOA.xml' path='doc/member[@name="NMLVDISPINFOA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVDISPINFOA.xml' path='doc/member[@name="NMLVDISPINFOA.item"]/*'/>
    public LVITEMA item;
}