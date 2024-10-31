// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            Buffer? buffer = null,
            uint? bindCount = null,
            SparseMemoryBind* pBinds = null
        ) : this()
        {
            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (bindCount is not null)
            {
                BindCount = bindCount.Value;
            }

            if (pBinds is not null)
            {
                PBinds = pBinds;
            }
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
