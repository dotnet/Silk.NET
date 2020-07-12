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
    public unsafe struct FrameState
    {
        public FrameState
        (
            StructureType type = StructureType.TypeFrameState,
            void* next = default,
            long predictedDisplayTime = default,
            long predictedDisplayPeriod = default,
            uint shouldRender = default
        )
        {
           Type = type;
           Next = next;
           PredictedDisplayTime = predictedDisplayTime;
           PredictedDisplayPeriod = predictedDisplayPeriod;
           ShouldRender = shouldRender;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public long PredictedDisplayTime;
/// <summary></summary>
        public long PredictedDisplayPeriod;
/// <summary></summary>
        public uint ShouldRender;
    }
}
