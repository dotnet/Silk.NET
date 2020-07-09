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
    [NativeName("Name", "VkPhysicalDeviceRayTracingPropertiesNV")]
    public unsafe struct PhysicalDeviceRayTracingPropertiesNV
    {
        public PhysicalDeviceRayTracingPropertiesNV
        (
            StructureType sType = StructureType.PhysicalDeviceRayTracingPropertiesNV,
            void* pNext = default,
            uint shaderGroupHandleSize = default,
            uint maxRecursionDepth = default,
            uint maxShaderGroupStride = default,
            uint shaderGroupBaseAlignment = default,
            ulong maxGeometryCount = default,
            ulong maxInstanceCount = default,
            ulong maxTriangleCount = default,
            uint maxDescriptorSetAccelerationStructures = default
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
           MaxTriangleCount = maxTriangleCount;
           MaxDescriptorSetAccelerationStructures = maxDescriptorSetAccelerationStructures;
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
        [NativeName("Name", "maxTriangleCount")]
        public ulong MaxTriangleCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetAccelerationStructures")]
        public uint MaxDescriptorSetAccelerationStructures;
    }
}
