// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MIB_TCP_STATE
{
    MIB_TCP_STATE_CLOSED = 1,
    MIB_TCP_STATE_LISTEN = 2,
    MIB_TCP_STATE_SYN_SENT = 3,
    MIB_TCP_STATE_SYN_RCVD = 4,
    MIB_TCP_STATE_ESTAB = 5,
    MIB_TCP_STATE_FIN_WAIT1 = 6,
    MIB_TCP_STATE_FIN_WAIT2 = 7,
    MIB_TCP_STATE_CLOSE_WAIT = 8,
    MIB_TCP_STATE_CLOSING = 9,
    MIB_TCP_STATE_LAST_ACK = 10,
    MIB_TCP_STATE_TIME_WAIT = 11,
    MIB_TCP_STATE_DELETE_TCB = 12,
    MIB_TCP_STATE_RESERVED = 100,
}
