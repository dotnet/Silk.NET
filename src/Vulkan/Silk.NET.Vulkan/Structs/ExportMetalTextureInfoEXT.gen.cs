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
    [NativeName("Name", "VkExportMetalTextureInfoEXT")]
    public unsafe partial struct ExportMetalTextureInfoEXT : IExtendsChain<ExportMetalObjectsInfoEXT>
    {
        public ExportMetalTextureInfoEXT
        (
            StructureType? sType = StructureType.ExportMetalTextureInfoExt,
            void* pNext = null,
            Image? image = null,
            ImageView? imageView = null,
            BufferView? bufferView = null,
            ImageAspectFlags? plane = null,
            nint? mtlTexture = null
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

            if (image is not null)
            {
                Image = image.Value;
            }

            if (imageView is not null)
            {
                ImageView = imageView.Value;
            }

            if (bufferView is not null)
            {
                BufferView = bufferView.Value;
            }

            if (plane is not null)
            {
                Plane = plane.Value;
            }

            if (mtlTexture is not null)
            {
                MtlTexture = mtlTexture.Value;
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
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;
/// <summary></summary>
        [NativeName("Type", "VkImageView")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "imageView")]
        public ImageView ImageView;
/// <summary></summary>
        [NativeName("Type", "VkBufferView")]
        [NativeName("Type.Name", "VkBufferView")]
        [NativeName("Name", "bufferView")]
        public BufferView BufferView;
/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlagBits")]
        [NativeName("Type.Name", "VkImageAspectFlagBits")]
        [NativeName("Name", "plane")]
        public ImageAspectFlags Plane;
/// <summary></summary>
        [NativeName("Type", "MTLTexture_id")]
        [NativeName("Type.Name", "MTLTexture_id")]
        [NativeName("Name", "mtlTexture")]
        public nint MtlTexture;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExportMetalTextureInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
