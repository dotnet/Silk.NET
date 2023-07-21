// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='THUMBTOPSTATES.xml' path='doc/member[@name="THUMBTOPSTATES"]/*' />
public enum THUMBTOPSTATES
{
    /// <include file='THUMBTOPSTATES.xml' path='doc/member[@name="THUMBTOPSTATES.TUTS_NORMAL"]/*' />
    TUTS_NORMAL = 1,

    /// <include file='THUMBTOPSTATES.xml' path='doc/member[@name="THUMBTOPSTATES.TUTS_HOT"]/*' />
    TUTS_HOT = 2,

    /// <include file='THUMBTOPSTATES.xml' path='doc/member[@name="THUMBTOPSTATES.TUTS_PRESSED"]/*' />
    TUTS_PRESSED = 3,

    /// <include file='THUMBTOPSTATES.xml' path='doc/member[@name="THUMBTOPSTATES.TUTS_FOCUSED"]/*' />
    TUTS_FOCUSED = 4,

    /// <include file='THUMBTOPSTATES.xml' path='doc/member[@name="THUMBTOPSTATES.TUTS_DISABLED"]/*' />
    TUTS_DISABLED = 5,
}
