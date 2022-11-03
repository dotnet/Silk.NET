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
    [NativeName("Name", "VkFramebufferAttachmentImageInfo")]
    [NativeName("Aliases", "VkFramebufferAttachmentImageInfoKHR")]
    public unsafe partial struct FramebufferAttachmentImageInfo : IChainable
    {
        public FramebufferAttachmentImageInfo
        (
            StructureType? sType = StructureType.FramebufferAttachmentImageInfo,
            void* pNext = null,
            ImageCreateFlags? flags = null,
            ImageUsageFlags? usage = null,
            uint? width = null,
            uint? height = null,
            uint? layerCount = null,
            uint? viewFormatCount = null,
            Format* pViewFormats = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (layerCount is not null)
            {
                LayerCount = layerCount.Value;
            }

            if (viewFormatCount is not null)
            {
                ViewFormatCount = viewFormatCount.Value;
            }

            if (pViewFormats is not null)
            {
                PViewFormats = pViewFormats;
            }
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
        [NativeName("Type", "VkImageCreateFlags")]
        [NativeName("Type.Name", "VkImageCreateFlags")]
        [NativeName("Name", "flags")]
        public ImageCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "usage")]
        public ImageUsageFlags Usage;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "width")]
        public uint Width;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "height")]
        public uint Height;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layerCount")]
        public uint LayerCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewFormatCount")]
        public uint ViewFormatCount;
/// <summary></summary>
        [NativeName("Type", "VkFormat*")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "pViewFormats")]
        public Format* PViewFormats;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FramebufferAttachmentImageInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
