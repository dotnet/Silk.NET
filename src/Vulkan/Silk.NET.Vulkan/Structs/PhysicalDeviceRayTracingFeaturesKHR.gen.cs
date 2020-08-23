// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            StructureType sType = StructureType.PhysicalDeviceRayTracingFeaturesKhr,
            void* pNext = default,
            Bool32 rayTracing = default,
            Bool32 rayTracingShaderGroupHandleCaptureReplay = default,
            Bool32 rayTracingShaderGroupHandleCaptureReplayMixed = default,
            Bool32 rayTracingAccelerationStructureCaptureReplay = default,
            Bool32 rayTracingIndirectTraceRays = default,
            Bool32 rayTracingIndirectAccelerationStructureBuild = default,
            Bool32 rayTracingHostAccelerationStructureCommands = default,
            Bool32 rayQuery = default,
            Bool32 rayTracingPrimitiveCulling = default
        )
        {
            SType = sType;
            PNext = pNext;
            RayTracing = rayTracing;
            RayTracingShaderGroupHandleCaptureReplay = rayTracingShaderGroupHandleCaptureReplay;
            RayTracingShaderGroupHandleCaptureReplayMixed = rayTracingShaderGroupHandleCaptureReplayMixed;
            RayTracingAccelerationStructureCaptureReplay = rayTracingAccelerationStructureCaptureReplay;
            RayTracingIndirectTraceRays = rayTracingIndirectTraceRays;
            RayTracingIndirectAccelerationStructureBuild = rayTracingIndirectAccelerationStructureBuild;
            RayTracingHostAccelerationStructureCommands = rayTracingHostAccelerationStructureCommands;
            RayQuery = rayQuery;
            RayTracingPrimitiveCulling = rayTracingPrimitiveCulling;
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
