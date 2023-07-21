// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BORDERSTATES.xml' path='doc/member[@name="BORDERSTATES"]/*' />
public enum BORDERSTATES
{
    /// <include file='BORDERSTATES.xml' path='doc/member[@name="BORDERSTATES.CBB_NORMAL"]/*' />
    CBB_NORMAL = 1,

    /// <include file='BORDERSTATES.xml' path='doc/member[@name="BORDERSTATES.CBB_HOT"]/*' />
    CBB_HOT = 2,

    /// <include file='BORDERSTATES.xml' path='doc/member[@name="BORDERSTATES.CBB_FOCUSED"]/*' />
    CBB_FOCUSED = 3,

    /// <include file='BORDERSTATES.xml' path='doc/member[@name="BORDERSTATES.CBB_DISABLED"]/*' />
    CBB_DISABLED = 4,
}
