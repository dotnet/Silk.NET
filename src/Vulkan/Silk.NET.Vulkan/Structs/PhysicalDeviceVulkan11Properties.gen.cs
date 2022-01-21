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
    [NativeName("Name", "VkPhysicalDeviceVulkan11Properties")]
    public unsafe partial struct PhysicalDeviceVulkan11Properties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceVulkan11Properties
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkan11Properties,
            void* pNext = null,
            uint? deviceNodeMask = null,
            Bool32? deviceLuidvalid = null,
            uint? subgroupSize = null,
            ShaderStageFlags? subgroupSupportedStages = null,
            SubgroupFeatureFlags? subgroupSupportedOperations = null,
            Bool32? subgroupQuadOperationsInAllStages = null,
            PointClippingBehavior? pointClippingBehavior = null,
            uint? maxMultiviewViewCount = null,
            uint? maxMultiviewInstanceIndex = null,
            Bool32? protectedNoFault = null,
            uint? maxPerSetDescriptors = null,
            ulong? maxMemoryAllocationSize = null
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

            if (deviceNodeMask is not null)
            {
                DeviceNodeMask = deviceNodeMask.Value;
            }

            if (deviceLuidvalid is not null)
            {
                DeviceLuidvalid = deviceLuidvalid.Value;
            }

            if (subgroupSize is not null)
            {
                SubgroupSize = subgroupSize.Value;
            }

            if (subgroupSupportedStages is not null)
            {
                SubgroupSupportedStages = subgroupSupportedStages.Value;
            }

            if (subgroupSupportedOperations is not null)
            {
                SubgroupSupportedOperations = subgroupSupportedOperations.Value;
            }

            if (subgroupQuadOperationsInAllStages is not null)
            {
                SubgroupQuadOperationsInAllStages = subgroupQuadOperationsInAllStages.Value;
            }

            if (pointClippingBehavior is not null)
            {
                PointClippingBehavior = pointClippingBehavior.Value;
            }

            if (maxMultiviewViewCount is not null)
            {
                MaxMultiviewViewCount = maxMultiviewViewCount.Value;
            }

            if (maxMultiviewInstanceIndex is not null)
            {
                MaxMultiviewInstanceIndex = maxMultiviewInstanceIndex.Value;
            }

            if (protectedNoFault is not null)
            {
                ProtectedNoFault = protectedNoFault.Value;
            }

            if (maxPerSetDescriptors is not null)
            {
                MaxPerSetDescriptors = maxPerSetDescriptors.Value;
            }

            if (maxMemoryAllocationSize is not null)
            {
                MaxMemoryAllocationSize = maxMemoryAllocationSize.Value;
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
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "deviceUUID")]
        public fixed byte DeviceUuid[16];
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "driverUUID")]
        public fixed byte DriverUuid[16];
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "deviceLUID")]
        public fixed byte DeviceLuid[8];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceNodeMask")]
        public uint DeviceNodeMask;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceLUIDValid")]
        public Bool32 DeviceLuidvalid;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subgroupSize")]
        public uint SubgroupSize;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "subgroupSupportedStages")]
        public ShaderStageFlags SubgroupSupportedStages;
/// <summary></summary>
        [NativeName("Type", "VkSubgroupFeatureFlags")]
        [NativeName("Type.Name", "VkSubgroupFeatureFlags")]
        [NativeName("Name", "subgroupSupportedOperations")]
        public SubgroupFeatureFlags SubgroupSupportedOperations;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "subgroupQuadOperationsInAllStages")]
        public Bool32 SubgroupQuadOperationsInAllStages;
/// <summary></summary>
        [NativeName("Type", "VkPointClippingBehavior")]
        [NativeName("Type.Name", "VkPointClippingBehavior")]
        [NativeName("Name", "pointClippingBehavior")]
        public PointClippingBehavior PointClippingBehavior;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMultiviewViewCount")]
        public uint MaxMultiviewViewCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMultiviewInstanceIndex")]
        public uint MaxMultiviewInstanceIndex;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "protectedNoFault")]
        public Bool32 ProtectedNoFault;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerSetDescriptors")]
        public uint MaxPerSetDescriptors;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxMemoryAllocationSize")]
        public ulong MaxMemoryAllocationSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkan11Properties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
