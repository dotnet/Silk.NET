// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS"]/*' />
public enum SYNCMGRSTATUS
{
    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_STOPPED"]/*' />
    SYNCMGRSTATUS_STOPPED = 0,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_SKIPPED"]/*' />
    SYNCMGRSTATUS_SKIPPED = 0x1,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_PENDING"]/*' />
    SYNCMGRSTATUS_PENDING = 0x2,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_UPDATING"]/*' />
    SYNCMGRSTATUS_UPDATING = 0x3,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_SUCCEEDED"]/*' />
    SYNCMGRSTATUS_SUCCEEDED = 0x4,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_FAILED"]/*' />
    SYNCMGRSTATUS_FAILED = 0x5,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_PAUSED"]/*' />
    SYNCMGRSTATUS_PAUSED = 0x6,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_RESUMING"]/*' />
    SYNCMGRSTATUS_RESUMING = 0x7,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_UPDATING_INDETERMINATE"]/*' />
    SYNCMGRSTATUS_UPDATING_INDETERMINATE = 0x8,

    /// <include file='SYNCMGRSTATUS.xml' path='doc/member[@name="SYNCMGRSTATUS.SYNCMGRSTATUS_DELETED"]/*' />
    SYNCMGRSTATUS_DELETED = 0x100,
}
