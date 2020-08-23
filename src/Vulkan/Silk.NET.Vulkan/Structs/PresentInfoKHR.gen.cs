// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPresentInfoKHR")]
    public unsafe partial struct PresentInfoKHR
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
        [NativeName("Type", "VkSemaphore*")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "pWaitSemaphores")]
        public Semaphore* PWaitSemaphores;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "swapchainCount")]
        public uint SwapchainCount;
/// <summary></summary>
        [NativeName("Type", "VkSwapchainKHR*")]
        [NativeName("Type.Name", "VkSwapchainKHR")]
        [NativeName("Name", "pSwapchains")]
        public SwapchainKHR* PSwapchains;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pImageIndices")]
        public uint* PImageIndices;
/// <summary></summary>
        [NativeName("Type", "VkResult*")]
        [NativeName("Type.Name", "VkResult")]
        [NativeName("Name", "pResults")]
        public Result* PResults;
    }
}
