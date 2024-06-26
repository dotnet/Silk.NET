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
    [NativeName("Name", "VkPhysicalDeviceMaintenance6PropertiesKHR")]
    public unsafe partial struct PhysicalDeviceMaintenance6PropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceMaintenance6PropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceMaintenance6PropertiesKhr,
            void* pNext = null,
            Bool32? blockTexelViewCompatibleMultipleLayers = null,
            uint? maxCombinedImageSamplerDescriptorCount = null,
            Bool32? fragmentShadingRateClampCombinerInputs = null
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

            if (blockTexelViewCompatibleMultipleLayers is not null)
            {
                BlockTexelViewCompatibleMultipleLayers = blockTexelViewCompatibleMultipleLayers.Value;
            }

            if (maxCombinedImageSamplerDescriptorCount is not null)
            {
                MaxCombinedImageSamplerDescriptorCount = maxCombinedImageSamplerDescriptorCount.Value;
            }

            if (fragmentShadingRateClampCombinerInputs is not null)
            {
                FragmentShadingRateClampCombinerInputs = fragmentShadingRateClampCombinerInputs.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "blockTexelViewCompatibleMultipleLayers")]
        public Bool32 BlockTexelViewCompatibleMultipleLayers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxCombinedImageSamplerDescriptorCount")]
        public uint MaxCombinedImageSamplerDescriptorCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateClampCombinerInputs")]
        public Bool32 FragmentShadingRateClampCombinerInputs;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMaintenance6PropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
