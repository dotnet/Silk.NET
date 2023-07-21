// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EDITBORDER_HSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_HSCROLLSTATES"]/*' />
public enum EDITBORDER_HSCROLLSTATES
{
    /// <include file='EDITBORDER_HSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_HSCROLLSTATES.EPSH_NORMAL"]/*' />
    EPSH_NORMAL = 1,

    /// <include file='EDITBORDER_HSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_HSCROLLSTATES.EPSH_HOT"]/*' />
    EPSH_HOT = 2,

    /// <include file='EDITBORDER_HSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_HSCROLLSTATES.EPSH_FOCUSED"]/*' />
    EPSH_FOCUSED = 3,

    /// <include file='EDITBORDER_HSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_HSCROLLSTATES.EPSH_DISABLED"]/*' />
    EPSH_DISABLED = 4,
}
