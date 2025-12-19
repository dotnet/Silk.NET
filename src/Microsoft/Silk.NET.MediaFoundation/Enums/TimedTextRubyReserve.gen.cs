// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_RUBY_RESERVE")]
    public enum TimedTextRubyReserve : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_RESERVE_NONE")]
        None = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_RESERVE_BEFORE")]
        Before = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_RESERVE_AFTER")]
        After = 0x2,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_RESERVE_BOTH")]
        Both = 0x3,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_RESERVE_OUTSIDE")]
        Outside = 0x4,
    }
}
