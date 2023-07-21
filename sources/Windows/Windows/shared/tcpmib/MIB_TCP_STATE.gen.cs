// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE"]/*' />
public enum MIB_TCP_STATE
{
    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_CLOSED"]/*' />
    MIB_TCP_STATE_CLOSED = 1,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_LISTEN"]/*' />
    MIB_TCP_STATE_LISTEN = 2,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_SYN_SENT"]/*' />
    MIB_TCP_STATE_SYN_SENT = 3,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_SYN_RCVD"]/*' />
    MIB_TCP_STATE_SYN_RCVD = 4,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_ESTAB"]/*' />
    MIB_TCP_STATE_ESTAB = 5,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_FIN_WAIT1"]/*' />
    MIB_TCP_STATE_FIN_WAIT1 = 6,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_FIN_WAIT2"]/*' />
    MIB_TCP_STATE_FIN_WAIT2 = 7,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_CLOSE_WAIT"]/*' />
    MIB_TCP_STATE_CLOSE_WAIT = 8,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_CLOSING"]/*' />
    MIB_TCP_STATE_CLOSING = 9,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_LAST_ACK"]/*' />
    MIB_TCP_STATE_LAST_ACK = 10,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_TIME_WAIT"]/*' />
    MIB_TCP_STATE_TIME_WAIT = 11,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_DELETE_TCB"]/*' />
    MIB_TCP_STATE_DELETE_TCB = 12,

    /// <include file='MIB_TCP_STATE.xml' path='doc/member[@name="MIB_TCP_STATE.MIB_TCP_STATE_RESERVED"]/*' />
    MIB_TCP_STATE_RESERVED = 100,
}
