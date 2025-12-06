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
    Disabled = 0,

    [NativeName("ALC_HRTF_ENABLED_SOFT")]
    Enabled = 1,

    [NativeName("ALC_HRTF_DENIED_SOFT")]
    Denied = 2,

    [NativeName("ALC_HRTF_REQUIRED_SOFT")]
    Required = 3,

    [NativeName("ALC_HRTF_HEADPHONES_DETECTED_SOFT")]
    HeadphonesDetected = 4,

    [NativeName("ALC_HRTF_UNSUPPORTED_FORMAT_SOFT")]
    UnsupportedFormat = 5,
}
