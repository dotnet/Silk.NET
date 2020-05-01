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
    public unsafe struct BindBufferMemoryInfoKHR
    {
        public BindBufferMemoryInfoKHR
        (
            StructureType sType = StructureType.BindBufferMemoryInfo,
            void* pNext = default,
            Buffer buffer = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default
        )
        {
           SType = sType;
           PNext = pNext;
           Buffer = buffer;
           Memory = memory;
           MemoryOffset = memoryOffset;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Buffer Buffer;
/// <summary></summary>
        public DeviceMemory Memory;
/// <summary></summary>
        public ulong MemoryOffset;
    }
}
