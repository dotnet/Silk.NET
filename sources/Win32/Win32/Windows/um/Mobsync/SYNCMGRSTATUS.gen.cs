// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGRSTATUS
{
    SYNCMGRSTATUS_STOPPED = 0,
    SYNCMGRSTATUS_SKIPPED = 0x1,
    SYNCMGRSTATUS_PENDING = 0x2,
    SYNCMGRSTATUS_UPDATING = 0x3,
    SYNCMGRSTATUS_SUCCEEDED = 0x4,
    SYNCMGRSTATUS_FAILED = 0x5,
    SYNCMGRSTATUS_PAUSED = 0x6,
    SYNCMGRSTATUS_RESUMING = 0x7,
    SYNCMGRSTATUS_UPDATING_INDETERMINATE = 0x8,
    SYNCMGRSTATUS_DELETED = 0x100,
}
