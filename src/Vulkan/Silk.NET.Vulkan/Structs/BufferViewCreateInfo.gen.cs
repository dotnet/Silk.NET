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
    public unsafe struct BufferViewCreateInfo
    {
        public BufferViewCreateInfo
        (
            StructureType sType = StructureType.BufferViewCreateInfo,
            void* pNext = default,
            uint flags = default,
            Buffer buffer = default,
            Format format = default,
            ulong offset = default,
            ulong range = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Buffer = buffer;
           Format = format;
           Offset = offset;
           Range = range;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public Buffer Buffer;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public ulong Offset;
/// <summary></summary>
        public ulong Range;
    }
}
