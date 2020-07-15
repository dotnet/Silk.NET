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
    [NativeName("Name", "VkMemoryHostPointerPropertiesEXT")]
    public unsafe partial struct MemoryHostPointerPropertiesEXT
    {
        public MemoryHostPointerPropertiesEXT
        (
            StructureType sType = StructureType.MemoryHostPointerPropertiesExt,
            void* pNext = default,
            uint memoryTypeBits = default
        )
        {
            SType = sType;
            PNext = pNext;
            MemoryTypeBits = memoryTypeBits;
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
        [NativeName("Name", "memoryTypeBits")]
        public uint MemoryTypeBits;
    }
}
