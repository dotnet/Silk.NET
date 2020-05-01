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
    public unsafe struct DeviceGroupRenderPassBeginInfoKHR
    {
        public DeviceGroupRenderPassBeginInfoKHR
        (
            StructureType sType = StructureType.DeviceGroupRenderPassBeginInfo,
            void* pNext = default,
            uint deviceMask = default,
            uint deviceRenderAreaCount = default,
            Rect2D* pDeviceRenderAreas = default
        )
        {
           SType = sType;
           PNext = pNext;
           DeviceMask = deviceMask;
           DeviceRenderAreaCount = deviceRenderAreaCount;
           PDeviceRenderAreas = pDeviceRenderAreas;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint DeviceMask;
/// <summary></summary>
        public uint DeviceRenderAreaCount;
/// <summary></summary>
        public Rect2D* PDeviceRenderAreas;
    }
}
