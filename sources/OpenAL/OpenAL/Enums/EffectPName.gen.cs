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

[NativeName("EffectPName")]
public enum EffectPName : uint
{
    [NativeName("AL_REVERB_DENSITY")]
    ReverbDensity = 1,

    [NativeName("AL_REVERB_DIFFUSION")]
    ReverbDiffusion = 2,

    [NativeName("AL_REVERB_GAIN")]
    ReverbGain = 3,

    [NativeName("AL_REVERB_GAINHF")]
    ReverbGainhf = 4,

    [NativeName("AL_REVERB_DECAY_TIME")]
    ReverbDecayTime = 5,

    [NativeName("AL_REVERB_DECAY_HFRATIO")]
    ReverbDecayHfratio = 6,

    [NativeName("AL_REVERB_REFLECTIONS_GAIN")]
    ReverbReflectionsGain = 7,

    [NativeName("AL_REVERB_REFLECTIONS_DELAY")]
    ReverbReflectionsDelay = 8,

    [NativeName("AL_REVERB_LATE_REVERB_GAIN")]
    ReverbLateReverbGain = 9,

    [NativeName("AL_REVERB_LATE_REVERB_DELAY")]
    ReverbLateReverbDelay = 10,

    [NativeName("AL_REVERB_AIR_ABSORPTION_GAINHF")]
    ReverbAirAbsorptionGainhf = 11,

    [NativeName("AL_REVERB_ROOM_ROLLOFF_FACTOR")]
    ReverbRoomRolloffFactor = 12,

    [NativeName("AL_REVERB_DECAY_HFLIMIT")]
    ReverbDecayHflimit = 13,

    [NativeName("AL_EAXREVERB_DENSITY")]
    EaxreverbDensity = 1,

    [NativeName("AL_EAXREVERB_DIFFUSION")]
    EaxreverbDiffusion = 2,

    [NativeName("AL_EAXREVERB_GAIN")]
    EaxreverbGain = 3,

    [NativeName("AL_EAXREVERB_GAINHF")]
    EaxreverbGainhf = 4,

    [NativeName("AL_EAXREVERB_GAINLF")]
    EaxreverbGainlf = 5,

    [NativeName("AL_EAXREVERB_DECAY_TIME")]
    EaxreverbDecayTime = 6,

    [NativeName("AL_EAXREVERB_DECAY_HFRATIO")]
    EaxreverbDecayHfratio = 7,

    [NativeName("AL_EAXREVERB_DECAY_LFRATIO")]
    EaxreverbDecayLfratio = 8,

    [NativeName("AL_EAXREVERB_REFLECTIONS_GAIN")]
    EaxreverbReflectionsGain = 9,

    [NativeName("AL_EAXREVERB_REFLECTIONS_DELAY")]
    EaxreverbReflectionsDelay = 10,

    [NativeName("AL_EAXREVERB_REFLECTIONS_PAN")]
    EaxreverbReflectionsPan = 11,

    [NativeName("AL_EAXREVERB_LATE_REVERB_GAIN")]
    EaxreverbLateReverbGain = 12,

    [NativeName("AL_EAXREVERB_LATE_REVERB_DELAY")]
    EaxreverbLateReverbDelay = 13,

    [NativeName("AL_EAXREVERB_LATE_REVERB_PAN")]
    EaxreverbLateReverbPan = 14,

    [NativeName("AL_EAXREVERB_ECHO_TIME")]
    EaxreverbEchoTime = 15,

    [NativeName("AL_EAXREVERB_ECHO_DEPTH")]
    EaxreverbEchoDepth = 16,

    [NativeName("AL_EAXREVERB_MODULATION_TIME")]
    EaxreverbModulationTime = 17,

    [NativeName("AL_EAXREVERB_MODULATION_DEPTH")]
    EaxreverbModulationDepth = 18,

    [NativeName("AL_EAXREVERB_AIR_ABSORPTION_GAINHF")]
    EaxreverbAirAbsorptionGainhf = 19,

    [NativeName("AL_EAXREVERB_HFREFERENCE")]
    EaxreverbHfreference = 20,

    [NativeName("AL_EAXREVERB_LFREFERENCE")]
    EaxreverbLfreference = 21,

    [NativeName("AL_EAXREVERB_ROOM_ROLLOFF_FACTOR")]
    EaxreverbRoomRolloffFactor = 22,

    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    EaxreverbDecayHflimit = 23,

    [NativeName("AL_CHORUS_WAVEFORM")]
    ChorusWaveform = 1,

    [NativeName("AL_CHORUS_PHASE")]
    ChorusPhase = 2,

    [NativeName("AL_CHORUS_RATE")]
    ChorusRate = 3,

    [NativeName("AL_CHORUS_DEPTH")]
    ChorusDepth = 4,

    [NativeName("AL_CHORUS_FEEDBACK")]
    ChorusFeedback = 5,

    [NativeName("AL_CHORUS_DELAY")]
    ChorusDelay = 6,

    [NativeName("AL_DISTORTION_EDGE")]
    DistortionEdge = 1,

    [NativeName("AL_DISTORTION_GAIN")]
    DistortionGain = 2,

    [NativeName("AL_DISTORTION_LOWPASS_CUTOFF")]
    DistortionLowpassCutoff = 3,

    [NativeName("AL_DISTORTION_EQCENTER")]
    DistortionEqcenter = 4,

    [NativeName("AL_DISTORTION_EQBANDWIDTH")]
    DistortionEqbandwidth = 5,

    [NativeName("AL_ECHO_DELAY")]
    EchoDelay = 1,

    [NativeName("AL_ECHO_LRDELAY")]
    EchoLrdelay = 2,

    [NativeName("AL_ECHO_DAMPING")]
    EchoDamping = 3,

    [NativeName("AL_ECHO_FEEDBACK")]
    EchoFeedback = 4,

    [NativeName("AL_ECHO_SPREAD")]
    EchoSpread = 5,

    [NativeName("AL_FLANGER_WAVEFORM")]
    FlangerWaveform = 1,

    [NativeName("AL_FLANGER_PHASE")]
    FlangerPhase = 2,

    [NativeName("AL_FLANGER_RATE")]
    FlangerRate = 3,

    [NativeName("AL_FLANGER_DEPTH")]
    FlangerDepth = 4,

    [NativeName("AL_FLANGER_FEEDBACK")]
    FlangerFeedback = 5,

    [NativeName("AL_FLANGER_DELAY")]
    FlangerDelay = 6,

    [NativeName("AL_FREQUENCY_SHIFTER_FREQUENCY")]
    FrequencyShifterFrequency = 1,

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

    [NativeName("AL_VOCAL_MORPHER_RATE")]
    VocalMorpherRate = 6,

    [NativeName("AL_PITCH_SHIFTER_COARSE_TUNE")]
    PitchShifterCoarseTune = 1,

    [NativeName("AL_PITCH_SHIFTER_FINE_TUNE")]
    PitchShifterFineTune = 2,

    [NativeName("AL_RING_MODULATOR_FREQUENCY")]
    RingModulatorFrequency = 1,

    [NativeName("AL_RING_MODULATOR_HIGHPASS_CUTOFF")]
    RingModulatorHighpassCutoff = 2,

    [NativeName("AL_RING_MODULATOR_WAVEFORM")]
    RingModulatorWaveform = 3,

    [NativeName("AL_AUTOWAH_ATTACK_TIME")]
    AutowahAttackTime = 1,

    [NativeName("AL_AUTOWAH_RELEASE_TIME")]
    AutowahReleaseTime = 2,

    [NativeName("AL_AUTOWAH_RESONANCE")]
    AutowahResonance = 3,

    [NativeName("AL_AUTOWAH_PEAK_GAIN")]
    AutowahPeakGain = 4,

    [NativeName("AL_COMPRESSOR_ONOFF")]
    CompressorOnoff = 1,

    [NativeName("AL_EQUALIZER_LOW_GAIN")]
    EqualizerLowGain = 1,

    [NativeName("AL_EQUALIZER_LOW_CUTOFF")]
    EqualizerLowCutoff = 2,

    [NativeName("AL_EQUALIZER_MID1_GAIN")]
    EqualizerMid1Gain = 3,

    [NativeName("AL_EQUALIZER_MID1_CENTER")]
    EqualizerMid1Center = 4,

    [NativeName("AL_EQUALIZER_MID1_WIDTH")]
    EqualizerMid1Width = 5,

    [NativeName("AL_EQUALIZER_MID2_GAIN")]
    EqualizerMid2Gain = 6,

    [NativeName("AL_EQUALIZER_MID2_CENTER")]
    EqualizerMid2Center = 7,

    [NativeName("AL_EQUALIZER_MID2_WIDTH")]
    EqualizerMid2Width = 8,

    [NativeName("AL_EQUALIZER_HIGH_GAIN")]
    EqualizerHighGain = 9,

    [NativeName("AL_EQUALIZER_HIGH_CUTOFF")]
    EqualizerHighCutoff = 10,

    [NativeName("AL_EFFECT_TYPE")]
    EffectType = 32769,

    [NativeName("AL_DEDICATED_GAIN")]
    DedicatedGain = 1,
}
