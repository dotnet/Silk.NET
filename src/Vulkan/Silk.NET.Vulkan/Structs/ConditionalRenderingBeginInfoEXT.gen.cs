// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkConditionalRenderingBeginInfoEXT")]
    public unsafe partial struct ConditionalRenderingBeginInfoEXT
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
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "buffer")]
        public Buffer Buffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "offset")]
        public ulong Offset;
/// <summary></summary>
        [NativeName("Type", "VkConditionalRenderingFlagsEXT")]
        [NativeName("Type.Name", "VkConditionalRenderingFlagsEXT")]
        [NativeName("Name", "flags")]
        public ConditionalRenderingFlagsEXT Flags;
    }
}
