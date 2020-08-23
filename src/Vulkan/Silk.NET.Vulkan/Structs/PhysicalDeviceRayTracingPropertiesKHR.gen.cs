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
    [NativeName("Name", "VkPhysicalDeviceRayTracingPropertiesKHR")]
    public unsafe partial struct PhysicalDeviceRayTracingPropertiesKHR
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderGroupHandleSize")]
        public uint ShaderGroupHandleSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRecursionDepth")]
        public uint MaxRecursionDepth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxShaderGroupStride")]
        public uint MaxShaderGroupStride;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderGroupBaseAlignment")]
        public uint ShaderGroupBaseAlignment;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxGeometryCount")]
        public ulong MaxGeometryCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxInstanceCount")]
        public ulong MaxInstanceCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxPrimitiveCount")]
        public ulong MaxPrimitiveCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetAccelerationStructures")]
        public uint MaxDescriptorSetAccelerationStructures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderGroupHandleCaptureReplaySize")]
        public uint ShaderGroupHandleCaptureReplaySize;
    }
}
