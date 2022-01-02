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
    [NativeName("Name", "VkPhysicalDeviceSubgroupSizeControlPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceSubgroupSizeControlPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceSubgroupSizeControlPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceSubgroupSizeControlPropertiesExt,
            void* pNext = null,
            uint? minSubgroupSize = null,
            uint? maxSubgroupSize = null,
            uint? maxComputeWorkgroupSubgroups = null,
            ShaderStageFlags? requiredSubgroupSizeStages = null
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

            if (minSubgroupSize is not null)
            {
                MinSubgroupSize = minSubgroupSize.Value;
            }

            if (maxSubgroupSize is not null)
            {
                MaxSubgroupSize = maxSubgroupSize.Value;
            }

            if (maxComputeWorkgroupSubgroups is not null)
            {
                MaxComputeWorkgroupSubgroups = maxComputeWorkgroupSubgroups.Value;
            }

            if (requiredSubgroupSizeStages is not null)
            {
                RequiredSubgroupSizeStages = requiredSubgroupSizeStages.Value;
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
        [NativeName("Name", "minSubgroupSize")]
        public uint MinSubgroupSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSubgroupSize")]
        public uint MaxSubgroupSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkgroupSubgroups")]
        public uint MaxComputeWorkgroupSubgroups;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "requiredSubgroupSizeStages")]
        public ShaderStageFlags RequiredSubgroupSizeStages;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceSubgroupSizeControlPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
