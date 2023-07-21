// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS"]/*' />
public enum SYNCMGR_PROGRESS_STATUS
{
    /// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS.SYNCMGR_PS_UPDATING"]/*' />
    SYNCMGR_PS_UPDATING = 1,

    /// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS.SYNCMGR_PS_UPDATING_INDETERMINATE"]/*' />
    SYNCMGR_PS_UPDATING_INDETERMINATE = 2,

    /// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS.SYNCMGR_PS_SUCCEEDED"]/*' />
    SYNCMGR_PS_SUCCEEDED = 3,

    /// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS.SYNCMGR_PS_FAILED"]/*' />
    SYNCMGR_PS_FAILED = 4,

    /// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS.SYNCMGR_PS_CANCELED"]/*' />
    SYNCMGR_PS_CANCELED = 5,

    /// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS.SYNCMGR_PS_DISCONNECTED"]/*' />
    SYNCMGR_PS_DISCONNECTED = 6,

    /// <include file='SYNCMGR_PROGRESS_STATUS.xml' path='doc/member[@name="SYNCMGR_PROGRESS_STATUS.SYNCMGR_PS_MAX"]/*' />
    SYNCMGR_PS_MAX = SYNCMGR_PS_DISCONNECTED,
}
