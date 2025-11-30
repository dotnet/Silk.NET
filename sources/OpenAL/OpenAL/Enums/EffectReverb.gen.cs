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

[NativeName("EffectReverb")]
[Transformed]
public enum EffectReverb : uint
{
    [NativeName("AL_REVERB_DENSITY")]
    Density = unchecked((uint)0x0001),

    [NativeName("AL_REVERB_DIFFUSION")]
    Diffusion = unchecked((uint)0x0002),

    [NativeName("AL_REVERB_GAIN")]
    Gain = unchecked((uint)0x0003),

    [NativeName("AL_REVERB_GAINHF")]
    Gainhf = unchecked((uint)0x0004),

    [NativeName("AL_REVERB_DECAY_TIME")]
    DecayTime = unchecked((uint)0x0005),

    [NativeName("AL_REVERB_DECAY_HFRATIO")]
    DecayHfratio = unchecked((uint)0x0006),

    [NativeName("AL_REVERB_REFLECTIONS_GAIN")]
    ReflectionsGain = unchecked((uint)0x0007),

    [NativeName("AL_REVERB_REFLECTIONS_DELAY")]
    ReflectionsDelay = unchecked((uint)0x0008),

    [NativeName("AL_REVERB_LATE_REVERB_GAIN")]
    LateReverbGain = unchecked((uint)0x0009),

    [NativeName("AL_REVERB_LATE_REVERB_DELAY")]
    LateReverbDelay = unchecked((uint)0x000A),

    [NativeName("AL_REVERB_AIR_ABSORPTION_GAINHF")]
    AirAbsorptionGainhf = unchecked((uint)0x000B),

    [NativeName("AL_REVERB_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = unchecked((uint)0x000C),

    [NativeName("AL_REVERB_DECAY_HFLIMIT")]
    DecayHflimit = unchecked((uint)0x000D),
}
