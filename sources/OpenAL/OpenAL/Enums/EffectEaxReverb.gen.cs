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
public enum EffectEaxReverb : uint
{
    [NativeName("AL_EAXREVERB_DENSITY")]
    Density = unchecked((uint)0x0001),

    [NativeName("AL_EAXREVERB_DIFFUSION")]
    Diffusion = unchecked((uint)0x0002),

    [NativeName("AL_EAXREVERB_GAIN")]
    Gain = unchecked((uint)0x0003),

    [NativeName("AL_EAXREVERB_GAINHF")]
    Gainhf = unchecked((uint)0x0004),

    [NativeName("AL_EAXREVERB_GAINLF")]
    Gainlf = unchecked((uint)0x0005),

    [NativeName("AL_EAXREVERB_DECAY_TIME")]
    DecayTime = unchecked((uint)0x0006),

    [NativeName("AL_EAXREVERB_DECAY_HFRATIO")]
    DecayHfratio = unchecked((uint)0x0007),

    [NativeName("AL_EAXREVERB_DECAY_LFRATIO")]
    DecayLfratio = unchecked((uint)0x0008),

    [NativeName("AL_EAXREVERB_REFLECTIONS_GAIN")]
    ReflectionsGain = unchecked((uint)0x0009),

    [NativeName("AL_EAXREVERB_REFLECTIONS_DELAY")]
    ReflectionsDelay = unchecked((uint)0x000A),

    [NativeName("AL_EAXREVERB_REFLECTIONS_PAN")]
    ReflectionsPan = unchecked((uint)0x000B),

    [NativeName("AL_EAXREVERB_LATE_REVERB_GAIN")]
    LateReverbGain = unchecked((uint)0x000C),

    [NativeName("AL_EAXREVERB_LATE_REVERB_DELAY")]
    LateReverbDelay = unchecked((uint)0x000D),

    [NativeName("AL_EAXREVERB_LATE_REVERB_PAN")]
    LateReverbPan = unchecked((uint)0x000E),

    [NativeName("AL_EAXREVERB_ECHO_TIME")]
    EchoTime = unchecked((uint)0x000F),

    [NativeName("AL_EAXREVERB_ECHO_DEPTH")]
    EchoDepth = unchecked((uint)0x0010),

    [NativeName("AL_EAXREVERB_MODULATION_TIME")]
    ModulationTime = unchecked((uint)0x0011),

    [NativeName("AL_EAXREVERB_MODULATION_DEPTH")]
    ModulationDepth = unchecked((uint)0x0012),

    [NativeName("AL_EAXREVERB_AIR_ABSORPTION_GAINHF")]
    AirAbsorptionGainhf = unchecked((uint)0x0013),

    [NativeName("AL_EAXREVERB_HFREFERENCE")]
    Hfreference = unchecked((uint)0x0014),

    [NativeName("AL_EAXREVERB_LFREFERENCE")]
    Lfreference = unchecked((uint)0x0015),

    [NativeName("AL_EAXREVERB_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = unchecked((uint)0x0016),

    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    DecayHflimit = unchecked((uint)0x0017),
}
