// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES"]/*' />
public enum AM_SEEKING_SEEKING_CAPABILITIES
{
    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanSeekAbsolute"]/*' />
    AM_SEEKING_CanSeekAbsolute = 0x1,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanSeekForwards"]/*' />
    AM_SEEKING_CanSeekForwards = 0x2,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanSeekBackwards"]/*' />
    AM_SEEKING_CanSeekBackwards = 0x4,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanGetCurrentPos"]/*' />
    AM_SEEKING_CanGetCurrentPos = 0x8,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanGetStopPos"]/*' />
    AM_SEEKING_CanGetStopPos = 0x10,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanGetDuration"]/*' />
    AM_SEEKING_CanGetDuration = 0x20,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanPlayBackwards"]/*' />
    AM_SEEKING_CanPlayBackwards = 0x40,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_CanDoSegments"]/*' />
    AM_SEEKING_CanDoSegments = 0x80,

    /// <include file='AM_SEEKING_SEEKING_CAPABILITIES.xml' path='doc/member[@name="AM_SEEKING_SEEKING_CAPABILITIES.AM_SEEKING_Source"]/*' />
    AM_SEEKING_Source = 0x100,
}
