// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTOOLTIPSCREATED.xml' path='doc/member[@name="NMTOOLTIPSCREATED"]/*' />
public partial struct NMTOOLTIPSCREATED
{
    /// <include file='NMTOOLTIPSCREATED.xml' path='doc/member[@name="NMTOOLTIPSCREATED.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTOOLTIPSCREATED.xml' path='doc/member[@name="NMTOOLTIPSCREATED.hwndToolTips"]/*' />
    public HWND hwndToolTips;
}
