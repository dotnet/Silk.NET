// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSparseBufferMemoryBindInfo")]
    public unsafe partial struct SparseBufferMemoryBindInfo
    {
        public SparseBufferMemoryBindInfo
        (
            Buffer buffer = default,
            uint bindCount = default,
            SparseMemoryBind* pBinds = default
        )
        {
            Buffer = buffer;
            BindCount = bindCount;
            PBinds = pBinds;
        }

/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "buffer")]
        public Buffer Buffer;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bindCount")]
        public uint BindCount;
/// <summary></summary>
        [NativeName("Type", "VkSparseMemoryBind*")]
        [NativeName("Type.Name", "VkSparseMemoryBind")]
        [NativeName("Name", "pBinds")]
        public SparseMemoryBind* PBinds;
    }
}
