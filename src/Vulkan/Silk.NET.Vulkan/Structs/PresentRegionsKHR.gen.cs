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
    public unsafe struct PresentRegionsKHR
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint SwapchainCount;
/// <summary></summary>
        public PresentRegionKHR* PRegions;
    }
}
