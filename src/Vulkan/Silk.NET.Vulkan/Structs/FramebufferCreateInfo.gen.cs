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
    [NativeName("Name", "VkFramebufferCreateInfo")]
    public unsafe partial struct FramebufferCreateInfo : IChainStart
    {
        public FramebufferCreateInfo
        (
            StructureType? sType = StructureType.FramebufferCreateInfo,
            void* pNext = null,
            FramebufferCreateFlags? flags = null,
            RenderPass? renderPass = null,
            uint? attachmentCount = null,
            ImageView* pAttachments = null,
            uint? width = null,
            uint? height = null,
            uint? layers = null
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

            if (renderPass is not null)
            {
                RenderPass = renderPass.Value;
            }

            if (attachmentCount is not null)
            {
                AttachmentCount = attachmentCount.Value;
            }

            if (pAttachments is not null)
            {
                PAttachments = pAttachments;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (layers is not null)
            {
                Layers = layers.Value;
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
        [NativeName("Type", "VkFramebufferCreateFlags")]
        [NativeName("Type.Name", "VkFramebufferCreateFlags")]
        [NativeName("Name", "flags")]
        public FramebufferCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkRenderPass")]
        [NativeName("Type.Name", "VkRenderPass")]
        [NativeName("Name", "renderPass")]
        public RenderPass RenderPass;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentCount")]
        public uint AttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkImageView*")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "pAttachments")]
        public ImageView* PAttachments;
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
        [NativeName("Name", "layers")]
        public uint Layers;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FramebufferCreateInfo;
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
        public static unsafe ref FramebufferCreateInfo Chain(
            out FramebufferCreateInfo capture)
        {
            capture = new FramebufferCreateInfo(StructureType.FramebufferCreateInfo);
            return ref capture;
        }
    }
}
