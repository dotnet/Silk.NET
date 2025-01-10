// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_PRESENTER_CHOICE
{
    SYNCMGR_PC_NO_CHOICE = 0,
    SYNCMGR_PC_KEEP_ONE = (SYNCMGR_PC_NO_CHOICE + 1),
    SYNCMGR_PC_KEEP_MULTIPLE = (SYNCMGR_PC_KEEP_ONE + 1),
    SYNCMGR_PC_KEEP_RECENT = (SYNCMGR_PC_KEEP_MULTIPLE + 1),
    SYNCMGR_PC_REMOVE_FROM_SYNC_SET = (SYNCMGR_PC_KEEP_RECENT + 1),
    SYNCMGR_PC_SKIP = (SYNCMGR_PC_REMOVE_FROM_SYNC_SET + 1),
}
