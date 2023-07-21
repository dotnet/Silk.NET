// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_FLUSH_MODE.xml' path='doc/member[@name="FILE_FLUSH_MODE"]/*' />
public enum FILE_FLUSH_MODE
{
    /// <include file='FILE_FLUSH_MODE.xml' path='doc/member[@name="FILE_FLUSH_MODE.FILE_FLUSH_DEFAULT"]/*' />
    FILE_FLUSH_DEFAULT = 0,

    /// <include file='FILE_FLUSH_MODE.xml' path='doc/member[@name="FILE_FLUSH_MODE.FILE_FLUSH_DATA"]/*' />
    FILE_FLUSH_DATA,

    /// <include file='FILE_FLUSH_MODE.xml' path='doc/member[@name="FILE_FLUSH_MODE.FILE_FLUSH_MIN_METADATA"]/*' />
    FILE_FLUSH_MIN_METADATA,

    /// <include file='FILE_FLUSH_MODE.xml' path='doc/member[@name="FILE_FLUSH_MODE.FILE_FLUSH_NO_SYNC"]/*' />
    FILE_FLUSH_NO_SYNC,
}
