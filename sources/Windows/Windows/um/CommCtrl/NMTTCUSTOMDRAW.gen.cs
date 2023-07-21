// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTTCUSTOMDRAW.xml' path='doc/member[@name="NMTTCUSTOMDRAW"]/*' />
public partial struct NMTTCUSTOMDRAW
{
    /// <include file='NMTTCUSTOMDRAW.xml' path='doc/member[@name="NMTTCUSTOMDRAW.nmcd"]/*' />
    public NMCUSTOMDRAW nmcd;

    /// <include file='NMTTCUSTOMDRAW.xml' path='doc/member[@name="NMTTCUSTOMDRAW.uDrawFlags"]/*' />
    public uint uDrawFlags;
}
