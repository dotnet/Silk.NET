// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WTS_CONTEXTFLAGS.xml' path='doc/member[@name="WTS_CONTEXTFLAGS"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum WTS_CONTEXTFLAGS
{
    /// <include file='WTS_CONTEXTFLAGS.xml' path='doc/member[@name="WTS_CONTEXTFLAGS.WTSCF_DEFAULT"]/*' />
    WTSCF_DEFAULT = 0,

    /// <include file='WTS_CONTEXTFLAGS.xml' path='doc/member[@name="WTS_CONTEXTFLAGS.WTSCF_APPSTYLE"]/*' />
    WTSCF_APPSTYLE = 0x1,

    /// <include file='WTS_CONTEXTFLAGS.xml' path='doc/member[@name="WTS_CONTEXTFLAGS.WTSCF_SQUARE"]/*' />
    WTSCF_SQUARE = 0x2,

    /// <include file='WTS_CONTEXTFLAGS.xml' path='doc/member[@name="WTS_CONTEXTFLAGS.WTSCF_WIDE"]/*' />
    WTSCF_WIDE = 0x4,

    /// <include file='WTS_CONTEXTFLAGS.xml' path='doc/member[@name="WTS_CONTEXTFLAGS.WTSCF_FAST"]/*' />
    WTSCF_FAST = 0x8,
}
