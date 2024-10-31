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
    [NativeName("Name", "XrHapticPcmVibrationFB")]
    public unsafe partial struct HapticPcmVibrationFB
    {
        public HapticPcmVibrationFB
        (
            StructureType? type = StructureType.TypeHapticPcmVibrationFB,
            void* next = null,
            uint? bufferSize = null,
            float* buffer = null,
            float? sampleRate = null,
            uint? append = null,
            uint* samplesConsumed = null
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

            if (bufferSize is not null)
            {
                BufferSize = bufferSize.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }

            if (sampleRate is not null)
            {
                SampleRate = sampleRate.Value;
            }

            if (append is not null)
            {
                Append = append.Value;
            }

            if (samplesConsumed is not null)
            {
                SamplesConsumed = samplesConsumed;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferSize")]
        public uint BufferSize;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "buffer")]
        public float* Buffer;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "sampleRate")]
        public float SampleRate;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "append")]
        public uint Append;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "samplesConsumed")]
        public uint* SamplesConsumed;
    }
}
