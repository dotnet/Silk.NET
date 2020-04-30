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
    public unsafe struct PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
    {
        public PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures,
            void* pNext = default,
            Bool32 separateDepthStencilLayouts = default
        )
        {
           SType = sType;
           PNext = pNext;
           SeparateDepthStencilLayouts = separateDepthStencilLayouts;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 SeparateDepthStencilLayouts;
    }
}
