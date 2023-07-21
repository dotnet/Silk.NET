// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_UPDATE_TYPES
{
    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_NONE"]/*' />
    PRJ_UPDATE_NONE = 0x00000000,

    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_ALLOW_DIRTY_METADATA"]/*' />
    PRJ_UPDATE_ALLOW_DIRTY_METADATA = 0x00000001,

    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_ALLOW_DIRTY_DATA"]/*' />
    PRJ_UPDATE_ALLOW_DIRTY_DATA = 0x00000002,

    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_ALLOW_TOMBSTONE"]/*' />
    PRJ_UPDATE_ALLOW_TOMBSTONE = 0x00000004,

    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_RESERVED1"]/*' />
    PRJ_UPDATE_RESERVED1 = 0x00000008,

    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_RESERVED2"]/*' />
    PRJ_UPDATE_RESERVED2 = 0x00000010,

    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_ALLOW_READ_ONLY"]/*' />
    PRJ_UPDATE_ALLOW_READ_ONLY = 0x00000020,

    /// <include file='PRJ_UPDATE_TYPES.xml' path='doc/member[@name="PRJ_UPDATE_TYPES.PRJ_UPDATE_MAX_VAL"]/*' />
    PRJ_UPDATE_MAX_VAL = (PRJ_UPDATE_ALLOW_READ_ONLY << 1),
}
