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
    public unsafe struct ConditionalRenderingBeginInfoEXT
    {
        public ConditionalRenderingBeginInfoEXT
        (
            StructureType sType = StructureType.ConditionalRenderingBeginInfoExt,
            void* pNext = default,
            Buffer buffer = default,
            ulong offset = default,
            ConditionalRenderingFlagsEXT flags = default
        )
        {
           SType = sType;
           PNext = pNext;
           Buffer = buffer;
           Offset = offset;
           Flags = flags;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Buffer Buffer;
/// <summary></summary>
        public ulong Offset;
/// <summary></summary>
        public ConditionalRenderingFlagsEXT Flags;
    }
}
