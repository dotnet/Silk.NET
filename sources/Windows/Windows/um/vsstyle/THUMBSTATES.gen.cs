// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='THUMBSTATES.xml' path='doc/member[@name="THUMBSTATES"]/*' />
public enum THUMBSTATES
{
    /// <include file='THUMBSTATES.xml' path='doc/member[@name="THUMBSTATES.TUS_NORMAL"]/*' />
    TUS_NORMAL = 1,

    /// <include file='THUMBSTATES.xml' path='doc/member[@name="THUMBSTATES.TUS_HOT"]/*' />
    TUS_HOT = 2,

    /// <include file='THUMBSTATES.xml' path='doc/member[@name="THUMBSTATES.TUS_PRESSED"]/*' />
    TUS_PRESSED = 3,

    /// <include file='THUMBSTATES.xml' path='doc/member[@name="THUMBSTATES.TUS_FOCUSED"]/*' />
    TUS_FOCUSED = 4,

    /// <include file='THUMBSTATES.xml' path='doc/member[@name="THUMBSTATES.TUS_DISABLED"]/*' />
    TUS_DISABLED = 5,
}
