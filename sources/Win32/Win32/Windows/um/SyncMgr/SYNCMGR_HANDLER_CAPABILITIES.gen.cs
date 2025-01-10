// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_HANDLER_CAPABILITIES
{
    SYNCMGR_HCM_NONE = 0,
    SYNCMGR_HCM_PROVIDES_ICON = 0x1,
    SYNCMGR_HCM_EVENT_STORE = 0x2,
    SYNCMGR_HCM_CONFLICT_STORE = 0x4,
    SYNCMGR_HCM_SUPPORTS_CONCURRENT_SESSIONS = 0x10,
    SYNCMGR_HCM_CAN_BROWSE_CONTENT = 0x10000,
    SYNCMGR_HCM_CAN_SHOW_SCHEDULE = 0x20000,
    SYNCMGR_HCM_QUERY_BEFORE_ACTIVATE = 0x100000,
    SYNCMGR_HCM_QUERY_BEFORE_DEACTIVATE = 0x200000,
    SYNCMGR_HCM_QUERY_BEFORE_ENABLE = 0x400000,
    SYNCMGR_HCM_QUERY_BEFORE_DISABLE = 0x800000,
    SYNCMGR_HCM_VALID_MASK = 0xf30017,
}
