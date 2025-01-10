// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_ITEM_CAPABILITIES
{
    SYNCMGR_ICM_NONE = 0,
    SYNCMGR_ICM_PROVIDES_ICON = 0x1,
    SYNCMGR_ICM_EVENT_STORE = 0x2,
    SYNCMGR_ICM_CONFLICT_STORE = 0x4,
    SYNCMGR_ICM_CAN_DELETE = 0x10,
    SYNCMGR_ICM_CAN_BROWSE_CONTENT = 0x10000,
    SYNCMGR_ICM_QUERY_BEFORE_ENABLE = 0x100000,
    SYNCMGR_ICM_QUERY_BEFORE_DISABLE = 0x200000,
    SYNCMGR_ICM_QUERY_BEFORE_DELETE = 0x400000,
    SYNCMGR_ICM_VALID_MASK = 0x710017,
}
