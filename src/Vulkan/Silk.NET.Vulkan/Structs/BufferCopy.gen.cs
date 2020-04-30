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
    public unsafe struct BufferCopy
    {
        public BufferCopy
        (
            ulong srcOffset = default,
            ulong dstOffset = default,
            ulong size = default
        )
        {
           SrcOffset = srcOffset;
           DstOffset = dstOffset;
           Size = size;
        }

/// <summary></summary>
        public ulong SrcOffset;
/// <summary></summary>
        public ulong DstOffset;
/// <summary></summary>
        public ulong Size;
    }
}
