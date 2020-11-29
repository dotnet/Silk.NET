// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "XAUDIO2FX_REVERB_I3DL2_PARAMETERS")]
    public unsafe partial struct FXReverbI3DL2Parameters
    {
        public FXReverbI3DL2Parameters
        (
            float? wetDryMix = null,
            int? room = null,
            int? roomHF = null,
            float? roomRolloffFactor = null,
            float? decayTime = null,
            float? decayHFRatio = null,
            int? reflections = null,
            float? reflectionsDelay = null,
            int? reverb = null,
            float? reverbDelay = null,
            float? diffusion = null,
            float? density = null,
            float? hFReference = null
        ) : this()
        {
            if (wetDryMix is not null)
            {
                WetDryMix = wetDryMix.Value;
            }

            if (room is not null)
            {
                Room = room.Value;
            }

            if (roomHF is not null)
            {
                RoomHF = roomHF.Value;
            }

            if (roomRolloffFactor is not null)
            {
                RoomRolloffFactor = roomRolloffFactor.Value;
            }

            if (decayTime is not null)
            {
                DecayTime = decayTime.Value;
            }

            if (decayHFRatio is not null)
            {
                DecayHFRatio = decayHFRatio.Value;
            }

            if (reflections is not null)
            {
                Reflections = reflections.Value;
            }

            if (reflectionsDelay is not null)
            {
                ReflectionsDelay = reflectionsDelay.Value;
            }

            if (reverb is not null)
            {
                Reverb = reverb.Value;
            }

            if (reverbDelay is not null)
            {
                ReverbDelay = reverbDelay.Value;
            }

            if (diffusion is not null)
            {
                Diffusion = diffusion.Value;
            }

            if (density is not null)
            {
                Density = density.Value;
            }

            if (hFReference is not null)
            {
                HFReference = hFReference.Value;
            }
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "WetDryMix")]
        public float WetDryMix;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "Room")]
        public int Room;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "RoomHF")]
        public int RoomHF;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "RoomRolloffFactor")]
        public float RoomRolloffFactor;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "DecayTime")]
        public float DecayTime;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "DecayHFRatio")]
        public float DecayHFRatio;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "Reflections")]
        public int Reflections;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ReflectionsDelay")]
        public float ReflectionsDelay;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "Reverb")]
        public int Reverb;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ReverbDelay")]
        public float ReverbDelay;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Diffusion")]
        public float Diffusion;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Density")]
        public float Density;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "HFReference")]
        public float HFReference;
    }
}
