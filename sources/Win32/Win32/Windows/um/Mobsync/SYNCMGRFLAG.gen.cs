// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGRFLAG
{
    SYNCMGRFLAG_CONNECT = 0x1,
    SYNCMGRFLAG_PENDINGDISCONNECT = 0x2,
    SYNCMGRFLAG_MANUAL = 0x3,
    SYNCMGRFLAG_IDLE = 0x4,
    SYNCMGRFLAG_INVOKE = 0x5,
    SYNCMGRFLAG_SCHEDULED = 0x6,
    SYNCMGRFLAG_EVENTMASK = 0xff,
    SYNCMGRFLAG_SETTINGS = 0x100,
    SYNCMGRFLAG_MAYBOTHERUSER = 0x200,
}
