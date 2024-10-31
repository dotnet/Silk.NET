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
    [NativeName("Name", "VkRenderPassBeginInfo")]
    public unsafe partial struct RenderPassBeginInfo : IChainStart
    {
        public RenderPassBeginInfo
        (
            StructureType? sType = StructureType.RenderPassBeginInfo,
            void* pNext = null,
            RenderPass? renderPass = null,
            Framebuffer? framebuffer = null,
            Rect2D? renderArea = null,
            uint? clearValueCount = null,
            ClearValue* pClearValues = null
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

            if (renderPass is not null)
            {
                RenderPass = renderPass.Value;
            }

            if (framebuffer is not null)
            {
                Framebuffer = framebuffer.Value;
            }

            if (renderArea is not null)
            {
                RenderArea = renderArea.Value;
            }

            if (clearValueCount is not null)
            {
                ClearValueCount = clearValueCount.Value;
            }

            if (pClearValues is not null)
            {
                PClearValues = pClearValues;
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
        [NativeName("Type", "VkRenderPass")]
        [NativeName("Type.Name", "VkRenderPass")]
        [NativeName("Name", "renderPass")]
        public RenderPass RenderPass;
/// <summary></summary>
        [NativeName("Type", "VkFramebuffer")]
        [NativeName("Type.Name", "VkFramebuffer")]
        [NativeName("Name", "framebuffer")]
        public Framebuffer Framebuffer;
/// <summary></summary>
        [NativeName("Type", "VkRect2D")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "renderArea")]
        public Rect2D RenderArea;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clearValueCount")]
        public uint ClearValueCount;
/// <summary></summary>
        [NativeName("Type", "VkClearValue*")]
        [NativeName("Type.Name", "VkClearValue")]
        [NativeName("Name", "pClearValues")]
        public ClearValue* PClearValues;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassBeginInfo;
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
        public static unsafe ref RenderPassBeginInfo Chain(
            out RenderPassBeginInfo capture)
        {
            capture = new RenderPassBeginInfo(StructureType.RenderPassBeginInfo);
            return ref capture;
        }
    }
}
