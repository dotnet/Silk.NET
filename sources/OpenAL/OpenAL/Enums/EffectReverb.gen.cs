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
public enum EffectReverb : uint
{
    [NativeName("AL_REVERB_DENSITY")]
    Density = 1,

    [NativeName("AL_REVERB_DIFFUSION")]
    Diffusion = 2,

    [NativeName("AL_REVERB_GAIN")]
    Gain = 3,

    [NativeName("AL_REVERB_GAINHF")]
    Gainhf = 4,

    [NativeName("AL_REVERB_DECAY_TIME")]
    DecayTime = 5,

    [NativeName("AL_REVERB_DECAY_HFRATIO")]
    DecayHfratio = 6,

    [NativeName("AL_REVERB_REFLECTIONS_GAIN")]
    ReflectionsGain = 7,

    [NativeName("AL_REVERB_REFLECTIONS_DELAY")]
    ReflectionsDelay = 8,

    [NativeName("AL_REVERB_LATE_REVERB_GAIN")]
    LateReverbGain = 9,

    [NativeName("AL_REVERB_LATE_REVERB_DELAY")]
    LateReverbDelay = 10,

    [NativeName("AL_REVERB_AIR_ABSORPTION_GAINHF")]
    AirAbsorptionGainhf = 11,

    [NativeName("AL_REVERB_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = 12,

    [NativeName("AL_REVERB_DECAY_HFLIMIT")]
    DecayHflimit = 13,
}
