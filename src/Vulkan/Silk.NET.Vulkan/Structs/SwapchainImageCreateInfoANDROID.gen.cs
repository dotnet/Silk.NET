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
    public unsafe struct SwapchainImageCreateInfoANDROID
    {
        public SwapchainImageCreateInfoANDROID
        (
            StructureType sType = StructureType.SwapchainImageCreateInfoAndroid,
            void* pNext = default,
            SwapchainImageUsageFlagsANDROID usage = default
        )
        {
           SType = sType;
           PNext = pNext;
           Usage = usage;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SwapchainImageUsageFlagsANDROID Usage;
    }
}
