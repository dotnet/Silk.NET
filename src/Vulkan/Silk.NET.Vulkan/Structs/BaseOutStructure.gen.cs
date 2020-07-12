// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBaseOutStructure")]
    public unsafe partial struct BaseOutStructure
    {
        public BaseOutStructure
        (
            StructureType sType = default,
            BaseOutStructure* pNext = default
        )
        {
            SType = sType;
            PNext = pNext;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "VkBaseOutStructure*")]
        [NativeName("Type.Name", "VkBaseOutStructure")]
        [NativeName("Name", "pNext")]
        public BaseOutStructure* PNext;
    }
}
