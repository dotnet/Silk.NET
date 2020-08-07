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
    public unsafe struct PhysicalDevice4444FormatsFeaturesEXT
    {
        public PhysicalDevice4444FormatsFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDevice4444FormatsFeaturesExt,
            void* pNext = default,
            Bool32 formatA4R4G4B4 = default,
            Bool32 formatA4B4G4R4 = default
        )
        {
           SType = sType;
           PNext = pNext;
           FormatA4R4G4B4 = formatA4R4G4B4;
           FormatA4B4G4R4 = formatA4B4G4R4;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 FormatA4R4G4B4;
/// <summary></summary>
        public Bool32 FormatA4B4G4R4;
    }
}
