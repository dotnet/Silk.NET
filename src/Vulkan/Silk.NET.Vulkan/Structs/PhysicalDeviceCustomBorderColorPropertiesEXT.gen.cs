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
    public unsafe struct PhysicalDeviceCustomBorderColorPropertiesEXT
    {
        public PhysicalDeviceCustomBorderColorPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceCustomBorderColorPropertiesExt,
            void* pNext = default,
            uint maxCustomBorderColorSamplers = default
        )
        {
           SType = sType;
           PNext = pNext;
           MaxCustomBorderColorSamplers = maxCustomBorderColorSamplers;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxCustomBorderColorSamplers;
    }
}
