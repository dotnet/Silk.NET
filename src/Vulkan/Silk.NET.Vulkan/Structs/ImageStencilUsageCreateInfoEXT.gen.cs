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
    public unsafe struct ImageStencilUsageCreateInfoEXT
    {
        public ImageStencilUsageCreateInfoEXT
        (
            StructureType sType = StructureType.ImageStencilUsageCreateInfo,
            void* pNext = default,
            ImageUsageFlags stencilUsage = default
        )
        {
           SType = sType;
           PNext = pNext;
           StencilUsage = stencilUsage;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ImageUsageFlags StencilUsage;
    }
}
