// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NameAffix("Suffix", "SOFT", 0)]
[NativeName("HrtfStatusSOFT")]
[Transformed]
public enum HrtfStatusSoft : uint
{
    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_DISABLED_SOFT")]
    Disabledsoft = unchecked((uint)0x0000),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_ENABLED_SOFT")]
    Enabledsoft = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_DENIED_SOFT")]
    Deniedsoft = unchecked((uint)0x0002),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_REQUIRED_SOFT")]
    Requiredsoft = unchecked((uint)0x0003),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_HEADPHONES_DETECTED_SOFT")]
    HeadphonesDetectedsoft = unchecked((uint)0x0004),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_UNSUPPORTED_FORMAT_SOFT")]
    UnsupportedFormatsoft = unchecked((uint)0x0005),
}
