// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingShaderGroupCreateInfoKHR")]
    public unsafe partial struct RayTracingShaderGroupCreateInfoKHR
    {
        public RayTracingShaderGroupCreateInfoKHR
        (
            StructureType? sType = StructureType.RayTracingShaderGroupCreateInfoKhr,
            void* pNext = null,
            RayTracingShaderGroupTypeKHR? type = null,
            uint? generalShader = null,
            uint? closestHitShader = null,
            uint? anyHitShader = null,
            uint? intersectionShader = null,
            void* pShaderGroupCaptureReplayHandle = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (generalShader is not null)
            {
                GeneralShader = generalShader.Value;
            }

            if (closestHitShader is not null)
            {
                ClosestHitShader = closestHitShader.Value;
            }

            if (anyHitShader is not null)
            {
                AnyHitShader = anyHitShader.Value;
            }

            if (intersectionShader is not null)
            {
                IntersectionShader = intersectionShader.Value;
            }

            if (pShaderGroupCaptureReplayHandle is not null)
            {
                PShaderGroupCaptureReplayHandle = pShaderGroupCaptureReplayHandle;
            }
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
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pShaderGroupCaptureReplayHandle")]
        public void* PShaderGroupCaptureReplayHandle;
    }
}
