// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct MemoryDedicatedAllocateInfoKHR
    {
        public MemoryDedicatedAllocateInfoKHR
        (
            StructureType sType = StructureType.MemoryDedicatedAllocateInfo,
            void* pNext = default,
            Image image = default,
            Buffer buffer = default
        )
        {
           SType = sType;
           PNext = pNext;
           Image = image;
           Buffer = buffer;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Image Image;
/// <summary></summary>
        public Buffer Buffer;
    }
}
