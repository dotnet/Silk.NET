// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYSBUTTONSTATES.xml' path='doc/member[@name="SYSBUTTONSTATES"]/*' />
public enum SYSBUTTONSTATES
{
    /// <include file='SYSBUTTONSTATES.xml' path='doc/member[@name="SYSBUTTONSTATES.SBS_NORMAL"]/*' />
    SBS_NORMAL = 1,

    /// <include file='SYSBUTTONSTATES.xml' path='doc/member[@name="SYSBUTTONSTATES.SBS_HOT"]/*' />
    SBS_HOT = 2,

    /// <include file='SYSBUTTONSTATES.xml' path='doc/member[@name="SYSBUTTONSTATES.SBS_PUSHED"]/*' />
    SBS_PUSHED = 3,

    /// <include file='SYSBUTTONSTATES.xml' path='doc/member[@name="SYSBUTTONSTATES.SBS_DISABLED"]/*' />
    SBS_DISABLED = 4,
}
