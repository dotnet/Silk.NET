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
    public unsafe struct PresentInfoKHR
    {
        public PresentInfoKHR
        (
            StructureType sType = StructureType.PresentInfoKhr,
            void* pNext = default,
            uint waitSemaphoreCount = default,
            Semaphore* pWaitSemaphores = default,
            uint swapchainCount = default,
            SwapchainKHR* pSwapchains = default,
            uint* pImageIndices = default,
            Result* pResults = default
        )
        {
           SType = sType;
           PNext = pNext;
           WaitSemaphoreCount = waitSemaphoreCount;
           PWaitSemaphores = pWaitSemaphores;
           SwapchainCount = swapchainCount;
           PSwapchains = pSwapchains;
           PImageIndices = pImageIndices;
           PResults = pResults;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint WaitSemaphoreCount;
/// <summary></summary>
        public Semaphore* PWaitSemaphores;
/// <summary></summary>
        public uint SwapchainCount;
/// <summary></summary>
        public SwapchainKHR* PSwapchains;
/// <summary></summary>
        public uint* PImageIndices;
/// <summary></summary>
        public Result* PResults;
    }
}
