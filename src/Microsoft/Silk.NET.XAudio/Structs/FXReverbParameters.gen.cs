// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "XAUDIO2FX_REVERB_PARAMETERS")]
    public unsafe partial struct FXReverbParameters
    {
        public FXReverbParameters
        (
            float? wetDryMix = null,
            uint? reflectionsDelay = null,
            byte? reverbDelay = null,
            byte? rearDelay = null,
            byte? sideDelay = null,
            byte? positionLeft = null,
            byte? positionRight = null,
            byte? positionMatrixLeft = null,
            byte? positionMatrixRight = null,
            byte? earlyDiffusion = null,
            byte? lateDiffusion = null,
            byte? lowEQGain = null,
            byte? lowEQCutoff = null,
            byte? highEQGain = null,
            byte? highEQCutoff = null,
            float? roomFilterFreq = null,
            float? roomFilterMain = null,
            float? roomFilterHF = null,
            float? reflectionsGain = null,
            float? reverbGain = null,
            float? decayTime = null,
            float? density = null,
            float? roomSize = null,
            Silk.NET.Core.Bool32? disableLateField = null
        ) : this()
        {
            if (wetDryMix is not null)
            {
                WetDryMix = wetDryMix.Value;
            }

            if (reflectionsDelay is not null)
            {
                ReflectionsDelay = reflectionsDelay.Value;
            }

            if (reverbDelay is not null)
            {
                ReverbDelay = reverbDelay.Value;
            }

            if (rearDelay is not null)
            {
                RearDelay = rearDelay.Value;
            }

            if (sideDelay is not null)
            {
                SideDelay = sideDelay.Value;
            }

            if (positionLeft is not null)
            {
                PositionLeft = positionLeft.Value;
            }

            if (positionRight is not null)
            {
                PositionRight = positionRight.Value;
            }

            if (positionMatrixLeft is not null)
            {
                PositionMatrixLeft = positionMatrixLeft.Value;
            }

            if (positionMatrixRight is not null)
            {
                PositionMatrixRight = positionMatrixRight.Value;
            }

            if (earlyDiffusion is not null)
            {
                EarlyDiffusion = earlyDiffusion.Value;
            }

            if (lateDiffusion is not null)
            {
                LateDiffusion = lateDiffusion.Value;
            }

            if (lowEQGain is not null)
            {
                LowEQGain = lowEQGain.Value;
            }

            if (lowEQCutoff is not null)
            {
                LowEQCutoff = lowEQCutoff.Value;
            }

            if (highEQGain is not null)
            {
                HighEQGain = highEQGain.Value;
            }

            if (highEQCutoff is not null)
            {
                HighEQCutoff = highEQCutoff.Value;
            }

            if (roomFilterFreq is not null)
            {
                RoomFilterFreq = roomFilterFreq.Value;
            }

            if (roomFilterMain is not null)
            {
                RoomFilterMain = roomFilterMain.Value;
            }

            if (roomFilterHF is not null)
            {
                RoomFilterHF = roomFilterHF.Value;
            }

            if (reflectionsGain is not null)
            {
                ReflectionsGain = reflectionsGain.Value;
            }

            if (reverbGain is not null)
            {
                ReverbGain = reverbGain.Value;
            }

            if (decayTime is not null)
            {
                DecayTime = decayTime.Value;
            }

            if (density is not null)
            {
                Density = density.Value;
            }

            if (roomSize is not null)
            {
                RoomSize = roomSize.Value;
            }

            if (disableLateField is not null)
            {
                DisableLateField = disableLateField.Value;
            }
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "WetDryMix")]
        public float WetDryMix;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ReflectionsDelay")]
        public uint ReflectionsDelay;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "ReverbDelay")]
        public byte ReverbDelay;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "RearDelay")]
        public byte RearDelay;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "SideDelay")]
        public byte SideDelay;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "PositionLeft")]
        public byte PositionLeft;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "PositionRight")]
        public byte PositionRight;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "PositionMatrixLeft")]
        public byte PositionMatrixLeft;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "PositionMatrixRight")]
        public byte PositionMatrixRight;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "EarlyDiffusion")]
        public byte EarlyDiffusion;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "LateDiffusion")]
        public byte LateDiffusion;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "LowEQGain")]
        public byte LowEQGain;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "LowEQCutoff")]
        public byte LowEQCutoff;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "HighEQGain")]
        public byte HighEQGain;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "HighEQCutoff")]
        public byte HighEQCutoff;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "RoomFilterFreq")]
        public float RoomFilterFreq;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "RoomFilterMain")]
        public float RoomFilterMain;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "RoomFilterHF")]
        public float RoomFilterHF;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ReflectionsGain")]
        public float ReflectionsGain;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ReverbGain")]
        public float ReverbGain;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "DecayTime")]
        public float DecayTime;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Density")]
        public float Density;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "RoomSize")]
        public float RoomSize;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DisableLateField")]
        public Silk.NET.Core.Bool32 DisableLateField;
    }
}
