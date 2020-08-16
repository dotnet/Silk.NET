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
    [NativeName("Name", "VkBindImageMemoryInfo")]
    public unsafe partial struct BindImageMemoryInfo
    {
        public BindImageMemoryInfo
        (
            StructureType sType = StructureType.BindImageMemoryInfo,
            void* pNext = default,
            Image image = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default
        )
        {
            SType = sType;
            PNext = pNext;
            Image = image;
            Memory = memory;
            MemoryOffset = memoryOffset;
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
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "memory")]
        public DeviceMemory Memory;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "memoryOffset")]
        public ulong MemoryOffset;
    }
}
