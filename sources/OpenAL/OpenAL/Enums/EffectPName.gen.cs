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
[Transformed]
public enum EffectPName : uint
{
    [NativeName("AL_REVERB_DENSITY")]
    ReverbDensity = unchecked((uint)0x0001),

    [NativeName("AL_REVERB_DIFFUSION")]
    ReverbDiffusion = unchecked((uint)0x0002),

    [NativeName("AL_REVERB_GAIN")]
    ReverbGain = unchecked((uint)0x0003),

    [NativeName("AL_REVERB_GAINHF")]
    ReverbGainhf = unchecked((uint)0x0004),

    [NativeName("AL_REVERB_DECAY_TIME")]
    ReverbDecayTime = unchecked((uint)0x0005),

    [NativeName("AL_REVERB_DECAY_HFRATIO")]
    ReverbDecayHfratio = unchecked((uint)0x0006),

    [NativeName("AL_REVERB_REFLECTIONS_GAIN")]
    ReverbReflectionsGain = unchecked((uint)0x0007),

    [NativeName("AL_REVERB_REFLECTIONS_DELAY")]
    ReverbReflectionsDelay = unchecked((uint)0x0008),

    [NativeName("AL_REVERB_LATE_REVERB_GAIN")]
    ReverbLateReverbGain = unchecked((uint)0x0009),

    [NativeName("AL_REVERB_LATE_REVERB_DELAY")]
    ReverbLateReverbDelay = unchecked((uint)0x000A),

    [NativeName("AL_REVERB_AIR_ABSORPTION_GAINHF")]
    ReverbAirAbsorptionGainhf = unchecked((uint)0x000B),

    [NativeName("AL_REVERB_ROOM_ROLLOFF_FACTOR")]
    ReverbRoomRolloffFactor = unchecked((uint)0x000C),

    [NativeName("AL_REVERB_DECAY_HFLIMIT")]
    ReverbDecayHflimit = unchecked((uint)0x000D),

    [NativeName("AL_EAXREVERB_DENSITY")]
    EaxreverbDensity = unchecked((uint)0x0001),

    [NativeName("AL_EAXREVERB_DIFFUSION")]
    EaxreverbDiffusion = unchecked((uint)0x0002),

    [NativeName("AL_EAXREVERB_GAIN")]
    EaxreverbGain = unchecked((uint)0x0003),

    [NativeName("AL_EAXREVERB_GAINHF")]
    EaxreverbGainhf = unchecked((uint)0x0004),

    [NativeName("AL_EAXREVERB_GAINLF")]
    EaxreverbGainlf = unchecked((uint)0x0005),

    [NativeName("AL_EAXREVERB_DECAY_TIME")]
    EaxreverbDecayTime = unchecked((uint)0x0006),

    [NativeName("AL_EAXREVERB_DECAY_HFRATIO")]
    EaxreverbDecayHfratio = unchecked((uint)0x0007),

    [NativeName("AL_EAXREVERB_DECAY_LFRATIO")]
    EaxreverbDecayLfratio = unchecked((uint)0x0008),

    [NativeName("AL_EAXREVERB_REFLECTIONS_GAIN")]
    EaxreverbReflectionsGain = unchecked((uint)0x0009),

    [NativeName("AL_EAXREVERB_REFLECTIONS_DELAY")]
    EaxreverbReflectionsDelay = unchecked((uint)0x000A),

    [NativeName("AL_EAXREVERB_REFLECTIONS_PAN")]
    EaxreverbReflectionsPan = unchecked((uint)0x000B),

    [NativeName("AL_EAXREVERB_LATE_REVERB_GAIN")]
    EaxreverbLateReverbGain = unchecked((uint)0x000C),

    [NativeName("AL_EAXREVERB_LATE_REVERB_DELAY")]
    EaxreverbLateReverbDelay = unchecked((uint)0x000D),

    [NativeName("AL_EAXREVERB_LATE_REVERB_PAN")]
    EaxreverbLateReverbPan = unchecked((uint)0x000E),

    [NativeName("AL_EAXREVERB_ECHO_TIME")]
    EaxreverbEchoTime = unchecked((uint)0x000F),

    [NativeName("AL_EAXREVERB_ECHO_DEPTH")]
    EaxreverbEchoDepth = unchecked((uint)0x0010),

    [NativeName("AL_EAXREVERB_MODULATION_TIME")]
    EaxreverbModulationTime = unchecked((uint)0x0011),

    [NativeName("AL_EAXREVERB_MODULATION_DEPTH")]
    EaxreverbModulationDepth = unchecked((uint)0x0012),

    [NativeName("AL_EAXREVERB_AIR_ABSORPTION_GAINHF")]
    EaxreverbAirAbsorptionGainhf = unchecked((uint)0x0013),

    [NativeName("AL_EAXREVERB_HFREFERENCE")]
    EaxreverbHfreference = unchecked((uint)0x0014),

    [NativeName("AL_EAXREVERB_LFREFERENCE")]
    EaxreverbLfreference = unchecked((uint)0x0015),

    [NativeName("AL_EAXREVERB_ROOM_ROLLOFF_FACTOR")]
    EaxreverbRoomRolloffFactor = unchecked((uint)0x0016),

    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    EaxreverbDecayHflimit = unchecked((uint)0x0017),

    [NativeName("AL_CHORUS_WAVEFORM")]
    ChorusWaveform = unchecked((uint)0x0001),

    [NativeName("AL_CHORUS_PHASE")]
    ChorusPhase = unchecked((uint)0x0002),

    [NativeName("AL_CHORUS_RATE")]
    ChorusRate = unchecked((uint)0x0003),

    [NativeName("AL_CHORUS_DEPTH")]
    ChorusDepth = unchecked((uint)0x0004),

    [NativeName("AL_CHORUS_FEEDBACK")]
    ChorusFeedback = unchecked((uint)0x0005),

    [NativeName("AL_CHORUS_DELAY")]
    ChorusDelay = unchecked((uint)0x0006),

    [NativeName("AL_DISTORTION_EDGE")]
    DistortionEdge = unchecked((uint)0x0001),

    [NativeName("AL_DISTORTION_GAIN")]
    DistortionGain = unchecked((uint)0x0002),

    [NativeName("AL_DISTORTION_LOWPASS_CUTOFF")]
    DistortionLowpassCutoff = unchecked((uint)0x0003),

    [NativeName("AL_DISTORTION_EQCENTER")]
    DistortionEqcenter = unchecked((uint)0x0004),

    [NativeName("AL_DISTORTION_EQBANDWIDTH")]
    DistortionEqbandwidth = unchecked((uint)0x0005),

    [NativeName("AL_ECHO_DELAY")]
    EchoDelay = unchecked((uint)0x0001),

    [NativeName("AL_ECHO_LRDELAY")]
    EchoLrdelay = unchecked((uint)0x0002),

    [NativeName("AL_ECHO_DAMPING")]
    EchoDamping = unchecked((uint)0x0003),

    [NativeName("AL_ECHO_FEEDBACK")]
    EchoFeedback = unchecked((uint)0x0004),

    [NativeName("AL_ECHO_SPREAD")]
    EchoSpread = unchecked((uint)0x0005),

    [NativeName("AL_FLANGER_WAVEFORM")]
    FlangerWaveform = unchecked((uint)0x0001),

    [NativeName("AL_FLANGER_PHASE")]
    FlangerPhase = unchecked((uint)0x0002),

    [NativeName("AL_FLANGER_RATE")]
    FlangerRate = unchecked((uint)0x0003),

    [NativeName("AL_FLANGER_DEPTH")]
    FlangerDepth = unchecked((uint)0x0004),

    [NativeName("AL_FLANGER_FEEDBACK")]
    FlangerFeedback = unchecked((uint)0x0005),

    [NativeName("AL_FLANGER_DELAY")]
    FlangerDelay = unchecked((uint)0x0006),

    [NativeName("AL_FREQUENCY_SHIFTER_FREQUENCY")]
    FrequencyShifterFrequency = unchecked((uint)0x0001),

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

    [NativeName("AL_VOCAL_MORPHER_RATE")]
    VocalMorpherRate = unchecked((uint)0x0006),

    [NativeName("AL_PITCH_SHIFTER_COARSE_TUNE")]
    PitchShifterCoarseTune = unchecked((uint)0x0001),

    [NativeName("AL_PITCH_SHIFTER_FINE_TUNE")]
    PitchShifterFineTune = unchecked((uint)0x0002),

    [NativeName("AL_RING_MODULATOR_FREQUENCY")]
    RingModulatorFrequency = unchecked((uint)0x0001),

    [NativeName("AL_RING_MODULATOR_HIGHPASS_CUTOFF")]
    RingModulatorHighpassCutoff = unchecked((uint)0x0002),

    [NativeName("AL_RING_MODULATOR_WAVEFORM")]
    RingModulatorWaveform = unchecked((uint)0x0003),

    [NativeName("AL_AUTOWAH_ATTACK_TIME")]
    AutowahAttackTime = unchecked((uint)0x0001),

    [NativeName("AL_AUTOWAH_RELEASE_TIME")]
    AutowahReleaseTime = unchecked((uint)0x0002),

    [NativeName("AL_AUTOWAH_RESONANCE")]
    AutowahResonance = unchecked((uint)0x0003),

    [NativeName("AL_AUTOWAH_PEAK_GAIN")]
    AutowahPeakGain = unchecked((uint)0x0004),

    [NativeName("AL_COMPRESSOR_ONOFF")]
    CompressorOnoff = unchecked((uint)0x0001),

    [NativeName("AL_EQUALIZER_LOW_GAIN")]
    EqualizerLowGain = unchecked((uint)0x0001),

    [NativeName("AL_EQUALIZER_LOW_CUTOFF")]
    EqualizerLowCutoff = unchecked((uint)0x0002),

    [NativeName("AL_EQUALIZER_MID1_GAIN")]
    EqualizerMid1Gain = unchecked((uint)0x0003),

    [NativeName("AL_EQUALIZER_MID1_CENTER")]
    EqualizerMid1Center = unchecked((uint)0x0004),

    [NativeName("AL_EQUALIZER_MID1_WIDTH")]
    EqualizerMid1Width = unchecked((uint)0x0005),

    [NativeName("AL_EQUALIZER_MID2_GAIN")]
    EqualizerMid2Gain = unchecked((uint)0x0006),

    [NativeName("AL_EQUALIZER_MID2_CENTER")]
    EqualizerMid2Center = unchecked((uint)0x0007),

    [NativeName("AL_EQUALIZER_MID2_WIDTH")]
    EqualizerMid2Width = unchecked((uint)0x0008),

    [NativeName("AL_EQUALIZER_HIGH_GAIN")]
    EqualizerHighGain = unchecked((uint)0x0009),

    [NativeName("AL_EQUALIZER_HIGH_CUTOFF")]
    EqualizerHighCutoff = unchecked((uint)0x000A),

    [NativeName("AL_EFFECT_TYPE")]
    EffectType = unchecked((uint)0x8001),

    [NativeName("AL_DEDICATED_GAIN")]
    DedicatedGain = unchecked((uint)0x0001),
}
