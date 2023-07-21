// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NAV_BACKBUTTONSTATES.xml' path='doc/member[@name="NAV_BACKBUTTONSTATES"]/*' />
public enum NAV_BACKBUTTONSTATES
{
    /// <include file='NAV_BACKBUTTONSTATES.xml' path='doc/member[@name="NAV_BACKBUTTONSTATES.NAV_BB_NORMAL"]/*' />
    NAV_BB_NORMAL = 1,

    /// <include file='NAV_BACKBUTTONSTATES.xml' path='doc/member[@name="NAV_BACKBUTTONSTATES.NAV_BB_HOT"]/*' />
    NAV_BB_HOT = 2,

    /// <include file='NAV_BACKBUTTONSTATES.xml' path='doc/member[@name="NAV_BACKBUTTONSTATES.NAV_BB_PRESSED"]/*' />
    NAV_BB_PRESSED = 3,

    /// <include file='NAV_BACKBUTTONSTATES.xml' path='doc/member[@name="NAV_BACKBUTTONSTATES.NAV_BB_DISABLED"]/*' />
    NAV_BB_DISABLED = 4,
}
