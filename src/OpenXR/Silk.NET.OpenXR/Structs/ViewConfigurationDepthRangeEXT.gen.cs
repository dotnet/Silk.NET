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
    public unsafe struct ViewConfigurationDepthRangeEXT
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public float RecommendedNearZ;
/// <summary></summary>
        public float MinNearZ;
/// <summary></summary>
        public float RecommendedFarZ;
/// <summary></summary>
        public float MaxFarZ;
    }
}
