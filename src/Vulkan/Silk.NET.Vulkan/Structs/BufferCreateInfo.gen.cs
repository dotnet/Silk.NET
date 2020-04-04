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
    public unsafe struct BufferCreateInfo
    {
        public BufferCreateInfo
        (
            StructureType sType = StructureType.BufferCreateInfo,
            void* pNext = default,
            BufferCreateFlags flags = default,
            ulong size = default,
            BufferUsageFlags usage = default,
            SharingMode sharingMode = default,
            uint queueFamilyIndexCount = default,
            uint* pQueueFamilyIndices = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Size = size;
           Usage = usage;
           SharingMode = sharingMode;
           QueueFamilyIndexCount = queueFamilyIndexCount;
           PQueueFamilyIndices = pQueueFamilyIndices;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public BufferCreateFlags Flags;
/// <summary></summary>
        public ulong Size;
/// <summary></summary>
        public BufferUsageFlags Usage;
/// <summary></summary>
        public SharingMode SharingMode;
/// <summary></summary>
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        public uint* PQueueFamilyIndices;
    }
}
