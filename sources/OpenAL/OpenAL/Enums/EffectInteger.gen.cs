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
[Transformed]
public enum EffectInteger : uint
{
    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    EaxreverbDecayHflimit = unchecked((uint)0x0017),

    [NativeName("AL_CHORUS_WAVEFORM")]
    ChorusWaveform = unchecked((uint)0x0001),

    [NativeName("AL_CHORUS_PHASE")]
    ChorusPhase = unchecked((uint)0x0002),

    [NativeName("AL_FREQUENCY_SHIFTER_LEFT_DIRECTION")]
    FrequencyShifterLeftDirection = unchecked((uint)0x0002),

    [NativeName("AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION")]
    FrequencyShifterRightDirection = unchecked((uint)0x0003),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA")]
    VocalMorpherPhonemea = unchecked((uint)0x0001),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING")]
    VocalMorpherPhonemeaCoarseTuning = unchecked((uint)0x0002),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB")]
    VocalMorpherPhonemeb = unchecked((uint)0x0003),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING")]
    VocalMorpherPhonemebCoarseTuning = unchecked((uint)0x0004),

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM")]
    VocalMorpherWaveform = unchecked((uint)0x0005),

    [NativeName("AL_RING_MODULATOR_WAVEFORM")]
    RingModulatorWaveform = unchecked((uint)0x0003),

    [NativeName("AL_COMPRESSOR_ONOFF")]
    CompressorOnoff = unchecked((uint)0x0001),

    [NativeName("AL_EFFECT_TYPE")]
    EffectType = unchecked((uint)0x8001),
}
