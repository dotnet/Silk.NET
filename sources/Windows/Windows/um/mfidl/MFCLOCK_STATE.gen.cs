// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFCLOCK_STATE.xml' path='doc/member[@name="MFCLOCK_STATE"]/*' />
public enum MFCLOCK_STATE
{
    /// <include file='MFCLOCK_STATE.xml' path='doc/member[@name="MFCLOCK_STATE.MFCLOCK_STATE_INVALID"]/*' />
    MFCLOCK_STATE_INVALID = 0,

    /// <include file='MFCLOCK_STATE.xml' path='doc/member[@name="MFCLOCK_STATE.MFCLOCK_STATE_RUNNING"]/*' />
    MFCLOCK_STATE_RUNNING = (MFCLOCK_STATE_INVALID + 1),

    /// <include file='MFCLOCK_STATE.xml' path='doc/member[@name="MFCLOCK_STATE.MFCLOCK_STATE_STOPPED"]/*' />
    MFCLOCK_STATE_STOPPED = (MFCLOCK_STATE_RUNNING + 1),

    /// <include file='MFCLOCK_STATE.xml' path='doc/member[@name="MFCLOCK_STATE.MFCLOCK_STATE_PAUSED"]/*' />
    MFCLOCK_STATE_PAUSED = (MFCLOCK_STATE_STOPPED + 1),
}
