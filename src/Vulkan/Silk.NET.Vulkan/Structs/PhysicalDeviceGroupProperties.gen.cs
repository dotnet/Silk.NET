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
    [NativeName("Name", "VkPhysicalDeviceGroupProperties")]
    public unsafe partial struct PhysicalDeviceGroupProperties
    {
        public PhysicalDeviceGroupProperties
        (
            StructureType sType = StructureType.PhysicalDeviceGroupProperties,
            void* pNext = default,
            uint physicalDeviceCount = default,
            Bool32 subsetAllocation = default
        )
        {
            SType = sType;
            PNext = pNext;
            PhysicalDeviceCount = physicalDeviceCount;
           PhysicalDevices_0 = default;
           PhysicalDevices_1 = default;
           PhysicalDevices_2 = default;
           PhysicalDevices_3 = default;
           PhysicalDevices_4 = default;
           PhysicalDevices_5 = default;
           PhysicalDevices_6 = default;
           PhysicalDevices_7 = default;
           PhysicalDevices_8 = default;
           PhysicalDevices_9 = default;
           PhysicalDevices_10 = default;
           PhysicalDevices_11 = default;
           PhysicalDevices_12 = default;
           PhysicalDevices_13 = default;
           PhysicalDevices_14 = default;
           PhysicalDevices_15 = default;
           PhysicalDevices_16 = default;
           PhysicalDevices_17 = default;
           PhysicalDevices_18 = default;
           PhysicalDevices_19 = default;
           PhysicalDevices_20 = default;
           PhysicalDevices_21 = default;
           PhysicalDevices_22 = default;
           PhysicalDevices_23 = default;
           PhysicalDevices_24 = default;
           PhysicalDevices_25 = default;
           PhysicalDevices_26 = default;
           PhysicalDevices_27 = default;
           PhysicalDevices_28 = default;
           PhysicalDevices_29 = default;
           PhysicalDevices_30 = default;
           PhysicalDevices_31 = default;
            SubsetAllocation = subsetAllocation;
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
        [NativeName("Name", "physicalDeviceCount")]
        public uint PhysicalDeviceCount;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_0;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_1;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_2;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_3;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_4;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_5;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_6;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_7;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_8;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_9;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_10;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_11;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_12;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_13;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_14;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_15;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_16;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_17;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_18;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_19;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_20;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_21;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_22;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_23;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_24;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_25;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_26;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_27;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_28;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_29;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_30;
        /// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevices")]
        public PhysicalDevice PhysicalDevices_31;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "subsetAllocation")]
        public Bool32 SubsetAllocation;
    }
}
