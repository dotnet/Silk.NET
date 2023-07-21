// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BORDER_HSCROLLSTATES.xml' path='doc/member[@name="BORDER_HSCROLLSTATES"]/*' />
public enum BORDER_HSCROLLSTATES
{
    /// <include file='BORDER_HSCROLLSTATES.xml' path='doc/member[@name="BORDER_HSCROLLSTATES.LBPSH_NORMAL"]/*' />
    LBPSH_NORMAL = 1,

    /// <include file='BORDER_HSCROLLSTATES.xml' path='doc/member[@name="BORDER_HSCROLLSTATES.LBPSH_FOCUSED"]/*' />
    LBPSH_FOCUSED = 2,

    /// <include file='BORDER_HSCROLLSTATES.xml' path='doc/member[@name="BORDER_HSCROLLSTATES.LBPSH_HOT"]/*' />
    LBPSH_HOT = 3,

    /// <include file='BORDER_HSCROLLSTATES.xml' path='doc/member[@name="BORDER_HSCROLLSTATES.LBPSH_DISABLED"]/*' />
    LBPSH_DISABLED = 4,
}
