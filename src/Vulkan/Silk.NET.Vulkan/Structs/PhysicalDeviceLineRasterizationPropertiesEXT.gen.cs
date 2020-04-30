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
    public unsafe struct PhysicalDeviceLineRasterizationPropertiesEXT
    {
        public PhysicalDeviceLineRasterizationPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceLineRasterizationPropertiesExt,
            void* pNext = default,
            uint lineSubPixelPrecisionBits = default
        )
        {
           SType = sType;
           PNext = pNext;
           LineSubPixelPrecisionBits = lineSubPixelPrecisionBits;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint LineSubPixelPrecisionBits;
    }
}
