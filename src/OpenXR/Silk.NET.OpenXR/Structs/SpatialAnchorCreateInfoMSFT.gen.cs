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
    public unsafe struct SpatialAnchorCreateInfoMSFT
    {
        public SpatialAnchorCreateInfoMSFT
        (
            StructureType type = StructureType.TypeSpatialAnchorCreateInfoMsft,
            void* next = default,
            Space space = default,
            Posef pose = default,
            long time = default
        )
        {
           Type = type;
           Next = next;
           Space = space;
           Pose = pose;
           Time = time;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public Space Space;
/// <summary></summary>
        public Posef Pose;
/// <summary></summary>
        public long Time;
    }
}
