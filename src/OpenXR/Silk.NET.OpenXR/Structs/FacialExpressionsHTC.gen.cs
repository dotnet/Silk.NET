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
    [NativeName("Name", "XrFacialExpressionsHTC")]
    public unsafe partial struct FacialExpressionsHTC
    {
        public FacialExpressionsHTC
        (
            StructureType? type = StructureType.TypeFacialExpressionsHtc,
            void* next = null,
            uint? isActive = null,
            long? sampleTime = null,
            uint? expressionCount = null,
            float* expressionWeightings = null
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

            if (isActive is not null)
            {
                IsActive = isActive.Value;
            }

            if (sampleTime is not null)
            {
                SampleTime = sampleTime.Value;
            }

            if (expressionCount is not null)
            {
                ExpressionCount = expressionCount.Value;
            }

            if (expressionWeightings is not null)
            {
                ExpressionWeightings = expressionWeightings;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isActive")]
        public uint IsActive;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "sampleTime")]
        public long SampleTime;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "expressionCount")]
        public uint ExpressionCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "expressionWeightings")]
        public float* ExpressionWeightings;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
