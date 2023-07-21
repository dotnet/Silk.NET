// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='READONLYSTATES.xml' path='doc/member[@name="READONLYSTATES"]/*' />
public enum READONLYSTATES
{
    /// <include file='READONLYSTATES.xml' path='doc/member[@name="READONLYSTATES.CBRO_NORMAL"]/*' />
    CBRO_NORMAL = 1,

    /// <include file='READONLYSTATES.xml' path='doc/member[@name="READONLYSTATES.CBRO_HOT"]/*' />
    CBRO_HOT = 2,

    /// <include file='READONLYSTATES.xml' path='doc/member[@name="READONLYSTATES.CBRO_PRESSED"]/*' />
    CBRO_PRESSED = 3,

    /// <include file='READONLYSTATES.xml' path='doc/member[@name="READONLYSTATES.CBRO_DISABLED"]/*' />
    CBRO_DISABLED = 4,
}
