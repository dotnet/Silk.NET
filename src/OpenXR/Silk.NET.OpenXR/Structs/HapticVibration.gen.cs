// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct HapticVibration
    {
        public HapticVibration
        (
            StructureType type = StructureType.TypeHapticVibration,
            void* next = default,
            long duration = default,
            float frequency = default,
            float amplitude = default
        )
        {
           Type = type;
           Next = next;
           Duration = duration;
           Frequency = frequency;
           Amplitude = amplitude;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public long Duration;
/// <summary></summary>
        public float Frequency;
/// <summary></summary>
        public float Amplitude;
    }
}
