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
    public unsafe struct SparseMemoryBind
    {
        public SparseMemoryBind
        (
            ulong resourceOffset = default,
            ulong size = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default,
            SparseMemoryBindFlags flags = default
        )
        {
           ResourceOffset = resourceOffset;
           Size = size;
           Memory = memory;
           MemoryOffset = memoryOffset;
           Flags = flags;
        }

/// <summary></summary>
        public ulong ResourceOffset;
/// <summary></summary>
        public ulong Size;
/// <summary></summary>
        public DeviceMemory Memory;
/// <summary></summary>
        public ulong MemoryOffset;
/// <summary></summary>
        public SparseMemoryBindFlags Flags;
    }
}
