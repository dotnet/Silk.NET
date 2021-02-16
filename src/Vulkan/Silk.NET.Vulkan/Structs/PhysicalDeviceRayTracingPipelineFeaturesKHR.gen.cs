// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceRayTracingPipelineFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public PhysicalDeviceRayTracingPipelineFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceRayTracingPipelineFeaturesKhr,
            void* pNext = null,
            Bool32? rayTracingPipeline = null,
            Bool32? rayTracingPipelineShaderGroupHandleCaptureReplay = null,
            Bool32? rayTracingPipelineShaderGroupHandleCaptureReplayMixed = null,
            Bool32? rayTracingPipelineTraceRaysIndirect = null,
            Bool32? rayTraversalPrimitiveCulling = null
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

            if (rayTracingPipeline is not null)
            {
                RayTracingPipeline = rayTracingPipeline.Value;
            }

            if (rayTracingPipelineShaderGroupHandleCaptureReplay is not null)
            {
                RayTracingPipelineShaderGroupHandleCaptureReplay = rayTracingPipelineShaderGroupHandleCaptureReplay.Value;
            }

            if (rayTracingPipelineShaderGroupHandleCaptureReplayMixed is not null)
            {
                RayTracingPipelineShaderGroupHandleCaptureReplayMixed = rayTracingPipelineShaderGroupHandleCaptureReplayMixed.Value;
            }

            if (rayTracingPipelineTraceRaysIndirect is not null)
            {
                RayTracingPipelineTraceRaysIndirect = rayTracingPipelineTraceRaysIndirect.Value;
            }

            if (rayTraversalPrimitiveCulling is not null)
            {
                RayTraversalPrimitiveCulling = rayTraversalPrimitiveCulling.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingPipeline")]
        public Bool32 RayTracingPipeline;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingPipelineShaderGroupHandleCaptureReplay")]
        public Bool32 RayTracingPipelineShaderGroupHandleCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingPipelineShaderGroupHandleCaptureReplayMixed")]
        public Bool32 RayTracingPipelineShaderGroupHandleCaptureReplayMixed;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingPipelineTraceRaysIndirect")]
        public Bool32 RayTracingPipelineTraceRaysIndirect;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTraversalPrimitiveCulling")]
        public Bool32 RayTraversalPrimitiveCulling;
    }
}
