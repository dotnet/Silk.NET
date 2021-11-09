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
    [NativeName("Name", "VkRenderingInfoKHR")]
    public unsafe partial struct RenderingInfoKHR : IChainStart
    {
        public RenderingInfoKHR
        (
            StructureType? sType = StructureType.RenderingInfoKhr,
            void* pNext = null,
            RenderingFlagsKHR? flags = null,
            Rect2D? renderArea = null,
            uint? layerCount = null,
            uint? viewMask = null,
            uint? colorAttachmentCount = null,
            RenderingAttachmentInfoKHR* pColorAttachments = null,
            RenderingAttachmentInfoKHR* pDepthAttachment = null,
            RenderingAttachmentInfoKHR* pStencilAttachment = null
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

            if (renderArea is not null)
            {
                RenderArea = renderArea.Value;
            }

            if (layerCount is not null)
            {
                LayerCount = layerCount.Value;
            }

            if (viewMask is not null)
            {
                ViewMask = viewMask.Value;
            }

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (pColorAttachments is not null)
            {
                PColorAttachments = pColorAttachments;
            }

            if (pDepthAttachment is not null)
            {
                PDepthAttachment = pDepthAttachment;
            }

            if (pStencilAttachment is not null)
            {
                PStencilAttachment = pStencilAttachment;
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
        [NativeName("Type", "VkRenderingFlagsKHR")]
        [NativeName("Type.Name", "VkRenderingFlagsKHR")]
        [NativeName("Name", "flags")]
        public RenderingFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkRect2D")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "renderArea")]
        public Rect2D RenderArea;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layerCount")]
        public uint LayerCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewMask")]
        public uint ViewMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkRenderingAttachmentInfoKHR*")]
        [NativeName("Type.Name", "VkRenderingAttachmentInfoKHR")]
        [NativeName("Name", "pColorAttachments")]
        public RenderingAttachmentInfoKHR* PColorAttachments;
/// <summary></summary>
        [NativeName("Type", "VkRenderingAttachmentInfoKHR*")]
        [NativeName("Type.Name", "VkRenderingAttachmentInfoKHR")]
        [NativeName("Name", "pDepthAttachment")]
        public RenderingAttachmentInfoKHR* PDepthAttachment;
/// <summary></summary>
        [NativeName("Type", "VkRenderingAttachmentInfoKHR*")]
        [NativeName("Type.Name", "VkRenderingAttachmentInfoKHR")]
        [NativeName("Name", "pStencilAttachment")]
        public RenderingAttachmentInfoKHR* PStencilAttachment;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderingInfoKhr;
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
        public static unsafe ref RenderingInfoKHR Chain(
            out RenderingInfoKHR capture)
        {
            capture = new RenderingInfoKHR(StructureType.RenderingInfoKhr);
            return ref capture;
        }
    }
}
