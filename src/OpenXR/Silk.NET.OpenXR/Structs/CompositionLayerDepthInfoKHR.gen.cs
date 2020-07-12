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
    public unsafe struct CompositionLayerDepthInfoKHR
    {
        public CompositionLayerDepthInfoKHR
        (
            StructureType type = StructureType.TypeCompositionLayerDepthInfoKhr,
            void* next = default,
            SwapchainSubImage subImage = default,
            float minDepth = default,
            float maxDepth = default,
            float nearZ = default,
            float farZ = default
        )
        {
           Type = type;
           Next = next;
           SubImage = subImage;
           MinDepth = minDepth;
           MaxDepth = maxDepth;
           NearZ = nearZ;
           FarZ = farZ;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public SwapchainSubImage SubImage;
/// <summary></summary>
        public float MinDepth;
/// <summary></summary>
        public float MaxDepth;
/// <summary></summary>
        public float NearZ;
/// <summary></summary>
        public float FarZ;
    }
}
