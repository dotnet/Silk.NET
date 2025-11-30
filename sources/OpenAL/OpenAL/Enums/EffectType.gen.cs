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

[NativeName("EffectType")]
[Transformed]
public enum EffectType : uint
{
    [NativeName("AL_EFFECT_NULL")]
    Null = unchecked((uint)0x0000),

    [NativeName("AL_EFFECT_REVERB")]
    Reverb = unchecked((uint)0x0001),

    [NativeName("AL_EFFECT_CHORUS")]
    Chorus = unchecked((uint)0x0002),

    [NativeName("AL_EFFECT_DISTORTION")]
    Distortion = unchecked((uint)0x0003),

    [NativeName("AL_EFFECT_ECHO")]
    Echo = unchecked((uint)0x0004),

    [NativeName("AL_EFFECT_FLANGER")]
    Flanger = unchecked((uint)0x0005),

    [NativeName("AL_EFFECT_FREQUENCY_SHIFTER")]
    FrequencyShifter = unchecked((uint)0x0006),

    [NativeName("AL_EFFECT_VOCAL_MORPHER")]
    VocalMorpher = unchecked((uint)0x0007),

    [NativeName("AL_EFFECT_PITCH_SHIFTER")]
    PitchShifter = unchecked((uint)0x0008),

    [NativeName("AL_EFFECT_RING_MODULATOR")]
    RingModulator = unchecked((uint)0x0009),

    [NativeName("AL_EFFECT_AUTOWAH")]
    Autowah = unchecked((uint)0x000A),

    [NativeName("AL_EFFECT_COMPRESSOR")]
    Compressor = unchecked((uint)0x000B),

    [NativeName("AL_EFFECT_EQUALIZER")]
    Equalizer = unchecked((uint)0x000C),

    [NativeName("AL_EFFECT_EAXREVERB")]
    Eaxreverb = unchecked((uint)0x8000),

    [NativeName("AL_EFFECT_DEDICATED_DIALOGUE")]
    DedicatedDialogue = unchecked((uint)0x9001),

    [NativeName("AL_EFFECT_DEDICATED_LOW_FREQUENCY_EFFECT")]
    DedicatedLowFrequencyEffect = unchecked((uint)0x9000),
}
