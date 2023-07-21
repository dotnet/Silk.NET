// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGR_PRESENTER_CHOICE.xml' path='doc/member[@name="SYNCMGR_PRESENTER_CHOICE"]/*' />
public enum SYNCMGR_PRESENTER_CHOICE
{
    /// <include file='SYNCMGR_PRESENTER_CHOICE.xml' path='doc/member[@name="SYNCMGR_PRESENTER_CHOICE.SYNCMGR_PC_NO_CHOICE"]/*' />
    SYNCMGR_PC_NO_CHOICE = 0,

    /// <include file='SYNCMGR_PRESENTER_CHOICE.xml' path='doc/member[@name="SYNCMGR_PRESENTER_CHOICE.SYNCMGR_PC_KEEP_ONE"]/*' />
    SYNCMGR_PC_KEEP_ONE = (SYNCMGR_PC_NO_CHOICE + 1),

    /// <include file='SYNCMGR_PRESENTER_CHOICE.xml' path='doc/member[@name="SYNCMGR_PRESENTER_CHOICE.SYNCMGR_PC_KEEP_MULTIPLE"]/*' />
    SYNCMGR_PC_KEEP_MULTIPLE = (SYNCMGR_PC_KEEP_ONE + 1),

    /// <include file='SYNCMGR_PRESENTER_CHOICE.xml' path='doc/member[@name="SYNCMGR_PRESENTER_CHOICE.SYNCMGR_PC_KEEP_RECENT"]/*' />
    SYNCMGR_PC_KEEP_RECENT = (SYNCMGR_PC_KEEP_MULTIPLE + 1),

    /// <include file='SYNCMGR_PRESENTER_CHOICE.xml' path='doc/member[@name="SYNCMGR_PRESENTER_CHOICE.SYNCMGR_PC_REMOVE_FROM_SYNC_SET"]/*' />
    SYNCMGR_PC_REMOVE_FROM_SYNC_SET = (SYNCMGR_PC_KEEP_RECENT + 1),

    /// <include file='SYNCMGR_PRESENTER_CHOICE.xml' path='doc/member[@name="SYNCMGR_PRESENTER_CHOICE.SYNCMGR_PC_SKIP"]/*' />
    SYNCMGR_PC_SKIP = (SYNCMGR_PC_REMOVE_FROM_SYNC_SET + 1),
}
