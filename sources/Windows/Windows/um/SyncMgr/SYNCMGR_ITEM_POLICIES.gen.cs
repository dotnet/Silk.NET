// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES"]/*' />
public enum SYNCMGR_ITEM_POLICIES
{
    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_NONE"]/*' />
    SYNCMGR_IPM_NONE = 0,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_PREVENT_ENABLE"]/*' />
    SYNCMGR_IPM_PREVENT_ENABLE = 0x1,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_PREVENT_DISABLE"]/*' />
    SYNCMGR_IPM_PREVENT_DISABLE = 0x2,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_PREVENT_START_SYNC"]/*' />
    SYNCMGR_IPM_PREVENT_START_SYNC = 0x4,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_PREVENT_STOP_SYNC"]/*' />
    SYNCMGR_IPM_PREVENT_STOP_SYNC = 0x8,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_DISABLE_ENABLE"]/*' />
    SYNCMGR_IPM_DISABLE_ENABLE = 0x10,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_DISABLE_DISABLE"]/*' />
    SYNCMGR_IPM_DISABLE_DISABLE = 0x20,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_DISABLE_START_SYNC"]/*' />
    SYNCMGR_IPM_DISABLE_START_SYNC = 0x40,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_DISABLE_STOP_SYNC"]/*' />
    SYNCMGR_IPM_DISABLE_STOP_SYNC = 0x80,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_DISABLE_BROWSE"]/*' />
    SYNCMGR_IPM_DISABLE_BROWSE = 0x100,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_DISABLE_DELETE"]/*' />
    SYNCMGR_IPM_DISABLE_DELETE = 0x200,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_HIDDEN_BY_DEFAULT"]/*' />
    SYNCMGR_IPM_HIDDEN_BY_DEFAULT = 0x10000,

    /// <include file='SYNCMGR_ITEM_POLICIES.xml' path='doc/member[@name="SYNCMGR_ITEM_POLICIES.SYNCMGR_IPM_VALID_MASK"]/*' />
    SYNCMGR_IPM_VALID_MASK = 0x102ff,
}
