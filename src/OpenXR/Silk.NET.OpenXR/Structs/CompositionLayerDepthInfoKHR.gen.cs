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
    [NativeName("Name", "XrCompositionLayerDepthInfoKHR")]
    public unsafe partial struct CompositionLayerDepthInfoKHR
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
        [NativeName("Type", "XrSwapchainSubImage")]
        [NativeName("Type.Name", "XrSwapchainSubImage")]
        [NativeName("Name", "subImage")]
        public SwapchainSubImage SubImage;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minDepth")]
        public float MinDepth;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxDepth")]
        public float MaxDepth;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "nearZ")]
        public float NearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "farZ")]
        public float FarZ;
    }
}
