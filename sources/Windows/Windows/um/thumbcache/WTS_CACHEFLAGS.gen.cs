// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WTS_CACHEFLAGS.xml' path='doc/member[@name="WTS_CACHEFLAGS"]/*' />
public enum WTS_CACHEFLAGS
{
    /// <include file='WTS_CACHEFLAGS.xml' path='doc/member[@name="WTS_CACHEFLAGS.WTS_DEFAULT"]/*' />
    WTS_DEFAULT = 0,

    /// <include file='WTS_CACHEFLAGS.xml' path='doc/member[@name="WTS_CACHEFLAGS.WTS_LOWQUALITY"]/*' />
    WTS_LOWQUALITY = 0x1,

    /// <include file='WTS_CACHEFLAGS.xml' path='doc/member[@name="WTS_CACHEFLAGS.WTS_CACHED"]/*' />
    WTS_CACHED = 0x2,
}
