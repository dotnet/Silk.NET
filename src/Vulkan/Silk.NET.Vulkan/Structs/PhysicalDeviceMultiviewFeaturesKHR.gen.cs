// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceMultiviewFeaturesKHR
    {
        public PhysicalDeviceMultiviewFeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceMultiviewFeatures,
            void* pNext = default,
            Bool32 multiview = default,
            Bool32 multiviewGeometryShader = default,
            Bool32 multiviewTessellationShader = default
        )
        {
           SType = sType;
           PNext = pNext;
           Multiview = multiview;
           MultiviewGeometryShader = multiviewGeometryShader;
           MultiviewTessellationShader = multiviewTessellationShader;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 Multiview;
/// <summary></summary>
        public Bool32 MultiviewGeometryShader;
/// <summary></summary>
        public Bool32 MultiviewTessellationShader;
    }
}
