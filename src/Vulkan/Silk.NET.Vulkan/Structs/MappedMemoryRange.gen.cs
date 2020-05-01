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
    public unsafe struct MappedMemoryRange
    {
        public MappedMemoryRange
        (
            StructureType sType = StructureType.MappedMemoryRange,
            void* pNext = default,
            DeviceMemory memory = default,
            ulong offset = default,
            ulong size = default
        )
        {
           SType = sType;
           PNext = pNext;
           Memory = memory;
           Offset = offset;
           Size = size;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DeviceMemory Memory;
/// <summary></summary>
        public ulong Offset;
/// <summary></summary>
        public ulong Size;
    }
}
