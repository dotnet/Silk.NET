// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NAV_FORWARDBUTTONSTATES.xml' path='doc/member[@name="NAV_FORWARDBUTTONSTATES"]/*' />
public enum NAV_FORWARDBUTTONSTATES
{
    /// <include file='NAV_FORWARDBUTTONSTATES.xml' path='doc/member[@name="NAV_FORWARDBUTTONSTATES.NAV_FB_NORMAL"]/*' />
    NAV_FB_NORMAL = 1,

    /// <include file='NAV_FORWARDBUTTONSTATES.xml' path='doc/member[@name="NAV_FORWARDBUTTONSTATES.NAV_FB_HOT"]/*' />
    NAV_FB_HOT = 2,

    /// <include file='NAV_FORWARDBUTTONSTATES.xml' path='doc/member[@name="NAV_FORWARDBUTTONSTATES.NAV_FB_PRESSED"]/*' />
    NAV_FB_PRESSED = 3,

    /// <include file='NAV_FORWARDBUTTONSTATES.xml' path='doc/member[@name="NAV_FORWARDBUTTONSTATES.NAV_FB_DISABLED"]/*' />
    NAV_FB_DISABLED = 4,
}
