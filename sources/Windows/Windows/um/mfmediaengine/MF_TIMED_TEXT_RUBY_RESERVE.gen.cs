// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_TIMED_TEXT_RUBY_RESERVE.xml' path='doc/member[@name="MF_TIMED_TEXT_RUBY_RESERVE"]/*' />
public enum MF_TIMED_TEXT_RUBY_RESERVE
{
    /// <include file='MF_TIMED_TEXT_RUBY_RESERVE.xml' path='doc/member[@name="MF_TIMED_TEXT_RUBY_RESERVE.MF_TIMED_TEXT_RUBY_RESERVE_NONE"]/*' />
    MF_TIMED_TEXT_RUBY_RESERVE_NONE = 0,

    /// <include file='MF_TIMED_TEXT_RUBY_RESERVE.xml' path='doc/member[@name="MF_TIMED_TEXT_RUBY_RESERVE.MF_TIMED_TEXT_RUBY_RESERVE_BEFORE"]/*' />
    MF_TIMED_TEXT_RUBY_RESERVE_BEFORE = 1,

    /// <include file='MF_TIMED_TEXT_RUBY_RESERVE.xml' path='doc/member[@name="MF_TIMED_TEXT_RUBY_RESERVE.MF_TIMED_TEXT_RUBY_RESERVE_AFTER"]/*' />
    MF_TIMED_TEXT_RUBY_RESERVE_AFTER = 2,

    /// <include file='MF_TIMED_TEXT_RUBY_RESERVE.xml' path='doc/member[@name="MF_TIMED_TEXT_RUBY_RESERVE.MF_TIMED_TEXT_RUBY_RESERVE_BOTH"]/*' />
    MF_TIMED_TEXT_RUBY_RESERVE_BOTH = 3,

    /// <include file='MF_TIMED_TEXT_RUBY_RESERVE.xml' path='doc/member[@name="MF_TIMED_TEXT_RUBY_RESERVE.MF_TIMED_TEXT_RUBY_RESERVE_OUTSIDE"]/*' />
    MF_TIMED_TEXT_RUBY_RESERVE_OUTSIDE = 4,
}
