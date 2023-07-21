// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LISTITEMSTATES.xml' path='doc/member[@name="LISTITEMSTATES"]/*' />
public enum LISTITEMSTATES
{
    /// <include file='LISTITEMSTATES.xml' path='doc/member[@name="LISTITEMSTATES.LISS_NORMAL"]/*' />
    LISS_NORMAL = 1,

    /// <include file='LISTITEMSTATES.xml' path='doc/member[@name="LISTITEMSTATES.LISS_HOT"]/*' />
    LISS_HOT = 2,

    /// <include file='LISTITEMSTATES.xml' path='doc/member[@name="LISTITEMSTATES.LISS_SELECTED"]/*' />
    LISS_SELECTED = 3,

    /// <include file='LISTITEMSTATES.xml' path='doc/member[@name="LISTITEMSTATES.LISS_DISABLED"]/*' />
    LISS_DISABLED = 4,

    /// <include file='LISTITEMSTATES.xml' path='doc/member[@name="LISTITEMSTATES.LISS_SELECTEDNOTFOCUS"]/*' />
    LISS_SELECTEDNOTFOCUS = 5,

    /// <include file='LISTITEMSTATES.xml' path='doc/member[@name="LISTITEMSTATES.LISS_HOTSELECTED"]/*' />
    LISS_HOTSELECTED = 6,
}
