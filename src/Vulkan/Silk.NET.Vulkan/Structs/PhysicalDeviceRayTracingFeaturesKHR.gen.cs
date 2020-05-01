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

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceRayTracingFeaturesKHR
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 RayTracing;
/// <summary></summary>
        public Bool32 RayTracingShaderGroupHandleCaptureReplay;
/// <summary></summary>
        public Bool32 RayTracingShaderGroupHandleCaptureReplayMixed;
/// <summary></summary>
        public Bool32 RayTracingAccelerationStructureCaptureReplay;
/// <summary></summary>
        public Bool32 RayTracingIndirectTraceRays;
/// <summary></summary>
        public Bool32 RayTracingIndirectAccelerationStructureBuild;
/// <summary></summary>
        public Bool32 RayTracingHostAccelerationStructureCommands;
/// <summary></summary>
        public Bool32 RayQuery;
/// <summary></summary>
        public Bool32 RayTracingPrimitiveCulling;
    }
}
