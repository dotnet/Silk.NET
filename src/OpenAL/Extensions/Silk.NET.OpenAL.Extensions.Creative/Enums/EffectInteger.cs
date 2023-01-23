// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// A list of valid Int32 Effect/GetEffect parameters.
    /// </summary>
    public enum EffectInteger
    {
        /// <summary>
        /// This property sets the waveform shape of the low-frequency oscillator that controls the delay time of the
        /// delayed signals. Unit: (0) Sinusoid, (1) Triangle Range [0 .. 1] Default: 1
        /// </summary>
        ChorusWaveform = 0x0001,

        /// <summary>
        /// This property controls the phase difference between the left and right low-frequency oscillators. At zero
        /// degrees the two low-frequency oscillators are synchronized. Unit: Degrees Range [-180 .. 180] Default: 90
        /// </summary>
        ChorusPhase = 0x0002,

        /// <summary>
        /// Selects the shape of the low-frequency oscillator waveform that controls the amount of the delay of the
        /// sampled signal. Unit: (0) Sinusoid, (1) Triangle Range [0 .. 1] Default: 1
        /// </summary>
        FlangerWaveform = 0x0001,

        /// <summary>
        /// This changes the phase difference between the left and right low-frequency oscillator's. At zero degrees the
        /// two low-frequency oscillators are synchronized. Range [-180 .. +180] Default: 0
        /// </summary>
        FlangerPhase = 0x0002,

        /// <summary>
        /// These select which internal signals are added together to produce the output. Unit: (0) Down, (1) Up, (2) Off
        /// Range [0 .. 2] Default: 0
        /// </summary>
        FrequencyShifterLeftDirection = 0x0002,

        /// <summary>
        /// These select which internal signals are added together to produce the output. Unit: (0) Down, (1) Up, (2) Off
        /// Range [0 .. 2] Default: 0
        /// </summary>
        FrequencyShifterRightDirection = 0x0003,

        /// <summary>
        /// Sets the vocal morpher 4-band formant filter A, used to impose vocal tract effects upon the input signal. The
        /// vocal morpher is not necessarily intended for use on voice signals; it is primarily intended for pitched noise
        /// effects, vocal-like wind effects, etc. Unit: Use enum EfxFormantFilterSettings Range [0 .. 29] Default: 0, "Phoneme
        /// A"
        /// </summary>
        VocalMorpherPhonemeA = 0x0001,

        /// <summary>
        /// This is used to adjust the pitch of phoneme filter A in 1-semitone increments. Unit: Semitones Range [-24 ..
        /// +24] Default: 0
        /// </summary>
        VocalMorpherPhonemeACoarseTuning = 0x0002,

        /// <summary>
        /// Sets the vocal morpher 4-band formant filter B, used to impose vocal tract effects upon the input signal. The
        /// vocal morpher is not necessarily intended for use on voice signals; it is primarily intended for pitched noise
        /// effects, vocal-like wind effects, etc. Unit: Use enum EfxFormantFilterSettings Range [0 .. 29] Default: 10,
        /// "Phoneme ER"
        /// </summary>
        VocalMorpherPhonemeB = 0x0003,

        /// <summary>
        /// This is used to adjust the pitch of phoneme filter B in 1-semitone increments. Unit: Semitones Range [-24 ..
        /// +24] Default: 0
        /// </summary>
        VocalMorpherPhonemeBCoarseTuning = 0x0004,

        /// <summary>
        /// This controls the shape of the low-frequency oscillator used to morph between the two phoneme filters. Unit:
        /// (0) Sinusoid, (1) Triangle, (2) Sawtooth Range [0 .. 2] Default: 0
        /// </summary>
        VocalMorpherWaveform = 0x0005,

        /// <summary>
        /// This sets the number of semitones by which the pitch is shifted. There are 12 semitones per octave. Unit:
        /// Semitones Range [-12 .. +12] Default: +12
        /// </summary>
        PitchShifterCoarseTune = 0x0001,

        /// <summary>
        /// This sets the number of cents between Semitones a pitch is shifted. A Cent is 1/100th of a Semitone. Unit:
        /// Cents Range [-50 .. +50] Default: 0
        /// </summary>
        PitchShifterFineTune = 0x0002,

        /// <summary>
        /// This controls which waveform is used as the carrier signal. Traditional ring modulator and tremolo effects
        /// generally use a sinusoidal carrier. Unit: (0) Sinusoid, (1) Sawtooth, (2) Square Range [0 .. 2] Default: 0
        /// </summary>
        RingModulatorWaveform = 0x0003,

        /// <summary>
        /// Enabling this will result in audio exhibiting smaller variation in intensity between the loudest and quietest
        /// portions. Unit: (0) Off, (1) On Range [0 .. 1] Default: 1
        /// </summary>
        CompressorOnoff = 0x0001,

        /// <summary>
        /// When this flag is set, the high-frequency decay time automatically stays below a limit value that's derived
        /// from the setting of the property Air Absorption HF. Unit: (0) False, (1) True Range [False, True] Default: True
        /// </summary>
        ReverbDecayHFLimit = 0x000D,

        /// <summary>
        /// When this flag is set, the high-frequency decay time automatically stays below a limit value that's derived
        /// from the setting of the property AirAbsorptionGainHF. Unit: (0) False, (1) True Range [False, True] Default: True
        /// </summary>
        EaxReverbDecayHFLimit = 0x0017,

        /// <summary>
        /// Used with the enum EfxEffectType as its parameter.
        /// </summary>
        EffectType = 0x8001
    }
}