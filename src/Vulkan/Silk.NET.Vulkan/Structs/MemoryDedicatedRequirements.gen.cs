// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMemoryDedicatedRequirements")]
    public unsafe partial struct MemoryDedicatedRequirements
    {
        public MemoryDedicatedRequirements
        (
            StructureType? sType = StructureType.MemoryDedicatedRequirements,
            void* pNext = null,
            Bool32? prefersDedicatedAllocation = null,
            Bool32? requiresDedicatedAllocation = null
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

            if (prefersDedicatedAllocation is not null)
            {
                PrefersDedicatedAllocation = prefersDedicatedAllocation.Value;
            }

            if (requiresDedicatedAllocation is not null)
            {
                RequiresDedicatedAllocation = requiresDedicatedAllocation.Value;
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
        [NativeName("Name", "prefersDedicatedAllocation")]
        public Bool32 PrefersDedicatedAllocation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "requiresDedicatedAllocation")]
        public Bool32 RequiresDedicatedAllocation;
    }
}
