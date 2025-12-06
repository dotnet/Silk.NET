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

[NativeName("EffectEAXReverb")]
public enum EffectEAXReverb : uint
{
    [NativeName("AL_EAXREVERB_DENSITY")]
    Density = 1,

    [NativeName("AL_EAXREVERB_DIFFUSION")]
    Diffusion = 2,

    [NativeName("AL_EAXREVERB_GAIN")]
    Gain = 3,

    [NativeName("AL_EAXREVERB_GAINHF")]
    Gainhf = 4,

    [NativeName("AL_EAXREVERB_GAINLF")]
    Gainlf = 5,

    [NativeName("AL_EAXREVERB_DECAY_TIME")]
    DecayTime = 6,

    [NativeName("AL_EAXREVERB_DECAY_HFRATIO")]
    DecayHfratio = 7,

    [NativeName("AL_EAXREVERB_DECAY_LFRATIO")]
    DecayLfratio = 8,

    [NativeName("AL_EAXREVERB_REFLECTIONS_GAIN")]
    ReflectionsGain = 9,

    [NativeName("AL_EAXREVERB_REFLECTIONS_DELAY")]
    ReflectionsDelay = 10,

    [NativeName("AL_EAXREVERB_REFLECTIONS_PAN")]
    ReflectionsPan = 11,

    [NativeName("AL_EAXREVERB_LATE_REVERB_GAIN")]
    LateReverbGain = 12,

    [NativeName("AL_EAXREVERB_LATE_REVERB_DELAY")]
    LateReverbDelay = 13,

    [NativeName("AL_EAXREVERB_LATE_REVERB_PAN")]
    LateReverbPan = 14,

    [NativeName("AL_EAXREVERB_ECHO_TIME")]
    EchoTime = 15,

    [NativeName("AL_EAXREVERB_ECHO_DEPTH")]
    EchoDepth = 16,

    [NativeName("AL_EAXREVERB_MODULATION_TIME")]
    ModulationTime = 17,

    [NativeName("AL_EAXREVERB_MODULATION_DEPTH")]
    ModulationDepth = 18,

    [NativeName("AL_EAXREVERB_AIR_ABSORPTION_GAINHF")]
    AirAbsorptionGainhf = 19,

    [NativeName("AL_EAXREVERB_HFREFERENCE")]
    Hfreference = 20,

    [NativeName("AL_EAXREVERB_LFREFERENCE")]
    Lfreference = 21,

    [NativeName("AL_EAXREVERB_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = 22,

    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    DecayHflimit = 23,
}
