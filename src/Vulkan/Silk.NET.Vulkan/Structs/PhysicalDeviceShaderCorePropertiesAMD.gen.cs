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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint ShaderEngineCount;
/// <summary></summary>
        public uint ShaderArraysPerEngineCount;
/// <summary></summary>
        public uint ComputeUnitsPerShaderArray;
/// <summary></summary>
        public uint SimdPerComputeUnit;
/// <summary></summary>
        public uint WavefrontsPerSimd;
/// <summary></summary>
        public uint WavefrontSize;
/// <summary></summary>
        public uint SgprsPerSimd;
/// <summary></summary>
        public uint MinSgprAllocation;
/// <summary></summary>
        public uint MaxSgprAllocation;
/// <summary></summary>
        public uint SgprAllocationGranularity;
/// <summary></summary>
        public uint VgprsPerSimd;
/// <summary></summary>
        public uint MinVgprAllocation;
/// <summary></summary>
        public uint MaxVgprAllocation;
/// <summary></summary>
        public uint VgprAllocationGranularity;
    }
}
