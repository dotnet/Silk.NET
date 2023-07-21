// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BORDER_HVSCROLLSTATES.xml' path='doc/member[@name="BORDER_HVSCROLLSTATES"]/*' />
public enum BORDER_HVSCROLLSTATES
{
    /// <include file='BORDER_HVSCROLLSTATES.xml' path='doc/member[@name="BORDER_HVSCROLLSTATES.LBPSHV_NORMAL"]/*' />
    LBPSHV_NORMAL = 1,

    /// <include file='BORDER_HVSCROLLSTATES.xml' path='doc/member[@name="BORDER_HVSCROLLSTATES.LBPSHV_FOCUSED"]/*' />
    LBPSHV_FOCUSED = 2,

    /// <include file='BORDER_HVSCROLLSTATES.xml' path='doc/member[@name="BORDER_HVSCROLLSTATES.LBPSHV_HOT"]/*' />
    LBPSHV_HOT = 3,

    /// <include file='BORDER_HVSCROLLSTATES.xml' path='doc/member[@name="BORDER_HVSCROLLSTATES.LBPSHV_DISABLED"]/*' />
    LBPSHV_DISABLED = 4,
}
