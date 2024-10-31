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
    [NativeName("Name", "VkSparseImageMemoryRequirements")]
    public unsafe partial struct SparseImageMemoryRequirements
    {
        public SparseImageMemoryRequirements
        (
            SparseImageFormatProperties? formatProperties = null,
            uint? imageMipTailFirstLod = null,
            ulong? imageMipTailSize = null,
            ulong? imageMipTailOffset = null,
            ulong? imageMipTailStride = null
        ) : this()
        {
            if (formatProperties is not null)
            {
                FormatProperties = formatProperties.Value;
            }

            if (imageMipTailFirstLod is not null)
            {
                ImageMipTailFirstLod = imageMipTailFirstLod.Value;
            }

            if (imageMipTailSize is not null)
            {
                ImageMipTailSize = imageMipTailSize.Value;
            }

            if (imageMipTailOffset is not null)
            {
                ImageMipTailOffset = imageMipTailOffset.Value;
            }

            if (imageMipTailStride is not null)
            {
                ImageMipTailStride = imageMipTailStride.Value;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
