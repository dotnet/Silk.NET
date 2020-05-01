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
    public unsafe struct AcquireNextImageInfoKHR
    {
        public AcquireNextImageInfoKHR
        (
            StructureType sType = StructureType.AcquireNextImageInfoKhr,
            void* pNext = default,
            SwapchainKHR swapchain = default,
            ulong timeout = default,
            Semaphore semaphore = default,
            Fence fence = default,
            uint deviceMask = default
        )
        {
           SType = sType;
           PNext = pNext;
           Swapchain = swapchain;
           Timeout = timeout;
           Semaphore = semaphore;
           Fence = fence;
           DeviceMask = deviceMask;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SwapchainKHR Swapchain;
/// <summary></summary>
        public ulong Timeout;
/// <summary></summary>
        public Semaphore Semaphore;
/// <summary></summary>
        public Fence Fence;
/// <summary></summary>
        public uint DeviceMask;
    }
}
