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
    public unsafe struct StridedBufferRegionKHR
    {
        public StridedBufferRegionKHR
        (
            Buffer buffer = default,
            ulong offset = default,
            ulong stride = default,
            ulong size = default
        )
        {
           Buffer = buffer;
           Offset = offset;
           Stride = stride;
           Size = size;
        }

/// <summary></summary>
        public Buffer Buffer;
/// <summary></summary>
        public ulong Offset;
/// <summary></summary>
        public ulong Stride;
/// <summary></summary>
        public ulong Size;
    }
}
