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
    [NativeName("Name", "XrFaceExpressionWeightsFB")]
    public unsafe partial struct FaceExpressionWeightsFB
    {
        public FaceExpressionWeightsFB
        (
            StructureType? type = StructureType.TypeFaceExpressionWeightsFB,
            void* next = null,
            uint? weightCount = null,
            float* weights = null,
            uint? confidenceCount = null,
            float* confidences = null,
            FaceExpressionStatusFB? status = null,
            long? time = null
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

            if (weightCount is not null)
            {
                WeightCount = weightCount.Value;
            }

            if (weights is not null)
            {
                Weights = weights;
            }

            if (confidenceCount is not null)
            {
                ConfidenceCount = confidenceCount.Value;
            }

            if (confidences is not null)
            {
                Confidences = confidences;
            }

            if (status is not null)
            {
                Status = status.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
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
        [NativeName("Name", "weightCount")]
        public uint WeightCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "weights")]
        public float* Weights;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "confidenceCount")]
        public uint ConfidenceCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "confidences")]
        public float* Confidences;
/// <summary></summary>
        [NativeName("Type", "XrFaceExpressionStatusFB")]
        [NativeName("Type.Name", "XrFaceExpressionStatusFB")]
        [NativeName("Name", "status")]
        public FaceExpressionStatusFB Status;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
