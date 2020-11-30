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
    [NativeName("Name", "VkPhysicalDeviceRayTracingFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceRayTracingFeaturesKHR
    {
        public PhysicalDeviceRayTracingFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceRayTracingFeaturesKhr,
            void* pNext = null,
            Bool32? rayTracing = null,
            Bool32? rayTracingShaderGroupHandleCaptureReplay = null,
            Bool32? rayTracingShaderGroupHandleCaptureReplayMixed = null,
            Bool32? rayTracingAccelerationStructureCaptureReplay = null,
            Bool32? rayTracingIndirectTraceRays = null,
            Bool32? rayTracingIndirectAccelerationStructureBuild = null,
            Bool32? rayTracingHostAccelerationStructureCommands = null,
            Bool32? rayQuery = null,
            Bool32? rayTracingPrimitiveCulling = null
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

            if (rayTracing is not null)
            {
                RayTracing = rayTracing.Value;
            }

            if (rayTracingShaderGroupHandleCaptureReplay is not null)
            {
                RayTracingShaderGroupHandleCaptureReplay = rayTracingShaderGroupHandleCaptureReplay.Value;
            }

            if (rayTracingShaderGroupHandleCaptureReplayMixed is not null)
            {
                RayTracingShaderGroupHandleCaptureReplayMixed = rayTracingShaderGroupHandleCaptureReplayMixed.Value;
            }

            if (rayTracingAccelerationStructureCaptureReplay is not null)
            {
                RayTracingAccelerationStructureCaptureReplay = rayTracingAccelerationStructureCaptureReplay.Value;
            }

            if (rayTracingIndirectTraceRays is not null)
            {
                RayTracingIndirectTraceRays = rayTracingIndirectTraceRays.Value;
            }

            if (rayTracingIndirectAccelerationStructureBuild is not null)
            {
                RayTracingIndirectAccelerationStructureBuild = rayTracingIndirectAccelerationStructureBuild.Value;
            }

            if (rayTracingHostAccelerationStructureCommands is not null)
            {
                RayTracingHostAccelerationStructureCommands = rayTracingHostAccelerationStructureCommands.Value;
            }

            if (rayQuery is not null)
            {
                RayQuery = rayQuery.Value;
            }

            if (rayTracingPrimitiveCulling is not null)
            {
                RayTracingPrimitiveCulling = rayTracingPrimitiveCulling.Value;
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
        [NativeName("Name", "rayTracing")]
        public Bool32 RayTracing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingShaderGroupHandleCaptureReplay")]
        public Bool32 RayTracingShaderGroupHandleCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingShaderGroupHandleCaptureReplayMixed")]
        public Bool32 RayTracingShaderGroupHandleCaptureReplayMixed;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingAccelerationStructureCaptureReplay")]
        public Bool32 RayTracingAccelerationStructureCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingIndirectTraceRays")]
        public Bool32 RayTracingIndirectTraceRays;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingIndirectAccelerationStructureBuild")]
        public Bool32 RayTracingIndirectAccelerationStructureBuild;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingHostAccelerationStructureCommands")]
        public Bool32 RayTracingHostAccelerationStructureCommands;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayQuery")]
        public Bool32 RayQuery;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingPrimitiveCulling")]
        public Bool32 RayTracingPrimitiveCulling;
    }
}
