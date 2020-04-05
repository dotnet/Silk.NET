// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct DeviceGroupPresentInfoKHR
    {
        public DeviceGroupPresentInfoKHR
        (
            StructureType sType = StructureType.DeviceGroupPresentInfoKhr,
            void* pNext = default,
            uint swapchainCount = default,
            uint* pDeviceMasks = default,
            DeviceGroupPresentModeFlagsKHR mode = default
        )
        {
           SType = sType;
           PNext = pNext;
           SwapchainCount = swapchainCount;
           PDeviceMasks = pDeviceMasks;
           Mode = mode;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint SwapchainCount;
/// <summary></summary>
        public uint* PDeviceMasks;
/// <summary></summary>
        public DeviceGroupPresentModeFlagsKHR Mode;
    }
}
