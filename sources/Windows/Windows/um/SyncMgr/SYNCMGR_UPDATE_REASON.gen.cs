// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGR_UPDATE_REASON.xml' path='doc/member[@name="SYNCMGR_UPDATE_REASON"]/*' />
public enum SYNCMGR_UPDATE_REASON
{
    /// <include file='SYNCMGR_UPDATE_REASON.xml' path='doc/member[@name="SYNCMGR_UPDATE_REASON.SYNCMGR_UR_ADDED"]/*' />
    SYNCMGR_UR_ADDED = 0,

    /// <include file='SYNCMGR_UPDATE_REASON.xml' path='doc/member[@name="SYNCMGR_UPDATE_REASON.SYNCMGR_UR_CHANGED"]/*' />
    SYNCMGR_UR_CHANGED = 1,

    /// <include file='SYNCMGR_UPDATE_REASON.xml' path='doc/member[@name="SYNCMGR_UPDATE_REASON.SYNCMGR_UR_REMOVED"]/*' />
    SYNCMGR_UR_REMOVED = 2,

    /// <include file='SYNCMGR_UPDATE_REASON.xml' path='doc/member[@name="SYNCMGR_UPDATE_REASON.SYNCMGR_UR_MAX"]/*' />
    SYNCMGR_UR_MAX = SYNCMGR_UR_REMOVED,
}
