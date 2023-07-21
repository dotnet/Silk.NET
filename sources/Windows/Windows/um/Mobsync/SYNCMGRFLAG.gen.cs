// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG"]/*' />
public enum SYNCMGRFLAG
{
    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_CONNECT"]/*' />
    SYNCMGRFLAG_CONNECT = 0x1,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_PENDINGDISCONNECT"]/*' />
    SYNCMGRFLAG_PENDINGDISCONNECT = 0x2,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_MANUAL"]/*' />
    SYNCMGRFLAG_MANUAL = 0x3,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_IDLE"]/*' />
    SYNCMGRFLAG_IDLE = 0x4,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_INVOKE"]/*' />
    SYNCMGRFLAG_INVOKE = 0x5,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_SCHEDULED"]/*' />
    SYNCMGRFLAG_SCHEDULED = 0x6,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_EVENTMASK"]/*' />
    SYNCMGRFLAG_EVENTMASK = 0xff,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_SETTINGS"]/*' />
    SYNCMGRFLAG_SETTINGS = 0x100,

    /// <include file='SYNCMGRFLAG.xml' path='doc/member[@name="SYNCMGRFLAG.SYNCMGRFLAG_MAYBOTHERUSER"]/*' />
    SYNCMGRFLAG_MAYBOTHERUSER = 0x200,
}
