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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingShaderGroupCreateInfoNV")]
    public unsafe struct RayTracingShaderGroupCreateInfoNV
    {
        public RayTracingShaderGroupCreateInfoNV
        (
            StructureType sType = StructureType.RayTracingShaderGroupCreateInfoNV,
            void* pNext = default,
            RayTracingShaderGroupTypeKHR type = default,
            uint generalShader = default,
            uint closestHitShader = default,
            uint anyHitShader = default,
            uint intersectionShader = default
        )
        {
           SType = sType;
           PNext = pNext;
           Type = type;
           GeneralShader = generalShader;
           ClosestHitShader = closestHitShader;
           AnyHitShader = anyHitShader;
           IntersectionShader = intersectionShader;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkRayTracingShaderGroupTypeKHR")]
        [NativeName("Type.Name", "VkRayTracingShaderGroupTypeKHR")]
        [NativeName("Name", "type")]
        public RayTracingShaderGroupTypeKHR Type;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "generalShader")]
        public uint GeneralShader;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "closestHitShader")]
        public uint ClosestHitShader;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "anyHitShader")]
        public uint AnyHitShader;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "intersectionShader")]
        public uint IntersectionShader;
    }
}
