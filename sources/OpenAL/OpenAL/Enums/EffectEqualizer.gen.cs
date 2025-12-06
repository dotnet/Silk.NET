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

[NativeName("EffectEqualizer")]
public enum EffectEqualizer : uint
{
    [NativeName("AL_EQUALIZER_LOW_GAIN")]
    LowGain = 1,

    [NativeName("AL_EQUALIZER_LOW_CUTOFF")]
    LowCutoff = 2,

    [NativeName("AL_EQUALIZER_MID1_GAIN")]
    Mid1Gain = 3,

    [NativeName("AL_EQUALIZER_MID1_CENTER")]
    Mid1Center = 4,

    [NativeName("AL_EQUALIZER_MID1_WIDTH")]
    Mid1Width = 5,

    [NativeName("AL_EQUALIZER_MID2_GAIN")]
    Mid2Gain = 6,

    [NativeName("AL_EQUALIZER_MID2_CENTER")]
    Mid2Center = 7,

    [NativeName("AL_EQUALIZER_MID2_WIDTH")]
    Mid2Width = 8,

    [NativeName("AL_EQUALIZER_HIGH_GAIN")]
    HighGain = 9,

    [NativeName("AL_EQUALIZER_HIGH_CUTOFF")]
    HighCutoff = 10,
}
