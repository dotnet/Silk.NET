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
    [NativeName("Name", "VkSparseMemoryBind")]
    public unsafe partial struct SparseMemoryBind
    {
        public SparseMemoryBind
        (
            ulong? resourceOffset = null,
            ulong? size = null,
            DeviceMemory? memory = null,
            ulong? memoryOffset = null,
            SparseMemoryBindFlags? flags = null
        ) : this()
        {
            if (resourceOffset is not null)
            {
                ResourceOffset = resourceOffset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (memory is not null)
            {
                Memory = memory.Value;
            }

            if (memoryOffset is not null)
            {
                MemoryOffset = memoryOffset.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "resourceOffset")]
        public ulong ResourceOffset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "memory")]
        public DeviceMemory Memory;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "memoryOffset")]
        public ulong MemoryOffset;
/// <summary></summary>
        [NativeName("Type", "VkSparseMemoryBindFlags")]
        [NativeName("Type.Name", "VkSparseMemoryBindFlags")]
        [NativeName("Name", "flags")]
        public SparseMemoryBindFlags Flags;
    }
}
