// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "VkPhysicalDeviceShaderCorePropertiesAMD")]
    public unsafe partial struct PhysicalDeviceShaderCorePropertiesAMD : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceShaderCorePropertiesAMD
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderCorePropertiesAmd,
            void* pNext = null,
            uint? shaderEngineCount = null,
            uint? shaderArraysPerEngineCount = null,
            uint? computeUnitsPerShaderArray = null,
            uint? simdPerComputeUnit = null,
            uint? wavefrontsPerSimd = null,
            uint? wavefrontSize = null,
            uint? sgprsPerSimd = null,
            uint? minSgprAllocation = null,
            uint? maxSgprAllocation = null,
            uint? sgprAllocationGranularity = null,
            uint? vgprsPerSimd = null,
            uint? minVgprAllocation = null,
            uint? maxVgprAllocation = null,
            uint? vgprAllocationGranularity = null
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

            if (shaderEngineCount is not null)
            {
                ShaderEngineCount = shaderEngineCount.Value;
            }

            if (shaderArraysPerEngineCount is not null)
            {
                ShaderArraysPerEngineCount = shaderArraysPerEngineCount.Value;
            }

            if (computeUnitsPerShaderArray is not null)
            {
                ComputeUnitsPerShaderArray = computeUnitsPerShaderArray.Value;
            }

            if (simdPerComputeUnit is not null)
            {
                SimdPerComputeUnit = simdPerComputeUnit.Value;
            }

            if (wavefrontsPerSimd is not null)
            {
                WavefrontsPerSimd = wavefrontsPerSimd.Value;
            }

            if (wavefrontSize is not null)
            {
                WavefrontSize = wavefrontSize.Value;
            }

            if (sgprsPerSimd is not null)
            {
                SgprsPerSimd = sgprsPerSimd.Value;
            }

            if (minSgprAllocation is not null)
            {
                MinSgprAllocation = minSgprAllocation.Value;
            }

            if (maxSgprAllocation is not null)
            {
                MaxSgprAllocation = maxSgprAllocation.Value;
            }

            if (sgprAllocationGranularity is not null)
            {
                SgprAllocationGranularity = sgprAllocationGranularity.Value;
            }

            if (vgprsPerSimd is not null)
            {
                VgprsPerSimd = vgprsPerSimd.Value;
            }

            if (minVgprAllocation is not null)
            {
                MinVgprAllocation = minVgprAllocation.Value;
            }

            if (maxVgprAllocation is not null)
            {
                MaxVgprAllocation = maxVgprAllocation.Value;
            }

            if (vgprAllocationGranularity is not null)
            {
                VgprAllocationGranularity = vgprAllocationGranularity.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderCorePropertiesAmd;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
