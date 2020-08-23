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
    [NativeName("Name", "VkPhysicalDeviceVulkan11Properties")]
    public unsafe partial struct PhysicalDeviceVulkan11Properties
    {
        public PhysicalDeviceVulkan11Properties
        (
            StructureType sType = StructureType.PhysicalDeviceVulkan11Properties,
            void* pNext = default,
            uint deviceNodeMask = default,
            Bool32 deviceLuidvalid = default,
            uint subgroupSize = default,
            ShaderStageFlags subgroupSupportedStages = default,
            SubgroupFeatureFlags subgroupSupportedOperations = default,
            Bool32 subgroupQuadOperationsInAllStages = default,
            PointClippingBehavior pointClippingBehavior = default,
            uint maxMultiviewViewCount = default,
            uint maxMultiviewInstanceIndex = default,
            Bool32 protectedNoFault = default,
            uint maxPerSetDescriptors = default,
            ulong maxMemoryAllocationSize = default
        )
        {
            SType = sType;
            PNext = pNext;
            DeviceNodeMask = deviceNodeMask;
            DeviceLuidvalid = deviceLuidvalid;
            SubgroupSize = subgroupSize;
            SubgroupSupportedStages = subgroupSupportedStages;
            SubgroupSupportedOperations = subgroupSupportedOperations;
            SubgroupQuadOperationsInAllStages = subgroupQuadOperationsInAllStages;
            PointClippingBehavior = pointClippingBehavior;
            MaxMultiviewViewCount = maxMultiviewViewCount;
            MaxMultiviewInstanceIndex = maxMultiviewInstanceIndex;
            ProtectedNoFault = protectedNoFault;
            MaxPerSetDescriptors = maxPerSetDescriptors;
            MaxMemoryAllocationSize = maxMemoryAllocationSize;
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
    }
}
