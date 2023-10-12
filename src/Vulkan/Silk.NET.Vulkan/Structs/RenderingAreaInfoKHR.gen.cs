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
    [NativeName("Name", "VkRenderingAreaInfoKHR")]
    public unsafe partial struct RenderingAreaInfoKHR : IChainable
    {
        public RenderingAreaInfoKHR
        (
            StructureType? sType = StructureType.RenderingAreaInfoKhr,
            void* pNext = null,
            uint? viewMask = null,
            uint? colorAttachmentCount = null,
            Format* pColorAttachmentFormats = null,
            Format? depthAttachmentFormat = null,
            Format? stencilAttachmentFormat = null
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

            if (viewMask is not null)
            {
                ViewMask = viewMask.Value;
            }

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (pColorAttachmentFormats is not null)
            {
                PColorAttachmentFormats = pColorAttachmentFormats;
            }

            if (depthAttachmentFormat is not null)
            {
                DepthAttachmentFormat = depthAttachmentFormat.Value;
            }

            if (stencilAttachmentFormat is not null)
            {
                StencilAttachmentFormat = stencilAttachmentFormat.Value;
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
        [NativeName("Type", "VkFormat*")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "pColorAttachmentFormats")]
        public Format* PColorAttachmentFormats;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "depthAttachmentFormat")]
        public Format DepthAttachmentFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "stencilAttachmentFormat")]
        public Format StencilAttachmentFormat;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderingAreaInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
