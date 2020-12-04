// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDevice4444FormatsFeaturesEXT")]
    public unsafe partial struct PhysicalDevice4444FormatsFeaturesEXT
    {
        public PhysicalDevice4444FormatsFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDevice4444FormatsFeaturesExt,
            void* pNext = null,
            Bool32? formatA4R4G4B4 = null,
            Bool32? formatA4B4G4R4 = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (formatA4R4G4B4 is not null)
            {
                FormatA4R4G4B4 = formatA4R4G4B4.Value;
            }

            if (formatA4B4G4R4 is not null)
            {
                FormatA4B4G4R4 = formatA4B4G4R4.Value;
            }
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "formatA4R4G4B4")]
        public Bool32 FormatA4R4G4B4;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "formatA4B4G4R4")]
        public Bool32 FormatA4B4G4R4;
    }
}
