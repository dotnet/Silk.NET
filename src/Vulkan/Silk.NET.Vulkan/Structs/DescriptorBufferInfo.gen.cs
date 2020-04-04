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
    public unsafe struct DescriptorBufferInfo
    {
        public DescriptorBufferInfo
        (
            Buffer buffer = default,
            ulong offset = default,
            ulong range = default
        )
        {
           Buffer = buffer;
           Offset = offset;
           Range = range;
        }

/// <summary></summary>
        public Buffer Buffer;
/// <summary></summary>
        public ulong Offset;
/// <summary></summary>
        public ulong Range;
    }
}
