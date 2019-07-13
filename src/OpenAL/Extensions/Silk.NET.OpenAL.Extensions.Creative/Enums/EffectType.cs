// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Effect type definitions to be used with EfxEffecti.EffectType.
    /// </summary>
    public enum EffectType
    {
        /// <summary>
        /// No Effect, disable. This Effect type is used when an Effect object is initially created.
        /// </summary>
        Null = 0x0000,

        /// <summary>
        /// The Reverb effect is the standard Effects Extension's environmental reverberation effect. It is available on
        /// all Generic Software and Generic Hardware devices.
        /// </summary>
        Reverb = 0x0001,

        /// <summary>
        /// The Chorus effect essentially replays the input audio accompanied by another slightly delayed version of the
        /// signal, creating a "doubling" effect.
        /// </summary>
        Chorus = 0x0002,

        /// <summary>
        /// The Distortion effect simulates turning up (overdriving) the gain stage on a guitar amplifier or adding a
        /// distortion pedal to an instrument's output.
        /// </summary>
        Distortion = 0x0003,

        /// <summary>
        /// The Echo effect generates discrete, delayed instances of the input signal.
        /// </summary>
        Echo = 0x0004,

        /// <summary>
        /// The Flanger effect creates a "tearing" or "whooshing" sound, like a jet flying overhead.
        /// </summary>
        Flanger = 0x0005,

        /// <summary>
        /// The Frequency shifter is a single-sideband modulator, which translates all the component frequencies of the
        /// input signal by an equal amount.
        /// </summary>
        FrequencyShifter = 0x0006,

        /// <summary>
        /// The Vocal morpher consists of a pair of 4-band formant filters, used to impose vocal tract effects upon the
        /// input signal.
        /// </summary>
        VocalMorpher = 0x0007,

        /// <summary>
        /// The Pitch shifter applies time-invariant pitch shifting to the input signal, over a one octave range and
        /// controllable at a semi-tone and cent resolution.
        /// </summary>
        PitchShifter = 0x0008,

        /// <summary>
        /// The Ring modulator multiplies an input signal by a carrier signal in the time domain, resulting in tremolo or
        /// inharmonic effects.
        /// </summary>
        RingModulator = 0x0009,

        /// <summary>
        /// The Auto-wah effect emulates the sound of a wah-wah pedal used with an electric guitar, or a mute on a brass
        /// instrument.
        /// </summary>
        Autowah = 0x000A,

        /// <summary>
        /// The Compressor will boost quieter portions of the audio, while louder portions will stay the same or may even
        /// be reduced.
        /// </summary>
        Compressor = 0x000B,

        /// <summary>
        /// The Equalizer is very flexible, providing tonal control over four different adjustable frequency ranges.
        /// </summary>
        Equalizer = 0x000C,

        /// <summary>
        /// The EAX Reverb has a more advanced parameter set than EfxEffectType.Reverb, but is only natively supported on
        /// devices that support the EAX 3.0 or above.
        /// </summary>
        EaxReverb = 0x8000
    }
}