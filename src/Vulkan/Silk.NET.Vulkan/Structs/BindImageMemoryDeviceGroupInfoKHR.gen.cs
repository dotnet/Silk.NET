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
    [NativeName("Name", "VkBindImageMemoryDeviceGroupInfoKHR")]
    public unsafe partial struct BindImageMemoryDeviceGroupInfoKHR
    {
        public BindImageMemoryDeviceGroupInfoKHR
        (
            StructureType sType = StructureType.BindImageMemoryDeviceGroupInfo,
            void* pNext = default,
            uint deviceIndexCount = default,
            uint* pDeviceIndices = default,
            uint splitInstanceBindRegionCount = default,
            Rect2D* pSplitInstanceBindRegions = default
        )
        {
            SType = sType;
            PNext = pNext;
            DeviceIndexCount = deviceIndexCount;
            PDeviceIndices = pDeviceIndices;
            SplitInstanceBindRegionCount = splitInstanceBindRegionCount;
            PSplitInstanceBindRegions = pSplitInstanceBindRegions;
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
        [NativeName("Name", "deviceIndexCount")]
        public uint DeviceIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDeviceIndices")]
        public uint* PDeviceIndices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "splitInstanceBindRegionCount")]
        public uint SplitInstanceBindRegionCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pSplitInstanceBindRegions")]
        public Rect2D* PSplitInstanceBindRegions;
    }
}
