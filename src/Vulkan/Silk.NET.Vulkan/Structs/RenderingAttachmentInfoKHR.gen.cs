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
    [NativeName("Name", "VkRenderingAttachmentInfoKHR")]
    [NativeName("AliasOf", "VkRenderingAttachmentInfo")]
    public unsafe partial struct RenderingAttachmentInfoKHR : IChainStart
    {
        public RenderingAttachmentInfoKHR
        (
            StructureType? sType = StructureType.RenderingAttachmentInfo,
            void* pNext = null,
            ImageView? imageView = null,
            ImageLayout? imageLayout = null,
            ResolveModeFlags? resolveMode = null,
            ImageView? resolveImageView = null,
            ImageLayout? resolveImageLayout = null,
            AttachmentLoadOp? loadOp = null,
            AttachmentStoreOp? storeOp = null,
            ClearValue? clearValue = null
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

            if (imageView is not null)
            {
                ImageView = imageView.Value;
            }

            if (imageLayout is not null)
            {
                ImageLayout = imageLayout.Value;
            }

            if (resolveMode is not null)
            {
                ResolveMode = resolveMode.Value;
            }

            if (resolveImageView is not null)
            {
                ResolveImageView = resolveImageView.Value;
            }

            if (resolveImageLayout is not null)
            {
                ResolveImageLayout = resolveImageLayout.Value;
            }

            if (loadOp is not null)
            {
                LoadOp = loadOp.Value;
            }

            if (storeOp is not null)
            {
                StoreOp = storeOp.Value;
            }

            if (clearValue is not null)
            {
                ClearValue = clearValue.Value;
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
        [NativeName("Type", "VkImageView")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "imageView")]
        public ImageView ImageView;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "imageLayout")]
        public ImageLayout ImageLayout;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlagBits")]
        [NativeName("Type.Name", "VkResolveModeFlagBits")]
        [NativeName("Name", "resolveMode")]
        public ResolveModeFlags ResolveMode;
/// <summary></summary>
        [NativeName("Type", "VkImageView")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "resolveImageView")]
        public ImageView ResolveImageView;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "resolveImageLayout")]
        public ImageLayout ResolveImageLayout;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentLoadOp")]
        [NativeName("Type.Name", "VkAttachmentLoadOp")]
        [NativeName("Name", "loadOp")]
        public AttachmentLoadOp LoadOp;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentStoreOp")]
        [NativeName("Type.Name", "VkAttachmentStoreOp")]
        [NativeName("Name", "storeOp")]
        public AttachmentStoreOp StoreOp;
/// <summary></summary>
        [NativeName("Type", "VkClearValue")]
        [NativeName("Type.Name", "VkClearValue")]
        [NativeName("Name", "clearValue")]
        public ClearValue ClearValue;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderingAttachmentInfo;
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
        public static unsafe ref RenderingAttachmentInfoKHR Chain(
            out RenderingAttachmentInfoKHR capture)
        {
            capture = new RenderingAttachmentInfoKHR(StructureType.RenderingAttachmentInfo);
            return ref capture;
        }
    }
}
