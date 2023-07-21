// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PENDINGMSG.xml' path='doc/member[@name="PENDINGMSG"]/*' />
public enum PENDINGMSG
{
    /// <include file='PENDINGMSG.xml' path='doc/member[@name="PENDINGMSG.PENDINGMSG_CANCELCALL"]/*' />
    PENDINGMSG_CANCELCALL = 0,

    /// <include file='PENDINGMSG.xml' path='doc/member[@name="PENDINGMSG.PENDINGMSG_WAITNOPROCESS"]/*' />
    PENDINGMSG_WAITNOPROCESS = 1,

    /// <include file='PENDINGMSG.xml' path='doc/member[@name="PENDINGMSG.PENDINGMSG_WAITDEFPROCESS"]/*' />
    PENDINGMSG_WAITDEFPROCESS = 2,
}
