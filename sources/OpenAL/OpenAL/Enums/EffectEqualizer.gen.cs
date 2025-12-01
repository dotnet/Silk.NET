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
    LowGain = unchecked((uint)0x0001),

    [NativeName("AL_EQUALIZER_LOW_CUTOFF")]
    LowCutoff = unchecked((uint)0x0002),

    [NativeName("AL_EQUALIZER_MID1_GAIN")]
    Mid1Gain = unchecked((uint)0x0003),

    [NativeName("AL_EQUALIZER_MID1_CENTER")]
    Mid1Center = unchecked((uint)0x0004),

    [NativeName("AL_EQUALIZER_MID1_WIDTH")]
    Mid1Width = unchecked((uint)0x0005),

    [NativeName("AL_EQUALIZER_MID2_GAIN")]
    Mid2Gain = unchecked((uint)0x0006),

    [NativeName("AL_EQUALIZER_MID2_CENTER")]
    Mid2Center = unchecked((uint)0x0007),

    [NativeName("AL_EQUALIZER_MID2_WIDTH")]
    Mid2Width = unchecked((uint)0x0008),

    [NativeName("AL_EQUALIZER_HIGH_GAIN")]
    HighGain = unchecked((uint)0x0009),

    [NativeName("AL_EQUALIZER_HIGH_CUTOFF")]
    HighCutoff = unchecked((uint)0x000A),
}
