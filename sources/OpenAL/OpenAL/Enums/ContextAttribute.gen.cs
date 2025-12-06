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
public enum ContextAttribute : uint
{
    [NativeName("ALC_FREQUENCY")]
    Frequency = 4103,

    [NativeName("ALC_REFRESH")]
    Refresh = 4104,

    [NativeName("ALC_SYNC")]
    Sync = 4105,

    [NativeName("ALC_MONO_SOURCES")]
    MonoSources = 4112,

    [NativeName("ALC_STEREO_SOURCES")]
    StereoSources = 4113,

    [NativeName("ALC_FORMAT_CHANNELS_SOFT")]
    FormatChannelsSOFT = 6544,

    [NativeName("ALC_FORMAT_TYPE_SOFT")]
    FormatTypeSOFT = 6545,

    [NativeName("ALC_DEFAULT_FILTER_ORDER")]
    DefaultFilterOrder = 4352,

    [NativeName("ALC_HRTF_SOFT")]
    HrtfSOFT = 6546,

    [NativeName("ALC_HRTF_ID_SOFT")]
    HrtfIdSOFT = 6550,

    [NativeName("ALC_OUTPUT_LIMITER_SOFT")]
    OutputLimiterSOFT = 6554,

    [NativeName("ALC_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutSOFT = 6551,

    [NativeName("ALC_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingSOFT = 6552,

    [NativeName("ALC_AMBISONIC_ORDER_SOFT")]
    AmbisonicOrderSOFT = 6553,

    [NativeName("ALC_OUTPUT_MODE_SOFT")]
    OutputModeSOFT = 6572,
}
