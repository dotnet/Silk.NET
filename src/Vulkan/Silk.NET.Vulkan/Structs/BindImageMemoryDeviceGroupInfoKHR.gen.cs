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
    public unsafe struct BindImageMemoryDeviceGroupInfoKHR
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint DeviceIndexCount;
/// <summary></summary>
        public uint* PDeviceIndices;
/// <summary></summary>
        public uint SplitInstanceBindRegionCount;
/// <summary></summary>
        public Rect2D* PSplitInstanceBindRegions;
    }
}
