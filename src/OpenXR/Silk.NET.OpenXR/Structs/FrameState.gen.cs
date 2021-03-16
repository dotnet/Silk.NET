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
    [NativeName("Name", "XrFrameState")]
    public unsafe partial struct FrameState
    {
        public FrameState
        (
            StructureType? type = StructureType.TypeFrameState,
            void* next = null,
            long? predictedDisplayTime = null,
            long? predictedDisplayPeriod = null,
            uint? shouldRender = null
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

            if (predictedDisplayTime is not null)
            {
                PredictedDisplayTime = predictedDisplayTime.Value;
            }

            if (predictedDisplayPeriod is not null)
            {
                PredictedDisplayPeriod = predictedDisplayPeriod.Value;
            }

            if (shouldRender is not null)
            {
                ShouldRender = shouldRender.Value;
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
