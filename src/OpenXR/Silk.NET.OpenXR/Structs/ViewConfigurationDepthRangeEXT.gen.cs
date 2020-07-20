// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrViewConfigurationDepthRangeEXT")]
    public unsafe partial struct ViewConfigurationDepthRangeEXT
    {
        public ViewConfigurationDepthRangeEXT
        (
            StructureType type = StructureType.TypeViewConfigurationDepthRangeExt,
            void* next = default,
            float recommendedNearZ = default,
            float minNearZ = default,
            float recommendedFarZ = default,
            float maxFarZ = default
        )
        {
            Type = type;
            Next = next;
            RecommendedNearZ = recommendedNearZ;
            MinNearZ = minNearZ;
            RecommendedFarZ = recommendedFarZ;
            MaxFarZ = maxFarZ;
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
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "recommendedNearZ")]
        public float RecommendedNearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minNearZ")]
        public float MinNearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "recommendedFarZ")]
        public float RecommendedFarZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxFarZ")]
        public float MaxFarZ;
    }
}
