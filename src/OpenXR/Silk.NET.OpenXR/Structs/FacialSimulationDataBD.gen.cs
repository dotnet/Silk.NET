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
    [NativeName("Name", "XrFacialSimulationDataBD")]
    public unsafe partial struct FacialSimulationDataBD
    {
        public FacialSimulationDataBD
        (
            StructureType? type = StructureType.TypeFacialSimulationDataBD,
            void* next = null,
            uint? faceExpressionWeightCount = null,
            float* faceExpressionWeights = null,
            uint? isUpperFaceDataValid = null,
            uint? isLowerFaceDataValid = null,
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

            if (faceExpressionWeightCount is not null)
            {
                FaceExpressionWeightCount = faceExpressionWeightCount.Value;
            }

            if (faceExpressionWeights is not null)
            {
                FaceExpressionWeights = faceExpressionWeights;
            }

            if (isUpperFaceDataValid is not null)
            {
                IsUpperFaceDataValid = isUpperFaceDataValid.Value;
            }

            if (isLowerFaceDataValid is not null)
            {
                IsLowerFaceDataValid = isLowerFaceDataValid.Value;
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
        [NativeName("Name", "faceExpressionWeightCount")]
        public uint FaceExpressionWeightCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "faceExpressionWeights")]
        public float* FaceExpressionWeights;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isUpperFaceDataValid")]
        public uint IsUpperFaceDataValid;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isLowerFaceDataValid")]
        public uint IsLowerFaceDataValid;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
