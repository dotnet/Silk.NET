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
    [NativeName("Name", "VkPhysicalDeviceShaderCorePropertiesAMD")]
    public unsafe struct PhysicalDeviceShaderCorePropertiesAMD
    {
        public PhysicalDeviceShaderCorePropertiesAMD
        (
            StructureType sType = StructureType.PhysicalDeviceShaderCorePropertiesAmd,
            void* pNext = default,
            uint shaderEngineCount = default,
            uint shaderArraysPerEngineCount = default,
            uint computeUnitsPerShaderArray = default,
            uint simdPerComputeUnit = default,
            uint wavefrontsPerSimd = default,
            uint wavefrontSize = default,
            uint sgprsPerSimd = default,
            uint minSgprAllocation = default,
            uint maxSgprAllocation = default,
            uint sgprAllocationGranularity = default,
            uint vgprsPerSimd = default,
            uint minVgprAllocation = default,
            uint maxVgprAllocation = default,
            uint vgprAllocationGranularity = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderEngineCount = shaderEngineCount;
           ShaderArraysPerEngineCount = shaderArraysPerEngineCount;
           ComputeUnitsPerShaderArray = computeUnitsPerShaderArray;
           SimdPerComputeUnit = simdPerComputeUnit;
           WavefrontsPerSimd = wavefrontsPerSimd;
           WavefrontSize = wavefrontSize;
           SgprsPerSimd = sgprsPerSimd;
           MinSgprAllocation = minSgprAllocation;
           MaxSgprAllocation = maxSgprAllocation;
           SgprAllocationGranularity = sgprAllocationGranularity;
           VgprsPerSimd = vgprsPerSimd;
           MinVgprAllocation = minVgprAllocation;
           MaxVgprAllocation = maxVgprAllocation;
           VgprAllocationGranularity = vgprAllocationGranularity;
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
        [NativeName("Name", "shaderEngineCount")]
        public uint ShaderEngineCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderArraysPerEngineCount")]
        public uint ShaderArraysPerEngineCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "computeUnitsPerShaderArray")]
        public uint ComputeUnitsPerShaderArray;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "simdPerComputeUnit")]
        public uint SimdPerComputeUnit;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "wavefrontsPerSimd")]
        public uint WavefrontsPerSimd;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "wavefrontSize")]
        public uint WavefrontSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sgprsPerSimd")]
        public uint SgprsPerSimd;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minSgprAllocation")]
        public uint MinSgprAllocation;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSgprAllocation")]
        public uint MaxSgprAllocation;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sgprAllocationGranularity")]
        public uint SgprAllocationGranularity;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vgprsPerSimd")]
        public uint VgprsPerSimd;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minVgprAllocation")]
        public uint MinVgprAllocation;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVgprAllocation")]
        public uint MaxVgprAllocation;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vgprAllocationGranularity")]
        public uint VgprAllocationGranularity;
    }
}
