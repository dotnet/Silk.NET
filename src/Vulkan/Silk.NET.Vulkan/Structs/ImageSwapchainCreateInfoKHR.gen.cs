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
    public unsafe struct ImageSwapchainCreateInfoKHR
    {
        public ImageSwapchainCreateInfoKHR
        (
            StructureType sType = StructureType.ImageSwapchainCreateInfoKhr,
            void* pNext = default,
            SwapchainKHR swapchain = default
        )
        {
           SType = sType;
           PNext = pNext;
           Swapchain = swapchain;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SwapchainKHR Swapchain;
    }
}
