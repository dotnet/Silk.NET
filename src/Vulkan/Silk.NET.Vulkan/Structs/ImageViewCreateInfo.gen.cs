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
    [NativeName("Name", "VkImageViewCreateInfo")]
    public unsafe partial struct ImageViewCreateInfo : IChainStart
    {
        public ImageViewCreateInfo
        (
            StructureType? sType = StructureType.ImageViewCreateInfo,
            void* pNext = null,
            ImageViewCreateFlags? flags = null,
            Image? image = null,
            ImageViewType? viewType = null,
            Format? format = null,
            ComponentMapping? components = null,
            ImageSubresourceRange? subresourceRange = null
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

            if (image is not null)
            {
                Image = image.Value;
            }

            if (viewType is not null)
            {
                ViewType = viewType.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (components is not null)
            {
                Components = components.Value;
            }

            if (subresourceRange is not null)
            {
                SubresourceRange = subresourceRange.Value;
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
        [NativeName("Type", "VkImageViewCreateFlags")]
        [NativeName("Type.Name", "VkImageViewCreateFlags")]
        [NativeName("Name", "flags")]
        public ImageViewCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;
/// <summary></summary>
        [NativeName("Type", "VkImageViewType")]
        [NativeName("Type.Name", "VkImageViewType")]
        [NativeName("Name", "viewType")]
        public ImageViewType ViewType;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkComponentMapping")]
        [NativeName("Type.Name", "VkComponentMapping")]
        [NativeName("Name", "components")]
        public ComponentMapping Components;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceRange")]
        [NativeName("Type.Name", "VkImageSubresourceRange")]
        [NativeName("Name", "subresourceRange")]
        public ImageSubresourceRange SubresourceRange;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageViewCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref ImageViewCreateInfo Chain(
            out ImageViewCreateInfo capture)
        {
            capture = new ImageViewCreateInfo(StructureType.ImageViewCreateInfo);
            return ref capture;
        }
    }
}
