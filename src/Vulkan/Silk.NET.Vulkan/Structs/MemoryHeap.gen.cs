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
    [NativeName("Name", "VkMemoryHeap")]
    public unsafe partial struct MemoryHeap
    {
        public MemoryHeap
        (
            ulong? size = null,
            MemoryHeapFlags? flags = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkMemoryHeapFlags")]
        [NativeName("Type.Name", "VkMemoryHeapFlags")]
        [NativeName("Name", "flags")]
        public MemoryHeapFlags Flags;
    }
}
