// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_RUBY_ALIGN")]
    public enum TimedTextRubyAlign : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_ALIGN_CENTER")]
        Center = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_ALIGN_START")]
        Start = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_ALIGN_END")]
        End = 0x2,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_ALIGN_SPACEAROUND")]
        Spacearound = 0x3,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_ALIGN_SPACEBETWEEN")]
        Spacebetween = 0x4,
        [NativeName("Name", "MF_TIMED_TEXT_RUBY_ALIGN_WITHBASE")]
        Withbase = 0x5,
    }
}
