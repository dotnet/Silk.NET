// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES"]/*' />
public enum SYNCMGR_ITEM_CAPABILITIES
{
    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_NONE"]/*' />
    SYNCMGR_ICM_NONE = 0,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_PROVIDES_ICON"]/*' />
    SYNCMGR_ICM_PROVIDES_ICON = 0x1,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_EVENT_STORE"]/*' />
    SYNCMGR_ICM_EVENT_STORE = 0x2,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_CONFLICT_STORE"]/*' />
    SYNCMGR_ICM_CONFLICT_STORE = 0x4,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_CAN_DELETE"]/*' />
    SYNCMGR_ICM_CAN_DELETE = 0x10,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_CAN_BROWSE_CONTENT"]/*' />
    SYNCMGR_ICM_CAN_BROWSE_CONTENT = 0x10000,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_QUERY_BEFORE_ENABLE"]/*' />
    SYNCMGR_ICM_QUERY_BEFORE_ENABLE = 0x100000,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_QUERY_BEFORE_DISABLE"]/*' />
    SYNCMGR_ICM_QUERY_BEFORE_DISABLE = 0x200000,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_QUERY_BEFORE_DELETE"]/*' />
    SYNCMGR_ICM_QUERY_BEFORE_DELETE = 0x400000,

    /// <include file='SYNCMGR_ITEM_CAPABILITIES.xml' path='doc/member[@name="SYNCMGR_ITEM_CAPABILITIES.SYNCMGR_ICM_VALID_MASK"]/*' />
    SYNCMGR_ICM_VALID_MASK = 0x710017,
}
