// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PathCch.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS"]/*' />
public enum PATHCCH_OPTIONS
{
    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_NONE"]/*' />
    PATHCCH_NONE = 0x0,

    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_ALLOW_LONG_PATHS"]/*' />
    PATHCCH_ALLOW_LONG_PATHS = 0x01,

    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_FORCE_ENABLE_LONG_NAME_PROCESS"]/*' />
    PATHCCH_FORCE_ENABLE_LONG_NAME_PROCESS = 0x02,

    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_FORCE_DISABLE_LONG_NAME_PROCESS"]/*' />
    PATHCCH_FORCE_DISABLE_LONG_NAME_PROCESS = 0x04,

    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_DO_NOT_NORMALIZE_SEGMENTS"]/*' />
    PATHCCH_DO_NOT_NORMALIZE_SEGMENTS = 0x08,

    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_ENSURE_IS_EXTENDED_LENGTH_PATH"]/*' />
    PATHCCH_ENSURE_IS_EXTENDED_LENGTH_PATH = 0x10,

    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_ENSURE_TRAILING_SLASH"]/*' />
    PATHCCH_ENSURE_TRAILING_SLASH = 0x020,

    /// <include file='PATHCCH_OPTIONS.xml' path='doc/member[@name="PATHCCH_OPTIONS.PATHCCH_CANONICALIZE_SLASHES"]/*' />
    PATHCCH_CANONICALIZE_SLASHES = 0x040,
}
