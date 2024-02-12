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
    [NativeName("Name", "VkImageToMemoryCopyEXT")]
    public unsafe partial struct ImageToMemoryCopyEXT : IChainable
    {
        public ImageToMemoryCopyEXT
        (
            StructureType? sType = StructureType.ImageToMemoryCopyExt,
            void* pNext = null,
            void* pHostPointer = null,
            uint? memoryRowLength = null,
            uint? memoryImageHeight = null,
            ImageSubresourceLayers? imageSubresource = null,
            Offset3D? imageOffset = null,
            Extent3D? imageExtent = null
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

            if (pHostPointer is not null)
            {
                PHostPointer = pHostPointer;
            }

            if (memoryRowLength is not null)
            {
                MemoryRowLength = memoryRowLength.Value;
            }

            if (memoryImageHeight is not null)
            {
                MemoryImageHeight = memoryImageHeight.Value;
            }

            if (imageSubresource is not null)
            {
                ImageSubresource = imageSubresource.Value;
            }

            if (imageOffset is not null)
            {
                ImageOffset = imageOffset.Value;
            }

            if (imageExtent is not null)
            {
                ImageExtent = imageExtent.Value;
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
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pHostPointer")]
        public void* PHostPointer;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryRowLength")]
        public uint MemoryRowLength;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryImageHeight")]
        public uint MemoryImageHeight;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "imageSubresource")]
        public ImageSubresourceLayers ImageSubresource;
/// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "imageOffset")]
        public Offset3D ImageOffset;
/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "imageExtent")]
        public Extent3D ImageExtent;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageToMemoryCopyExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
