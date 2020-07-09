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
    [NativeName("Name", "VkDeviceGroupSubmitInfoKHR")]
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
        [NativeName("Name", "waitSemaphoreCount")]
        public uint WaitSemaphoreCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pWaitSemaphoreDeviceIndices")]
        public uint* PWaitSemaphoreDeviceIndices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandBufferCount")]
        public uint CommandBufferCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pCommandBufferDeviceMasks")]
        public uint* PCommandBufferDeviceMasks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "signalSemaphoreCount")]
        public uint SignalSemaphoreCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pSignalSemaphoreDeviceIndices")]
        public uint* PSignalSemaphoreDeviceIndices;
    }
}
