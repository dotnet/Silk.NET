// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_ITEM_POLICIES
{
    SYNCMGR_IPM_NONE = 0,
    SYNCMGR_IPM_PREVENT_ENABLE = 0x1,
    SYNCMGR_IPM_PREVENT_DISABLE = 0x2,
    SYNCMGR_IPM_PREVENT_START_SYNC = 0x4,
    SYNCMGR_IPM_PREVENT_STOP_SYNC = 0x8,
    SYNCMGR_IPM_DISABLE_ENABLE = 0x10,
    SYNCMGR_IPM_DISABLE_DISABLE = 0x20,
    SYNCMGR_IPM_DISABLE_START_SYNC = 0x40,
    SYNCMGR_IPM_DISABLE_STOP_SYNC = 0x80,
    SYNCMGR_IPM_DISABLE_BROWSE = 0x100,
    SYNCMGR_IPM_DISABLE_DELETE = 0x200,
    SYNCMGR_IPM_HIDDEN_BY_DEFAULT = 0x10000,
    SYNCMGR_IPM_VALID_MASK = 0x102ff,
}
