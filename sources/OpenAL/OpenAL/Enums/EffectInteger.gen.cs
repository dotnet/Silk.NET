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

[NativeName("EffectInteger")]
public enum EffectInteger : uint
{
    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    EaxreverbDecayHflimit = 23,

    [NativeName("AL_CHORUS_WAVEFORM")]
    ChorusWaveform = 1,

    [NativeName("AL_CHORUS_PHASE")]
    ChorusPhase = 2,

    [NativeName("AL_FREQUENCY_SHIFTER_LEFT_DIRECTION")]
    FrequencyShifterLeftDirection = 2,

    [NativeName("AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION")]
    FrequencyShifterRightDirection = 3,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA")]
    VocalMorpherPhonemea = 1,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING")]
    VocalMorpherPhonemeaCoarseTuning = 2,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB")]
    VocalMorpherPhonemeb = 3,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING")]
    VocalMorpherPhonemebCoarseTuning = 4,

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM")]
    VocalMorpherWaveform = 5,

    [NativeName("AL_RING_MODULATOR_WAVEFORM")]
    RingModulatorWaveform = 3,

    [NativeName("AL_COMPRESSOR_ONOFF")]
    CompressorOnoff = 1,

    [NativeName("AL_EFFECT_TYPE")]
    EffectType = 32769,
}
