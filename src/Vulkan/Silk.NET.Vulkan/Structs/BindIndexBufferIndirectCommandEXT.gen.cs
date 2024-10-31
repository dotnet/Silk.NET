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
    [NativeName("Name", "VkBindIndexBufferIndirectCommandEXT")]
    public unsafe partial struct BindIndexBufferIndirectCommandEXT
    {
        public BindIndexBufferIndirectCommandEXT
        (
            ulong? bufferAddress = null,
            uint? size = null,
            IndexType? indexType = null
        ) : this()
        {
            if (bufferAddress is not null)
            {
                BufferAddress = bufferAddress.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (indexType is not null)
            {
                IndexType = indexType.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "bufferAddress")]
        public ulong BufferAddress;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "size")]
        public uint Size;
/// <summary></summary>
        [NativeName("Type", "VkIndexType")]
        [NativeName("Type.Name", "VkIndexType")]
        [NativeName("Name", "indexType")]
        public IndexType IndexType;
    }
}
