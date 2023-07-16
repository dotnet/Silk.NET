// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES"]/*'/>
public enum SYNCMGR_HANDLER_POLICIES
{
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_NONE"]/*'/>
    SYNCMGR_HPM_NONE = 0,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_PREVENT_ACTIVATE"]/*'/>
    SYNCMGR_HPM_PREVENT_ACTIVATE = 0x1,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_PREVENT_DEACTIVATE"]/*'/>
    SYNCMGR_HPM_PREVENT_DEACTIVATE = 0x2,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_PREVENT_ENABLE"]/*'/>
    SYNCMGR_HPM_PREVENT_ENABLE = 0x4,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_PREVENT_DISABLE"]/*'/>
    SYNCMGR_HPM_PREVENT_DISABLE = 0x8,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_PREVENT_START_SYNC"]/*'/>
    SYNCMGR_HPM_PREVENT_START_SYNC = 0x10,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_PREVENT_STOP_SYNC"]/*'/>
    SYNCMGR_HPM_PREVENT_STOP_SYNC = 0x20,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_DISABLE_ENABLE"]/*'/>
    SYNCMGR_HPM_DISABLE_ENABLE = 0x100,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_DISABLE_DISABLE"]/*'/>
    SYNCMGR_HPM_DISABLE_DISABLE = 0x200,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_DISABLE_START_SYNC"]/*'/>
    SYNCMGR_HPM_DISABLE_START_SYNC = 0x400,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_DISABLE_STOP_SYNC"]/*'/>
    SYNCMGR_HPM_DISABLE_STOP_SYNC = 0x800,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_DISABLE_BROWSE"]/*'/>
    SYNCMGR_HPM_DISABLE_BROWSE = 0x1000,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_DISABLE_SCHEDULE"]/*'/>
    SYNCMGR_HPM_DISABLE_SCHEDULE = 0x2000,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_HIDDEN_BY_DEFAULT"]/*'/>
    SYNCMGR_HPM_HIDDEN_BY_DEFAULT = 0x10000,
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_BACKGROUND_SYNC_ONLY"]/*'/>
    SYNCMGR_HPM_BACKGROUND_SYNC_ONLY = (SYNCMGR_HPM_PREVENT_START_SYNC | SYNCMGR_HPM_PREVENT_STOP_SYNC),
    /// <include file='SYNCMGR_HANDLER_POLICIES.xml' path='doc/member[@name="SYNCMGR_HANDLER_POLICIES.SYNCMGR_HPM_VALID_MASK"]/*'/>
    SYNCMGR_HPM_VALID_MASK = 0x12f3f,
}