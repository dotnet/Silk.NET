// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// A list of valid 32-bit Float Effect/GetEffect parameters.
    /// </summary>
    public enum EffectFloat
    {
        /// <summary>
        /// Reverb Modal Density controls the coloration of the late reverb. Lowering the value adds more coloration to
        /// the late reverb. Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        ReverbDensity = 0x0001,

        /// <summary>
        /// The Reverb Diffusion property controls the echo density in the reverberation decay. The default 1.0f provides
        /// the highest density. Reducing diffusion gives the reverberation a more "grainy" character that is especially
        /// noticeable with percussive sound sources. If you set a diffusion value of 0.0f, the later reverberation sounds like
        /// a succession of distinct echoes. Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        ReverbDiffusion = 0x0002,

        /// <summary>
        /// The Reverb Gain property is the master volume control for the reflected sound - both early reflections and
        /// reverberation - that the reverb effect adds to all sound sources. Ranges from 1.0 (0db) (the maximum amount) to 0.0
        /// (-100db) (no reflected sound at all) are accepted. Units: Linear gain Range [0.0f .. 1.0f] Default: 0.32f
        /// </summary>
        ReverbGain = 0x0003,

        /// <summary>
        /// The Reverb Gain HF property further tweaks reflected sound by attenuating it at high frequencies. It controls
        /// a low-pass filter that applies globally to the reflected sound of all sound sources feeding the particular instance
        /// of the reverb effect. Ranges from 1.0f (0db) (no filter) to 0.0f (-100db) (virtually no reflected sound) are
        /// accepted. Units: Linear gain Range [0.0f .. 1.0f] Default: 0.89f
        /// </summary>
        ReverbGainHF = 0x0004,

        /// <summary>
        /// The Decay Time property sets the reverberation decay time. It ranges from 0.1f (typically a small room with
        /// very dead surfaces) to 20.0 (typically a large room with very live surfaces). Unit: Seconds Range [0.1f .. 20.0f]
        /// Default: 1.49f
        /// </summary>
        ReverbDecayTime = 0x0005,

        /// <summary>
        /// The Decay HF Ratio property sets the spectral quality of the Decay Time parameter. It is the ratio of
        /// high-frequency decay time relative to the time set by Decay Time.. Unit: linear multiplier Range [0.1f .. 2.0f]
        /// Default: 0.83f
        /// </summary>
        ReverbDecayHFRatio = 0x0006,

        /// <summary>
        /// The Reflections Gain property controls the overall amount of initial reflections relative to the Gain
        /// property. The value of Reflections Gain ranges from a maximum of 3.16f (+10 dB) to a minimum of 0.0f (-100 dB) (no
        /// initial reflections at all), and is corrected by the value of the Gain property. Unit: Linear gain Range [0.0f ..
        /// 3.16f] Default: 0.05f
        /// </summary>
        ReverbReflectionsGain = 0x0007,

        /// <summary>
        /// The Reflections Delay property is the amount of delay between the arrival time of the direct path from the
        /// source to the first reflection from the source. It ranges from 0 to 300 milliseconds. Unit: Seconds Range [0.0f ..
        /// 0.3f] Default: 0.007f
        /// </summary>
        ReverbReflectionsDelay = 0x0008,

        /// <summary>
        /// The Late Reverb Gain property controls the overall amount of later reverberation relative to the Gain
        /// property. The value of Late Reverb Gain ranges from a maximum of 10.0f (+20 dB) to a minimum of 0.0f (-100 dB) (no
        /// late reverberation at all). Unit: Linear gain Range [0.0f .. 10.0f] Default: 1.26f
        /// </summary>
        ReverbLateReverbGain = 0x0009,

        /// <summary>
        /// The Late Reverb Delay property defines the begin time of the late reverberation relative to the time of the
        /// initial reflection (the first of the early reflections). It ranges from 0 to 100 milliseconds. Unit: Seconds Range
        /// [0.0f .. 0.1f] Default: 0.011f
        /// </summary>
        ReverbLateReverbDelay = 0x000A,

        /// <summary>
        /// The Air Absorption Gain HF property controls the distance-dependent attenuation at high frequencies caused by
        /// the propagation medium and applies to reflected sound only. Unit: Linear gain per meter Range [0.892f .. 1.0f]
        /// Default: 0.994f
        /// </summary>
        ReverbAirAbsorptionGainHF = 0x000B,

        /// <summary>
        /// The Room Rolloff Factor property is one of two methods available to attenuate the reflected sound (containing
        /// both reflections and reverberation) according to source-listener distance. It's defined the same way as OpenAL's
        /// Rolloff Factor, but operates on reverb sound instead of direct-path sound. Unit: Linear multiplier Range [0.0f ..
        /// 10.0f] Default: 0.0f
        /// </summary>
        ReverbRoomRolloffFactor = 0x000C,

        /// <summary>
        /// This property sets the modulation rate of the low-frequency oscillator that controls the delay time of the
        /// delayed signals. Unit: Hz Range [0.0f .. 10.0f] Default: 1.1f
        /// </summary>
        ChorusRate = 0x0003,

        /// <summary>
        /// This property controls the amount by which the delay time is modulated by the low-frequency oscillator. Range
        /// [0.0f .. 1.0f] Default: 0.1f
        /// </summary>
        ChorusDepth = 0x0004,

        /// <summary>
        /// This property controls the amount of processed signal that is fed back to the input of the chorus effect.
        /// Negative values will reverse the phase of the feedback signal. At full magnitude the identical sample will repeat
        /// endlessly. Range [-1.0f .. +1.0f] Default: +0.25f
        /// </summary>
        ChorusFeedback = 0x0005,

        /// <summary>
        /// This property controls the average amount of time the sample is delayed before it is played back, and with
        /// feedback, the amount of time between iterations of the sample. Larger values lower the pitch. Unit: Seconds Range
        /// [0.0f .. 0.016f] Default: 0.016f
        /// </summary>
        ChorusDelay = 0x0006,

        /// <summary>
        /// This property controls the shape of the distortion. The higher the value for Edge, the "dirtier" and "fuzzier"
        /// the effect. Range [0.0f .. 1.0f] Default: 0.2f
        /// </summary>
        DistortionEdge = 0x0001,

        /// <summary>
        /// This property allows you to attenuate the distorted sound. Range [0.01f .. 1.0f] Default: 0.05f
        /// </summary>
        DistortionGain = 0x0002,

        /// <summary>
        /// Input signals can have a low pass filter applied, to limit the amount of high frequency signal feeding into
        /// the distortion effect. Unit: Hz Range [80.0f .. 24000.0f] Default: 8000.0f
        /// </summary>
        DistortionLowpassCutoff = 0x0003,

        /// <summary>
        /// This property controls the frequency at which the post-distortion attenuation (Distortion Gain) is active.
        /// Unit: Hz Range [80.0f .. 24000.0f] Default: 3600.0f
        /// </summary>
        DistortionEQCenter = 0x0004,

        /// <summary>
        /// This property controls the bandwidth of the post-distortion attenuation. Unit: Hz Range [80.0f .. 24000.0f]
        /// Default: 3600.0f
        /// </summary>
        DistortionEQBandwidth = 0x0005,

        /// <summary>
        /// This property controls the delay between the original sound and the first "tap", or echo instance.
        /// Subsequently, the value for Echo Delay is used to determine the time delay between each "second tap" and the next
        /// "first tap". Unit: Seconds Range [0.0f .. 0.207f] Default: 0.1f
        /// </summary>
        EchoDelay = 0x0001,

        /// <summary>
        /// This property controls the delay between the "first tap" and the "second tap". Subsequently, the value for
        /// Echo LR Delay is used to determine the time delay between each "first tap" and the next "second tap". Unit: Seconds
        /// Range [0.0f .. 0.404f] Default: 0.1f
        /// </summary>
        EchoLRDelay = 0x0002,

        /// <summary>
        /// This property controls the amount of high frequency damping applied to each echo. As the sound is subsequently
        /// fed back for further echoes, damping results in an echo which progressively gets softer in tone as well as
        /// intensity. Range [0.0f .. 0.99f] Default: 0.5f
        /// </summary>
        EchoDamping = 0x0003,

        /// <summary>
        /// This property controls the amount of feedback the output signal fed back into the input. Use this parameter to
        /// create "cascading" echoes. At full magnitude, the identical sample will repeat endlessly. Below full magnitude, the
        /// sample will repeat and fade. Range [0.0f .. 1.0f] Default: 0.5f
        /// </summary>
        EchoFeedback = 0x0004,

        /// <summary>
        /// This property controls how hard panned the individual echoes are. With a value of 1.0f, the first "tap" will
        /// be panned hard left, and the second "tap" hard right. –1.0f gives the opposite result and values near to 0.0f
        /// result in less emphasized panning. Range [-1.0f .. +1.0f] Default: -1.0f
        /// </summary>
        EchoSpread = 0x0005,

        /// <summary>
        /// The number of times per second the low-frequency oscillator controlling the amount of delay repeats. Range
        /// [0.0f .. 10.0f] Default: 0.27f
        /// </summary>
        FlangerRate = 0x0003,

        /// <summary>
        /// The ratio by which the delay time is modulated by the low-frequency oscillator. Range [0.0f .. 1.0f] Default:
        /// 1.0f
        /// </summary>
        FlangerDepth = 0x0004,

        /// <summary>
        /// This is the amount of the output signal level fed back into the effect's input. A negative value will reverse
        /// the phase of the feedback signal. Range [-1.0f .. +1.0f] Default: -0.5f
        /// </summary>
        FlangerFeedback = 0x0005,

        /// <summary>
        /// The average amount of time the sample is delayed before it is played back. When used with the Feedback
        /// property it's the amount of time between iterations of the sample. Unit: Seconds Range [0.0f .. 0.004f] Default:
        /// 0.002f
        /// </summary>
        FlangerDelay = 0x0006,

        /// <summary>
        /// This is the carrier frequency. For carrier frequencies below the audible range, the single sideband modulator
        /// may produce phaser effects, spatial effects or a slight pitch-shift. As the carrier frequency increases, the timbre
        /// of the sound is affected. Unit: Hz Range [0.0f .. 24000.0f] Default: 0.0f
        /// </summary>
        FrequencyShifterFrequency = 0x0001,

        /// <summary>
        /// This controls the frequency of the low-frequency oscillator used to morph between the two phoneme filters.
        /// Unit: Hz Range [0.0f .. 10.0f] Default: 1.41f
        /// </summary>
        VocalMorpherRate = 0x0006,

        /// <summary>
        /// This is the frequency of the carrier signal. If the carrier signal is slowly varying (less than 20 Hz), the
        /// result is a slow amplitude variation effect (tremolo). Unit: Hz Range [0.0f .. 8000.0f] Default: 440.0f
        /// </summary>
        RingModulatorFrequency = 0x0001,

        /// <summary>
        /// This controls the cutoff frequency at which the input signal is high-pass filtered before being ring
        /// modulated. Unit: Hz Range [0.0f .. 24000.0f] Default: 800.0f
        /// </summary>
        RingModulatorHighpassCutoff = 0x0002,

        /// <summary>
        /// This property controls the time the filtering effect takes to sweep from minimum to maximum center frequency
        /// when it is triggered by input signal. Unit: Seconds Range [0.0001f .. 1.0f] Default: 0.06f
        /// </summary>
        AutowahAttackTime = 0x0001,

        /// <summary>
        /// This property controls the time the filtering effect takes to sweep from maximum back to base center
        /// frequency, when the input signal ends. Unit: Seconds Range [0.0001f .. 1.0f] Default: 0.06f
        /// </summary>
        AutowahReleaseTime = 0x0002,

        /// <summary>
        /// This property controls the resonant peak, sometimes known as emphasis or Q, of the auto-wah band-pass filter.
        /// Range [2.0f .. 1000.0f] Default: 1000.0f
        /// </summary>
        AutowahResonance = 0x0003,

        /// <summary>
        /// This property controls the input signal level at which the band-pass filter will be fully opened. Range
        /// [0.00003f .. 31621.0f] Default: 11.22f
        /// </summary>
        AutowahPeakGain = 0x0004,

        /// <summary>
        /// This property controls amount of cut or boost on the low frequency range. Range [0.126f .. 7.943f] Default:
        /// 1.0f
        /// </summary>
        EqualizerLowGain = 0x0001,

        /// <summary>
        /// This property controls the low frequency below which signal will be cut off. Unit: Hz Range [50.0f .. 800.0f]
        /// Default: 200.0f
        /// </summary>
        EqualizerLowCutoff = 0x0002,

        /// <summary>
        /// This property allows you to cut/boost signal on the "mid1" range. Range [0.126f .. 7.943f] Default: 1.0f
        /// </summary>
        EqualizerMid1Gain = 0x0003,

        /// <summary>
        /// This property sets the center frequency for the "mid1" range. Unit: Hz Range [200.0f .. 3000.0f] Default:
        /// 500.0f
        /// </summary>
        EqualizerMid1Center = 0x0004,

        /// <summary>
        /// This property controls the width of the "mid1" range. Range [0.01f .. 1.0f] Default: 1.0f
        /// </summary>
        EqualizerMid1Width = 0x0005,

        /// <summary>
        /// This property allows you to cut/boost signal on the "mid2" range. Range [0.126f .. 7.943f] Default: 1.0f
        /// </summary>
        EqualizerMid2Gain = 0x0006,

        /// <summary>
        /// This property sets the center frequency for the "mid2" range. Unit: Hz Range [1000.0f .. 8000.0f] Default:
        /// 3000.0f
        /// </summary>
        EqualizerMid2Center = 0x0007,

        /// <summary>
        /// This property controls the width of the "mid2" range. Range [0.01f .. 1.0f] Default: 1.0f
        /// </summary>
        EqualizerMid2Width = 0x0008,

        /// <summary>
        /// This property allows to cut/boost the signal at high frequencies. Range [0.126f .. 7.943f] Default: 1.0f
        /// </summary>
        EqualizerHighGain = 0x0009,

        /// <summary>
        /// This property controls the high frequency above which signal will be cut off. Unit: Hz Range [4000.0f ..
        /// 16000.0f] Default: 6000.0f
        /// </summary>
        EqualizerHighCutoff = 0x000A,

        /// <summary>
        /// Reverb Modal Density controls the coloration of the late reverb. Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        EaxReverbDensity = 0x0001,

        /// <summary>
        /// The Reverb Diffusion property controls the echo density in the reverberation decay. Range [0.0f .. 1.0f]
        /// Default: 1.0f
        /// </summary>
        EaxReverbDiffusion = 0x0002,

        /// <summary>
        /// Reverb Gain controls the level of the reverberant sound in an environment. A high level of reverb is
        /// characteristic of rooms with highly reflective walls and/or small dimensions. Unit: Linear gain Range [0.0f ..
        /// 1.0f] Default: 0.32f
        /// </summary>
        EaxReverbGain = 0x0003,

        /// <summary>
        /// Gain HF is used to attenuate the high frequency content of all the reflected sound in an environment. You can
        /// use this property to give a room specific spectral characteristic. Unit: Linear gain Range [0.0f .. 1.0f] Default:
        /// 0.89f
        /// </summary>
        EaxReverbGainHF = 0x0004,

        /// <summary>
        /// Gain LF is the low frequency counterpart to Gain HF. Use this to reduce or boost the low frequency content in
        /// an environment. Unit: Linear gain Range [0.0f .. 1.0f] Default: 1.0f
        /// </summary>
        EaxReverbGainLF = 0x0005,

        /// <summary>
        /// The Decay Time property sets the reverberation decay time. It ranges from 0.1f (typically a small room with
        /// very dead surfaces) to 20.0f (typically a large room with very live surfaces). Unit: Seconds Range [0.1f .. 20.0f]
        /// Default: 1.49f
        /// </summary>
        EaxReverbDecayTime = 0x0006,

        /// <summary>
        /// Decay HF Ratio scales the decay time of high frequencies relative to the value of the Decay Time property. By
        /// changing this value, you are changing the amount of time it takes for the high frequencies to decay compared to the
        /// mid frequencies of the reverb. Range [0.1f .. 2.0f] Default: 0.83f
        /// </summary>
        EaxReverbDecayHFRatio = 0x0007,

        /// <summary>
        /// Decay LF Ratio scales the decay time of low frequencies in the reverberation in the same manner that Decay HF
        /// Ratio handles high frequencies. Unit: Linear multiplier Range [0.1f .. 2.0f] Default: 1.0f
        /// </summary>
        EaxReverbDecayLFRatio = 0x0008,

        /// <summary>
        /// Reflections Gain sets the level of the early reflections in an environment. Early reflections are used as a
        /// cue for determining the size of the environment we are in. Unit: Linear gain Range [0.0f .. 3.16f] Default: 0.05f
        /// </summary>
        EaxReverbReflectionsGain = 0x0009,

        /// <summary>
        /// Reflections Delay controls the amount of time it takes for the first reflected wave front to reach the
        /// listener, relative to the arrival of the direct-path sound. Unit: Seconds Range [0.0f .. 0.3f] Default: 0.007f
        /// </summary>
        EaxReverbReflectionsDelay = 0x000A,

        /// <summary>
        /// The Late Reverb Gain property controls the overall amount of later reverberation relative to the Gain
        /// property. Range [0.0f .. 10.0f] Default: 1.26f
        /// </summary>
        EaxReverbLateReverbGain = 0x000C,

        /// <summary>
        /// The Late Reverb Delay property defines the begin time of the late reverberation relative to the time of the
        /// initial reflection (the first of the early reflections). It ranges from 0 to 100 milliseconds. Unit: Seconds Range
        /// [0.0f .. 0.1f] Default: 0.011f
        /// </summary>
        EaxReverbLateReverbDelay = 0x000D,

        /// <summary>
        /// Echo Time controls the rate at which the cyclic echo repeats itself along the reverberation decay. Range
        /// [0.075f .. 0.25f] Default: 0.25f
        /// </summary>
        EaxReverbEchoTime = 0x000F,

        /// <summary>
        /// Echo Depth introduces a cyclic echo in the reverberation decay, which will be noticeable with transient or
        /// percussive sounds. Range [0.0f .. 1.0f] Default: 0.0f
        /// </summary>
        EaxReverbEchoDepth = 0x0010,

        /// <summary>
        /// Modulation Time controls the speed of the rate of periodic changes in pitch (vibrato). Range [0.04f .. 4.0f]
        /// Default: 0.25f
        /// </summary>
        EaxReverbModulationTime = 0x0011,

        /// <summary>
        /// Modulation Depth controls the amount of pitch change. Low values of Diffusion will contribute to reinforcing
        /// the perceived effect by reducing the mixing of overlapping reflections in the reverberation decay. Range [0.0f ..
        /// 1.0f] Default: 0.0f
        /// </summary>
        EaxReverbModulationDepth = 0x0012,

        /// <summary>
        /// The Air Absorption Gain HF property controls the distance-dependent attenuation at high frequencies caused by
        /// the propagation medium. It applies to reflected sound only. Range [0.892f .. 1.0f] Default: 0.994f
        /// </summary>
        EaxReverbAirAbsorptionGainHF = 0x0013,

        /// <summary>
        /// The property HF reference determines the frequency at which the high-frequency effects created by Reverb
        /// properties are measured. Unit: Hz Range [1000.0f .. 20000.0f] Default: 5000.0f
        /// </summary>
        EaxReverbHFReference = 0x0014,

        /// <summary>
        /// The property LF reference determines the frequency at which the low-frequency effects created by Reverb
        /// properties are measured. Unit: Hz Range [20.0f .. 1000.0f] Default: 250.0f
        /// </summary>
        EaxReverbLFReference = 0x0015,

        /// <summary>
        /// The Room Rolloff Factor property is one of two methods available to attenuate the reflected sound (containing
        /// both reflections and reverberation) according to source-listener distance. It's defined the same way as OpenAL
        /// Rolloff Factor, but operates on reverb sound instead of direct-path sound. Range [0.0f .. 10.0f] Default: 0.0f
        /// </summary>
        EaxReverbRoomRolloffFactor = 0x0016
    }
}