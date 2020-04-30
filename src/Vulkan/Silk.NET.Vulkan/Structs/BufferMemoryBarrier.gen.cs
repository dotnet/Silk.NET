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
    public unsafe struct BufferMemoryBarrier
    {
        public BufferMemoryBarrier
        (
            StructureType sType = StructureType.BufferMemoryBarrier,
            void* pNext = default,
            AccessFlags srcAccessMask = default,
            AccessFlags dstAccessMask = default,
            uint srcQueueFamilyIndex = default,
            uint dstQueueFamilyIndex = default,
            Buffer buffer = default,
            ulong offset = default,
            ulong size = default
        )
        {
           SType = sType;
           PNext = pNext;
           SrcAccessMask = srcAccessMask;
           DstAccessMask = dstAccessMask;
           SrcQueueFamilyIndex = srcQueueFamilyIndex;
           DstQueueFamilyIndex = dstQueueFamilyIndex;
           Buffer = buffer;
           Offset = offset;
           Size = size;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public AccessFlags SrcAccessMask;
/// <summary></summary>
        public AccessFlags DstAccessMask;
/// <summary></summary>
        public uint SrcQueueFamilyIndex;
/// <summary></summary>
        public uint DstQueueFamilyIndex;
/// <summary></summary>
        public Buffer Buffer;
/// <summary></summary>
        public ulong Offset;
/// <summary></summary>
        public ulong Size;
    }
}
