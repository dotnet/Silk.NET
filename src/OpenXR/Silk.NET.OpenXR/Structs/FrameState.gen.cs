// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFrameState")]
    public unsafe partial struct FrameState
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
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "predictedDisplayTime")]
        public long PredictedDisplayTime;
/// <summary></summary>
        [NativeName("Type", "XrDuration")]
        [NativeName("Type.Name", "XrDuration")]
        [NativeName("Name", "predictedDisplayPeriod")]
        public long PredictedDisplayPeriod;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "shouldRender")]
        public uint ShouldRender;
    }
}
