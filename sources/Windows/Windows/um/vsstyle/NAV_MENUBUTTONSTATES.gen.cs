// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NAV_MENUBUTTONSTATES.xml' path='doc/member[@name="NAV_MENUBUTTONSTATES"]/*' />
public enum NAV_MENUBUTTONSTATES
{
    /// <include file='NAV_MENUBUTTONSTATES.xml' path='doc/member[@name="NAV_MENUBUTTONSTATES.NAV_MB_NORMAL"]/*' />
    NAV_MB_NORMAL = 1,

    /// <include file='NAV_MENUBUTTONSTATES.xml' path='doc/member[@name="NAV_MENUBUTTONSTATES.NAV_MB_HOT"]/*' />
    NAV_MB_HOT = 2,

    /// <include file='NAV_MENUBUTTONSTATES.xml' path='doc/member[@name="NAV_MENUBUTTONSTATES.NAV_MB_PRESSED"]/*' />
    NAV_MB_PRESSED = 3,

    /// <include file='NAV_MENUBUTTONSTATES.xml' path='doc/member[@name="NAV_MENUBUTTONSTATES.NAV_MB_DISABLED"]/*' />
    NAV_MB_DISABLED = 4,
}
