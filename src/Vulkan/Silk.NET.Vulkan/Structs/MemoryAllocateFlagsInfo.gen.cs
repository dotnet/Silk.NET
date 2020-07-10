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
    [NativeName("Name", "VkMemoryAllocateFlagsInfo")]
    public unsafe partial struct MemoryAllocateFlagsInfo
    {
        public MemoryAllocateFlagsInfo
        (
            StructureType sType = StructureType.MemoryAllocateFlagsInfo,
            void* pNext = default,
            MemoryAllocateFlags flags = default,
            uint deviceMask = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            DeviceMask = deviceMask;
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
        [NativeName("Type", "VkMemoryAllocateFlags")]
        [NativeName("Type.Name", "VkMemoryAllocateFlags")]
        [NativeName("Name", "flags")]
        public MemoryAllocateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceMask")]
        public uint DeviceMask;
    }
}
