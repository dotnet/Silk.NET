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
    [NativeName("Name", "VkPresentRegionsKHR")]
    public unsafe partial struct PresentRegionsKHR
    {
        public PresentRegionsKHR
        (
            StructureType sType = StructureType.PresentRegionsKhr,
            void* pNext = default,
            uint swapchainCount = default,
            PresentRegionKHR* pRegions = default
        )
        {
            SType = sType;
            PNext = pNext;
            SwapchainCount = swapchainCount;
            PRegions = pRegions;
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
        [NativeName("Name", "swapchainCount")]
        public uint SwapchainCount;
/// <summary></summary>
        [NativeName("Type", "VkPresentRegionKHR*")]
        [NativeName("Type.Name", "VkPresentRegionKHR")]
        [NativeName("Name", "pRegions")]
        public PresentRegionKHR* PRegions;
    }
}
