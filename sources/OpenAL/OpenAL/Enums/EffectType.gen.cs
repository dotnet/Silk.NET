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
public enum EffectType : uint
{
    [NativeName("AL_EFFECT_NULL")]
    Null = 0,

    [NativeName("AL_EFFECT_REVERB")]
    Reverb = 1,

    [NativeName("AL_EFFECT_CHORUS")]
    Chorus = 2,

    [NativeName("AL_EFFECT_DISTORTION")]
    Distortion = 3,

    [NativeName("AL_EFFECT_ECHO")]
    Echo = 4,

    [NativeName("AL_EFFECT_FLANGER")]
    Flanger = 5,

    [NativeName("AL_EFFECT_FREQUENCY_SHIFTER")]
    FrequencyShifter = 6,

    [NativeName("AL_EFFECT_VOCAL_MORPHER")]
    VocalMorpher = 7,

    [NativeName("AL_EFFECT_PITCH_SHIFTER")]
    PitchShifter = 8,

    [NativeName("AL_EFFECT_RING_MODULATOR")]
    RingModulator = 9,

    [NativeName("AL_EFFECT_AUTOWAH")]
    Autowah = 10,

    [NativeName("AL_EFFECT_COMPRESSOR")]
    Compressor = 11,

    [NativeName("AL_EFFECT_EQUALIZER")]
    Equalizer = 12,

    [NativeName("AL_EFFECT_EAXREVERB")]
    Eaxreverb = 32768,

    [NativeName("AL_EFFECT_DEDICATED_DIALOGUE")]
    DedicatedDialogue = 36865,

    [NativeName("AL_EFFECT_DEDICATED_LOW_FREQUENCY_EFFECT")]
    DedicatedLowFrequencyEffect = 36864,
}
