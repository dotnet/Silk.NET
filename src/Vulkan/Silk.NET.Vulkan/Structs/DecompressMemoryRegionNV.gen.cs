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
    [NativeName("Name", "VkDecompressMemoryRegionNV")]
    public unsafe partial struct DecompressMemoryRegionNV
    {
        public DecompressMemoryRegionNV
        (
            ulong? srcAddress = null,
            ulong? dstAddress = null,
            ulong? compressedSize = null,
            ulong? decompressedSize = null,
            MemoryDecompressionMethodFlagsNV? decompressionMethod = null
        ) : this()
        {
            if (srcAddress is not null)
            {
                SrcAddress = srcAddress.Value;
            }

            if (dstAddress is not null)
            {
                DstAddress = dstAddress.Value;
            }

            if (compressedSize is not null)
            {
                CompressedSize = compressedSize.Value;
            }

            if (decompressedSize is not null)
            {
                DecompressedSize = decompressedSize.Value;
            }

            if (decompressionMethod is not null)
            {
                DecompressionMethod = decompressionMethod.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "srcAddress")]
        public ulong SrcAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "dstAddress")]
        public ulong DstAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "compressedSize")]
        public ulong CompressedSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "decompressedSize")]
        public ulong DecompressedSize;
/// <summary></summary>
        [NativeName("Type", "VkMemoryDecompressionMethodFlagsNV")]
        [NativeName("Type.Name", "VkMemoryDecompressionMethodFlagsNV")]
        [NativeName("Name", "decompressionMethod")]
        public MemoryDecompressionMethodFlagsNV DecompressionMethod;
    }
}
