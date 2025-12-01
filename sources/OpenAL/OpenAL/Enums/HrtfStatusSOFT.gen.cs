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

[NativeName("HrtfStatusSOFT")]
public enum HrtfStatusSOFT : uint
{
    [NativeName("ALC_HRTF_DISABLED_SOFT")]
    DisabledSOFT = unchecked((uint)0x0000),

    [NativeName("ALC_HRTF_ENABLED_SOFT")]
    EnabledSOFT = unchecked((uint)0x0001),

    [NativeName("ALC_HRTF_DENIED_SOFT")]
    DeniedSOFT = unchecked((uint)0x0002),

    [NativeName("ALC_HRTF_REQUIRED_SOFT")]
    RequiredSOFT = unchecked((uint)0x0003),

    [NativeName("ALC_HRTF_HEADPHONES_DETECTED_SOFT")]
    HeadphonesDetectedSOFT = unchecked((uint)0x0004),

    [NativeName("ALC_HRTF_UNSUPPORTED_FORMAT_SOFT")]
    UnsupportedFormatSOFT = unchecked((uint)0x0005),
}
