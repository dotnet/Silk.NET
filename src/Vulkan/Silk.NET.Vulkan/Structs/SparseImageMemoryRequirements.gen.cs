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
    [NativeName("Name", "VkSparseImageMemoryRequirements")]
    public unsafe partial struct SparseImageMemoryRequirements
    {
        public SparseImageMemoryRequirements
        (
            SparseImageFormatProperties formatProperties = default,
            uint imageMipTailFirstLod = default,
            ulong imageMipTailSize = default,
            ulong imageMipTailOffset = default,
            ulong imageMipTailStride = default
        )
        {
            FormatProperties = formatProperties;
            ImageMipTailFirstLod = imageMipTailFirstLod;
            ImageMipTailSize = imageMipTailSize;
            ImageMipTailOffset = imageMipTailOffset;
            ImageMipTailStride = imageMipTailStride;
        }

/// <summary></summary>
        [NativeName("Type", "VkSparseImageFormatProperties")]
        [NativeName("Type.Name", "VkSparseImageFormatProperties")]
        [NativeName("Name", "formatProperties")]
        public SparseImageFormatProperties FormatProperties;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageMipTailFirstLod")]
        public uint ImageMipTailFirstLod;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "imageMipTailSize")]
        public ulong ImageMipTailSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "imageMipTailOffset")]
        public ulong ImageMipTailOffset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "imageMipTailStride")]
        public ulong ImageMipTailStride;
    }
}
