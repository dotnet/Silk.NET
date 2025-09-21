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
    [NativeName("Name", "VkVideoFormatPropertiesKHR")]
    public unsafe partial struct VideoFormatPropertiesKHR : IChainStart
    {
        public VideoFormatPropertiesKHR
        (
            StructureType? sType = StructureType.VideoFormatPropertiesKhr,
            void* pNext = null,
            Format? format = null,
            ComponentMapping? componentMapping = null,
            ImageCreateFlags? imageCreateFlags = null,
            ImageType? imageType = null,
            ImageTiling? imageTiling = null,
            ImageUsageFlags? imageUsageFlags = null
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (componentMapping is not null)
            {
                ComponentMapping = componentMapping.Value;
            }

            if (imageCreateFlags is not null)
            {
                ImageCreateFlags = imageCreateFlags.Value;
            }

            if (imageType is not null)
            {
                ImageType = imageType.Value;
            }

            if (imageTiling is not null)
            {
                ImageTiling = imageTiling.Value;
            }

            if (imageUsageFlags is not null)
            {
                ImageUsageFlags = imageUsageFlags.Value;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkComponentMapping")]
        [NativeName("Type.Name", "VkComponentMapping")]
        [NativeName("Name", "componentMapping")]
        public ComponentMapping ComponentMapping;
/// <summary></summary>
        [NativeName("Type", "VkImageCreateFlags")]
        [NativeName("Type.Name", "VkImageCreateFlags")]
        [NativeName("Name", "imageCreateFlags")]
        public ImageCreateFlags ImageCreateFlags;
/// <summary></summary>
        [NativeName("Type", "VkImageType")]
        [NativeName("Type.Name", "VkImageType")]
        [NativeName("Name", "imageType")]
        public ImageType ImageType;
/// <summary></summary>
        [NativeName("Type", "VkImageTiling")]
        [NativeName("Type.Name", "VkImageTiling")]
        [NativeName("Name", "imageTiling")]
        public ImageTiling ImageTiling;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "imageUsageFlags")]
        public ImageUsageFlags ImageUsageFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoFormatPropertiesKhr;
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
        public static unsafe ref VideoFormatPropertiesKHR Chain(
            out VideoFormatPropertiesKHR capture)
        {
            capture = new VideoFormatPropertiesKHR(StructureType.VideoFormatPropertiesKhr);
            return ref capture;
        }
    }
}
