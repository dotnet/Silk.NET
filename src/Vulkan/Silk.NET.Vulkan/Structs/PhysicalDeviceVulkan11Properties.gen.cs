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
    public unsafe struct PhysicalDeviceVulkan11Properties
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
        /// <summary></summary>
       public fixed byte DeviceUuid[16];
        /// <summary></summary>
       public fixed byte DriverUuid[16];
        /// <summary></summary>
       public fixed byte DeviceLuid[8];
/// <summary></summary>
        public uint DeviceNodeMask;
/// <summary></summary>
        public Bool32 DeviceLuidvalid;
/// <summary></summary>
        public uint SubgroupSize;
/// <summary></summary>
        public ShaderStageFlags SubgroupSupportedStages;
/// <summary></summary>
        public SubgroupFeatureFlags SubgroupSupportedOperations;
/// <summary></summary>
        public Bool32 SubgroupQuadOperationsInAllStages;
/// <summary></summary>
        public PointClippingBehavior PointClippingBehavior;
/// <summary></summary>
        public uint MaxMultiviewViewCount;
/// <summary></summary>
        public uint MaxMultiviewInstanceIndex;
/// <summary></summary>
        public Bool32 ProtectedNoFault;
/// <summary></summary>
        public uint MaxPerSetDescriptors;
/// <summary></summary>
        public ulong MaxMemoryAllocationSize;
    }
}
