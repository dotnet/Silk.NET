// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGR_CANCEL_REQUEST.xml' path='doc/member[@name="SYNCMGR_CANCEL_REQUEST"]/*' />
public enum SYNCMGR_CANCEL_REQUEST
{
    /// <include file='SYNCMGR_CANCEL_REQUEST.xml' path='doc/member[@name="SYNCMGR_CANCEL_REQUEST.SYNCMGR_CR_NONE"]/*' />
    SYNCMGR_CR_NONE = 0,

    /// <include file='SYNCMGR_CANCEL_REQUEST.xml' path='doc/member[@name="SYNCMGR_CANCEL_REQUEST.SYNCMGR_CR_CANCEL_ITEM"]/*' />
    SYNCMGR_CR_CANCEL_ITEM = 1,

    /// <include file='SYNCMGR_CANCEL_REQUEST.xml' path='doc/member[@name="SYNCMGR_CANCEL_REQUEST.SYNCMGR_CR_CANCEL_ALL"]/*' />
    SYNCMGR_CR_CANCEL_ALL = 2,

    /// <include file='SYNCMGR_CANCEL_REQUEST.xml' path='doc/member[@name="SYNCMGR_CANCEL_REQUEST.SYNCMGR_CR_MAX"]/*' />
    SYNCMGR_CR_MAX = SYNCMGR_CR_CANCEL_ALL,
}
