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
    [NativeName("Name", "VkSemaphoreCreateInfo")]
    public unsafe partial struct SemaphoreCreateInfo
    {
        public SemaphoreCreateInfo
        (
            StructureType sType = StructureType.SemaphoreCreateInfo,
            void* pNext = default,
            uint flags = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
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
        [NativeName("Type", "VkSemaphoreCreateFlags")]
        [NativeName("Type.Name", "VkSemaphoreCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
    }
}
