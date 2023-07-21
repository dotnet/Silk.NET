// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMUPDOWN.xml' path='doc/member[@name="NMUPDOWN"]/*' />
public partial struct NMUPDOWN
{
    /// <include file='NMUPDOWN.xml' path='doc/member[@name="NMUPDOWN.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMUPDOWN.xml' path='doc/member[@name="NMUPDOWN.iPos"]/*' />
    public int iPos;

    /// <include file='NMUPDOWN.xml' path='doc/member[@name="NMUPDOWN.iDelta"]/*' />
    public int iDelta;
}
