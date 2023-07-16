// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMLVSCROLL.xml' path='doc/member[@name="NMLVSCROLL"]/*'/>
public partial struct NMLVSCROLL
{
    /// <include file='NMLVSCROLL.xml' path='doc/member[@name="NMLVSCROLL.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVSCROLL.xml' path='doc/member[@name="NMLVSCROLL.dx"]/*'/>
    public int dx;
    /// <include file='NMLVSCROLL.xml' path='doc/member[@name="NMLVSCROLL.dy"]/*'/>
    public int dy;
}