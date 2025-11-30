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

[NativeName("ContextInteger")]
[Transformed]
public enum ContextInteger : uint
{
    [NativeName("ALC_FREQUENCY")]
    Frequency = unchecked((uint)0x1007),

    [NativeName("ALC_REFRESH")]
    Refresh = unchecked((uint)0x1008),

    [NativeName("ALC_MAJOR_VERSION")]
    MajorVersion = unchecked((uint)0x1000),

    [NativeName("ALC_MINOR_VERSION")]
    MinorVersion = unchecked((uint)0x1001),

    [NativeName("ALC_ATTRIBUTES_SIZE")]
    AttributesSize = unchecked((uint)0x1002),

    [NativeName("ALC_ALL_ATTRIBUTES")]
    AllAttributes = unchecked((uint)0x1003),

    [NativeName("ALC_MONO_SOURCES")]
    MonoSources = unchecked((uint)0x1010),

    [NativeName("ALC_STEREO_SOURCES")]
    StereoSources = unchecked((uint)0x1011),

    [NativeName("ALC_CAPTURE_SAMPLES")]
    CaptureSamples = unchecked((uint)0x312),

    [NativeName("ALC_DEFAULT_FILTER_ORDER")]
    DefaultFilterOrder = unchecked((uint)0x1100),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_SOFT")]
    Hrtfsoft = unchecked((uint)0x1992),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_STATUS_SOFT")]
    HrtfStatussoft = unchecked((uint)0x1993),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_NUM_HRTF_SPECIFIERS_SOFT")]
    NumHrtfSpecifierssoft = unchecked((uint)0x1994),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_OUTPUT_LIMITER_SOFT")]
    OutputLimitersoft = unchecked((uint)0x199A),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_DEVICE_CLOCK_SOFT")]
    DeviceClocksoft = unchecked((uint)0x1600),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_DEVICE_LATENCY_SOFT")]
    DeviceLatencysoft = unchecked((uint)0x1601),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_DEVICE_CLOCK_LATENCY_SOFT")]
    DeviceClockLatencysoft = unchecked((uint)0x1602),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_MAX_AMBISONIC_ORDER_SOFT")]
    MaxAmbisonicOrdersoft = unchecked((uint)0x199B),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_OUTPUT_MODE_SOFT")]
    OutputModesoft = unchecked((uint)0x19AC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("ALC_CONTEXT_FLAGS_EXT")]
    ContextFlagsext = unchecked((uint)0x19CF),
}
