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
    public unsafe struct DeviceGroupSubmitInfoKHR
    {
        public DeviceGroupSubmitInfoKHR
        (
            StructureType sType = StructureType.DeviceGroupSubmitInfo,
            void* pNext = default,
            uint waitSemaphoreCount = default,
            uint* pWaitSemaphoreDeviceIndices = default,
            uint commandBufferCount = default,
            uint* pCommandBufferDeviceMasks = default,
            uint signalSemaphoreCount = default,
            uint* pSignalSemaphoreDeviceIndices = default
        )
        {
           SType = sType;
           PNext = pNext;
           WaitSemaphoreCount = waitSemaphoreCount;
           PWaitSemaphoreDeviceIndices = pWaitSemaphoreDeviceIndices;
           CommandBufferCount = commandBufferCount;
           PCommandBufferDeviceMasks = pCommandBufferDeviceMasks;
           SignalSemaphoreCount = signalSemaphoreCount;
           PSignalSemaphoreDeviceIndices = pSignalSemaphoreDeviceIndices;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint WaitSemaphoreCount;
/// <summary></summary>
        public uint* PWaitSemaphoreDeviceIndices;
/// <summary></summary>
        public uint CommandBufferCount;
/// <summary></summary>
        public uint* PCommandBufferDeviceMasks;
/// <summary></summary>
        public uint SignalSemaphoreCount;
/// <summary></summary>
        public uint* PSignalSemaphoreDeviceIndices;
    }
}
