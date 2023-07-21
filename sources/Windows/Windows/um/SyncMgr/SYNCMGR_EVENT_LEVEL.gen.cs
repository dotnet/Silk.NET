// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGR_EVENT_LEVEL.xml' path='doc/member[@name="SYNCMGR_EVENT_LEVEL"]/*' />
public enum SYNCMGR_EVENT_LEVEL
{
    /// <include file='SYNCMGR_EVENT_LEVEL.xml' path='doc/member[@name="SYNCMGR_EVENT_LEVEL.SYNCMGR_EL_INFORMATION"]/*' />
    SYNCMGR_EL_INFORMATION = 1,

    /// <include file='SYNCMGR_EVENT_LEVEL.xml' path='doc/member[@name="SYNCMGR_EVENT_LEVEL.SYNCMGR_EL_WARNING"]/*' />
    SYNCMGR_EL_WARNING = 2,

    /// <include file='SYNCMGR_EVENT_LEVEL.xml' path='doc/member[@name="SYNCMGR_EVENT_LEVEL.SYNCMGR_EL_ERROR"]/*' />
    SYNCMGR_EL_ERROR = 3,

    /// <include file='SYNCMGR_EVENT_LEVEL.xml' path='doc/member[@name="SYNCMGR_EVENT_LEVEL.SYNCMGR_EL_MAX"]/*' />
    SYNCMGR_EL_MAX = SYNCMGR_EL_ERROR,
}
