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
    [NativeName("Name", "VkMemoryRequirements")]
    public unsafe partial struct MemoryRequirements
    {
        public MemoryRequirements
        (
            ulong? size = null,
            ulong? alignment = null,
            uint? memoryTypeBits = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (alignment is not null)
            {
                Alignment = alignment.Value;
            }

            if (memoryTypeBits is not null)
            {
                MemoryTypeBits = memoryTypeBits.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "alignment")]
        public ulong Alignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryTypeBits")]
        public uint MemoryTypeBits;
    }
}
