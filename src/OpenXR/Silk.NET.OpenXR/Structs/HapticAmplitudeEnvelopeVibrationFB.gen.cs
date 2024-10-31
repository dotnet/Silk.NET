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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHapticAmplitudeEnvelopeVibrationFB")]
    public unsafe partial struct HapticAmplitudeEnvelopeVibrationFB
    {
        public HapticAmplitudeEnvelopeVibrationFB
        (
            StructureType? type = StructureType.TypeHapticAmplitudeEnvelopeVibrationFB,
            void* next = null,
            long? duration = null,
            uint? amplitudeCount = null,
            float* amplitudes = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (duration is not null)
            {
                Duration = duration.Value;
            }

            if (amplitudeCount is not null)
            {
                AmplitudeCount = amplitudeCount.Value;
            }

            if (amplitudes is not null)
            {
                Amplitudes = amplitudes;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrDuration")]
        [NativeName("Type.Name", "XrDuration")]
        [NativeName("Name", "duration")]
        public long Duration;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "amplitudeCount")]
        public uint AmplitudeCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "amplitudes")]
        public float* Amplitudes;
    }
}
