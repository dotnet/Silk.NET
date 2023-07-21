// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS"]/*' />
public enum SYNC_TRANSFER_STATUS
{
    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_NONE"]/*' />
    STS_NONE = 0,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_NEEDSUPLOAD"]/*' />
    STS_NEEDSUPLOAD = 0x1,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_NEEDSDOWNLOAD"]/*' />
    STS_NEEDSDOWNLOAD = 0x2,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_TRANSFERRING"]/*' />
    STS_TRANSFERRING = 0x4,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_PAUSED"]/*' />
    STS_PAUSED = 0x8,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_HASERROR"]/*' />
    STS_HASERROR = 0x10,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_FETCHING_METADATA"]/*' />
    STS_FETCHING_METADATA = 0x20,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_USER_REQUESTED_REFRESH"]/*' />
    STS_USER_REQUESTED_REFRESH = 0x40,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_HASWARNING"]/*' />
    STS_HASWARNING = 0x80,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_EXCLUDED"]/*' />
    STS_EXCLUDED = 0x100,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_INCOMPLETE"]/*' />
    STS_INCOMPLETE = 0x200,

    /// <include file='SYNC_TRANSFER_STATUS.xml' path='doc/member[@name="SYNC_TRANSFER_STATUS.STS_PLACEHOLDER_IFEMPTY"]/*' />
    STS_PLACEHOLDER_IFEMPTY = 0x400,
}
