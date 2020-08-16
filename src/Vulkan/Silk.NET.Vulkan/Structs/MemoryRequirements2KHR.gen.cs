// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMemoryRequirements2KHR")]
    public unsafe partial struct MemoryRequirements2KHR
    {
        public MemoryRequirements2KHR
        (
            StructureType sType = StructureType.MemoryRequirements2,
            void* pNext = default,
            MemoryRequirements memoryRequirements = default
        )
        {
            SType = sType;
            PNext = pNext;
            MemoryRequirements = memoryRequirements;
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
        [NativeName("Type", "VkMemoryRequirements")]
        [NativeName("Type.Name", "VkMemoryRequirements")]
        [NativeName("Name", "memoryRequirements")]
        public MemoryRequirements MemoryRequirements;
    }
}
