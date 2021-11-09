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
    [NativeName("Name", "VkPhysicalDeviceSubgroupProperties")]
    public unsafe partial struct PhysicalDeviceSubgroupProperties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceSubgroupProperties
        (
            StructureType? sType = StructureType.PhysicalDeviceSubgroupProperties,
            void* pNext = null,
            uint? subgroupSize = null,
            ShaderStageFlags? supportedStages = null,
            SubgroupFeatureFlags? supportedOperations = null,
            Bool32? quadOperationsInAllStages = null
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

            if (subgroupSize is not null)
            {
                SubgroupSize = subgroupSize.Value;
            }

            if (supportedStages is not null)
            {
                SupportedStages = supportedStages.Value;
            }

            if (supportedOperations is not null)
            {
                SupportedOperations = supportedOperations.Value;
            }

            if (quadOperationsInAllStages is not null)
            {
                QuadOperationsInAllStages = quadOperationsInAllStages.Value;
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
        [NativeName("Name", "subgroupSize")]
        public uint SubgroupSize;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "supportedStages")]
        public ShaderStageFlags SupportedStages;
/// <summary></summary>
        [NativeName("Type", "VkSubgroupFeatureFlags")]
        [NativeName("Type.Name", "VkSubgroupFeatureFlags")]
        [NativeName("Name", "supportedOperations")]
        public SubgroupFeatureFlags SupportedOperations;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "quadOperationsInAllStages")]
        public Bool32 QuadOperationsInAllStages;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceSubgroupProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
