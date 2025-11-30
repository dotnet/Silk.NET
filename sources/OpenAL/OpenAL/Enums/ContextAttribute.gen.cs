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

[NativeName("ContextAttribute")]
[Transformed]
public enum ContextAttribute : uint
{
    [NativeName("ALC_FREQUENCY")]
    Frequency = unchecked((uint)0x1007),

    [NativeName("ALC_REFRESH")]
    Refresh = unchecked((uint)0x1008),

    [NativeName("ALC_SYNC")]
    Sync = unchecked((uint)0x1009),

    [NativeName("ALC_MONO_SOURCES")]
    MonoSources = unchecked((uint)0x1010),

    [NativeName("ALC_STEREO_SOURCES")]
    StereoSources = unchecked((uint)0x1011),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_FORMAT_CHANNELS_SOFT")]
    FormatChannelsSOFT = unchecked((uint)0x1990),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_FORMAT_TYPE_SOFT")]
    FormatTypeSOFT = unchecked((uint)0x1991),

    [NativeName("ALC_DEFAULT_FILTER_ORDER")]
    DefaultFilterOrder = unchecked((uint)0x1100),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_SOFT")]
    HrtfSOFT = unchecked((uint)0x1992),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_ID_SOFT")]
    HrtfIdSOFT = unchecked((uint)0x1996),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_OUTPUT_LIMITER_SOFT")]
    OutputLimiterSOFT = unchecked((uint)0x199A),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutSOFT = unchecked((uint)0x1997),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingSOFT = unchecked((uint)0x1998),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_AMBISONIC_ORDER_SOFT")]
    AmbisonicOrderSOFT = unchecked((uint)0x1999),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_OUTPUT_MODE_SOFT")]
    OutputModeSOFT = unchecked((uint)0x19AC),
}
