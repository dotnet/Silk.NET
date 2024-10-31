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
    [NativeName("Name", "VkPhysicalDeviceVulkanMemoryModelFeatures")]
    [NativeName("Aliases", "VkPhysicalDeviceVulkanMemoryModelFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceVulkanMemoryModelFeatures : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceVulkanMemoryModelFeatures
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkanMemoryModelFeatures,
            void* pNext = null,
            Bool32? vulkanMemoryModel = null,
            Bool32? vulkanMemoryModelDeviceScope = null,
            Bool32? vulkanMemoryModelAvailabilityVisibilityChains = null
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

            if (vulkanMemoryModel is not null)
            {
                VulkanMemoryModel = vulkanMemoryModel.Value;
            }

            if (vulkanMemoryModelDeviceScope is not null)
            {
                VulkanMemoryModelDeviceScope = vulkanMemoryModelDeviceScope.Value;
            }

            if (vulkanMemoryModelAvailabilityVisibilityChains is not null)
            {
                VulkanMemoryModelAvailabilityVisibilityChains = vulkanMemoryModelAvailabilityVisibilityChains.Value;
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
        [NativeName("Name", "vulkanMemoryModel")]
        public Bool32 VulkanMemoryModel;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vulkanMemoryModelDeviceScope")]
        public Bool32 VulkanMemoryModelDeviceScope;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vulkanMemoryModelAvailabilityVisibilityChains")]
        public Bool32 VulkanMemoryModelAvailabilityVisibilityChains;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkanMemoryModelFeatures;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
