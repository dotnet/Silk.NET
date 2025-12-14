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
    [NativeName("Name", "XrLipExpressionDataBD")]
    public unsafe partial struct LipExpressionDataBD
    {
        public LipExpressionDataBD
        (
            StructureType? type = StructureType.TypeLipExpressionDataBD,
            void* next = null,
            uint? lipsyncExpressionWeightCount = null,
            float* lipsyncExpressionWeights = null
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

            if (lipsyncExpressionWeightCount is not null)
            {
                LipsyncExpressionWeightCount = lipsyncExpressionWeightCount.Value;
            }

            if (lipsyncExpressionWeights is not null)
            {
                LipsyncExpressionWeights = lipsyncExpressionWeights;
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
        [NativeName("Name", "lipsyncExpressionWeightCount")]
        public uint LipsyncExpressionWeightCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lipsyncExpressionWeights")]
        public float* LipsyncExpressionWeights;
    }
}
