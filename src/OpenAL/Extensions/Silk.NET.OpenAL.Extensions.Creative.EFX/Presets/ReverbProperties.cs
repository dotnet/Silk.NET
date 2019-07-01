//
// ReverbProperties.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using Silk.NET.Mathematics;

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines a set of predefined reverb properties.
    /// </summary>
    public struct ReverbProperties
    {
        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbDensity"/>.
        /// </summary>
        public float Density { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbDiffusion "/>.
        /// </summary>
        public float Diffusion { get; }

        /// <summary>
        /// Gets the preset value for <ReverbGainsee cref="EffectFloat.ReverbGain"/>.
        /// </summary>
        public float Gain { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbGainHF"/>.
        /// </summary>
        public float GainHF { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbGainLF"/>.
        /// </summary>
        public float GainLF { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbDecayTime"/>.
        /// </summary>
        public float DecayTime { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbDecayHFRatio"/>.
        /// </summary>
        public float DecayHFRatio { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbDecayLFRatio"/>.
        /// </summary>
        public float DecayLFRatio { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbReflectionsGain"/>.
        /// </summary>
        public float ReflectionsGain { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbReflectionsDelay"/>.
        /// </summary>
        public float ReflectionsDelay { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectVector3.EaxReverbReflectionsPan"/>.
        /// </summary>
        public Vector3 ReflectionsPan { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbLateReverbGain"/>.
        /// </summary>
        public float LateReverbGain { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbLateReverbDelay"/>.
        /// </summary>
        public float LateReverbDelay { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectVector3.EaxReverbLateReverbPan"/>.
        /// </summary>
        public Vector3 LateReverbPan { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbEchoTime"/>.
        /// </summary>
        public float EchoTime { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbEchoDepth"/>.
        /// </summary>
        public float EchoDepth { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbModulationTime"/>.
        /// </summary>
        public float ModulationTime { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbModulationDepth"/>.
        /// </summary>
        public float ModulationDepth { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbAirAbsorptionGainHF"/>.
        /// </summary>
        public float AirAbsorptionGainHF { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbHFReference"/>.
        /// </summary>
        public float HFReference { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.EaxReverbLFReference"/>.
        /// </summary>
        public float LFReference { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectFloat.ReverbRoomRolloffFactor"/>.
        /// </summary>
        public float RoomRolloffFactor { get; }

        /// <summary>
        /// Gets the preset value for <see cref="EffectInteger.ReverbDecayHFLimit"/>.
        /// </summary>
        public int DecayHFLimit { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverbProperties"/> struct.
        /// </summary>
        /// <param name="density">See <see cref="Density"/>.</param>
        /// <param name="diffusion">See <see cref="Diffusion"/>.</param>
        /// <param name="gain">See <see cref="Gain"/>.</param>
        /// <param name="gainHF">See <see cref="GainHF"/>.</param>
        /// <param name="gainLF">See <see cref="GainLF"/>.</param>
        /// <param name="decayTime">See <see cref="DecayTime"/>.</param>
        /// <param name="decayHFRatio">See <see cref="DecayHFRatio"/>.</param>
        /// <param name="decayLFRatio">See <see cref="DecayLFRatio"/>.</param>
        /// <param name="reflectionsGain">See <see cref="ReflectionsGain"/>.</param>
        /// <param name="reflectionsDelay">See <see cref="ReflectionsDelay"/>.</param>
        /// <param name="reflectionsPan">See <see cref="ReflectionsPan"/>.</param>
        /// <param name="lateReverbGain">See <see cref="LateReverbGain"/>.</param>
        /// <param name="lateReverbDelay">See <see cref="LateReverbDelay"/>.</param>
        /// <param name="lateReverbPan">See <see cref="LateReverbPan"/>.</param>
        /// <param name="echoTime">See <see cref="EchoTime"/>.</param>
        /// <param name="echoDepth">See <see cref="EchoDepth"/>.</param>
        /// <param name="modulationTime">See <see cref="ModulationTime"/>.</param>
        /// <param name="modulationDepth">See <see cref="ModulationDepth"/>.</param>
        /// <param name="airAbsorptionGainHF">See <see cref="AirAbsorptionGainHF"/>.</param>
        /// <param name="hfReference">See <see cref="HFReference"/>.</param>
        /// <param name="lfReference">See <see cref="LFReference"/>.</param>
        /// <param name="roomRolloffFactor">See <see cref="RoomRolloffFactor"/>.</param>
        /// <param name="decayHFLimit">See <see cref="DecayHFLimit"/>.</param>
        public ReverbProperties
        (
            float density,
            float diffusion,
            float gain,
            float gainHF,
            float gainLF,
            float decayTime,
            float decayHFRatio,
            float decayLFRatio,
            float reflectionsGain,
            float reflectionsDelay,
            Vector3 reflectionsPan,
            float lateReverbGain,
            float lateReverbDelay,
            Vector3 lateReverbPan,
            float echoTime,
            float echoDepth,
            float modulationTime,
            float modulationDepth,
            float airAbsorptionGainHF,
            float hfReference,
            float lfReference,
            float roomRolloffFactor,
            int decayHFLimit
        )
        {
            Density = density;
            Diffusion = diffusion;
            Gain = gain;
            GainHF = gainHF;
            GainLF = gainLF;
            DecayTime = decayTime;
            DecayHFRatio = decayHFRatio;
            DecayLFRatio = decayLFRatio;
            ReflectionsGain = reflectionsGain;
            ReflectionsDelay = reflectionsDelay;
            ReflectionsPan = reflectionsPan;
            LateReverbGain = lateReverbGain;
            LateReverbDelay = lateReverbDelay;
            LateReverbPan = lateReverbPan;
            EchoTime = echoTime;
            EchoDepth = echoDepth;
            ModulationTime = modulationTime;
            ModulationDepth = modulationDepth;
            AirAbsorptionGainHF = airAbsorptionGainHF;
            HFReference = hfReference;
            LFReference = lfReference;
            RoomRolloffFactor = roomRolloffFactor;
            DecayHFLimit = decayHFLimit;
        }
    }
}
