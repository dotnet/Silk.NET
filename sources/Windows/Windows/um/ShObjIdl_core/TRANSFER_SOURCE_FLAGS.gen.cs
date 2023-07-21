// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS"]/*' />
[Flags]
public enum TRANSFER_SOURCE_FLAGS
{
    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_NORMAL"]/*' />
    TSF_NORMAL = 0,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_FAIL_EXIST"]/*' />
    TSF_FAIL_EXIST = 0,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_RENAME_EXIST"]/*' />
    TSF_RENAME_EXIST = 0x1,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_OVERWRITE_EXIST"]/*' />
    TSF_OVERWRITE_EXIST = 0x2,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_ALLOW_DECRYPTION"]/*' />
    TSF_ALLOW_DECRYPTION = 0x4,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_NO_SECURITY"]/*' />
    TSF_NO_SECURITY = 0x8,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_COPY_CREATION_TIME"]/*' />
    TSF_COPY_CREATION_TIME = 0x10,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_COPY_WRITE_TIME"]/*' />
    TSF_COPY_WRITE_TIME = 0x20,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_USE_FULL_ACCESS"]/*' />
    TSF_USE_FULL_ACCESS = 0x40,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_DELETE_RECYCLE_IF_POSSIBLE"]/*' />
    TSF_DELETE_RECYCLE_IF_POSSIBLE = 0x80,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_COPY_HARD_LINK"]/*' />
    TSF_COPY_HARD_LINK = 0x100,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_COPY_LOCALIZED_NAME"]/*' />
    TSF_COPY_LOCALIZED_NAME = 0x200,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_MOVE_AS_COPY_DELETE"]/*' />
    TSF_MOVE_AS_COPY_DELETE = 0x400,

    /// <include file='TRANSFER_SOURCE_FLAGS.xml' path='doc/member[@name="TRANSFER_SOURCE_FLAGS.TSF_SUSPEND_SHELLEVENTS"]/*' />
    TSF_SUSPEND_SHELLEVENTS = 0x800,
}
