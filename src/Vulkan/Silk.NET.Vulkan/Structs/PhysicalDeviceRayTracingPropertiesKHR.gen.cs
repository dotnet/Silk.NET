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
    public unsafe struct PhysicalDeviceRayTracingPropertiesKHR
    {
        public PhysicalDeviceRayTracingPropertiesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceRayTracingPropertiesKhr,
            void* pNext = default,
            uint shaderGroupHandleSize = default,
            uint maxRecursionDepth = default,
            uint maxShaderGroupStride = default,
            uint shaderGroupBaseAlignment = default,
            ulong maxGeometryCount = default,
            ulong maxInstanceCount = default,
            ulong maxPrimitiveCount = default,
            uint maxDescriptorSetAccelerationStructures = default,
            uint shaderGroupHandleCaptureReplaySize = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderGroupHandleSize = shaderGroupHandleSize;
           MaxRecursionDepth = maxRecursionDepth;
           MaxShaderGroupStride = maxShaderGroupStride;
           ShaderGroupBaseAlignment = shaderGroupBaseAlignment;
           MaxGeometryCount = maxGeometryCount;
           MaxInstanceCount = maxInstanceCount;
           MaxPrimitiveCount = maxPrimitiveCount;
           MaxDescriptorSetAccelerationStructures = maxDescriptorSetAccelerationStructures;
           ShaderGroupHandleCaptureReplaySize = shaderGroupHandleCaptureReplaySize;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint ShaderGroupHandleSize;
/// <summary></summary>
        public uint MaxRecursionDepth;
/// <summary></summary>
        public uint MaxShaderGroupStride;
/// <summary></summary>
        public uint ShaderGroupBaseAlignment;
/// <summary></summary>
        public ulong MaxGeometryCount;
/// <summary></summary>
        public ulong MaxInstanceCount;
/// <summary></summary>
        public ulong MaxPrimitiveCount;
/// <summary></summary>
        public uint MaxDescriptorSetAccelerationStructures;
/// <summary></summary>
        public uint ShaderGroupHandleCaptureReplaySize;
    }
}
