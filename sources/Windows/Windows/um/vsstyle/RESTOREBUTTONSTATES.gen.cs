// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RESTOREBUTTONSTATES.xml' path='doc/member[@name="RESTOREBUTTONSTATES"]/*' />
public enum RESTOREBUTTONSTATES
{
    /// <include file='RESTOREBUTTONSTATES.xml' path='doc/member[@name="RESTOREBUTTONSTATES.RBS_NORMAL"]/*' />
    RBS_NORMAL = 1,

    /// <include file='RESTOREBUTTONSTATES.xml' path='doc/member[@name="RESTOREBUTTONSTATES.RBS_HOT"]/*' />
    RBS_HOT = 2,

    /// <include file='RESTOREBUTTONSTATES.xml' path='doc/member[@name="RESTOREBUTTONSTATES.RBS_PUSHED"]/*' />
    RBS_PUSHED = 3,

    /// <include file='RESTOREBUTTONSTATES.xml' path='doc/member[@name="RESTOREBUTTONSTATES.RBS_DISABLED"]/*' />
    RBS_DISABLED = 4,
}
