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
    [NativeName("Name", "VkRenderingAttachmentLocationInfoKHR")]
    public unsafe partial struct RenderingAttachmentLocationInfoKHR : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<CommandBufferInheritanceInfo>
    {
        public RenderingAttachmentLocationInfoKHR
        (
            StructureType? sType = StructureType.RenderingAttachmentLocationInfoKhr,
            void* pNext = null,
            uint? colorAttachmentCount = null,
            uint* pColorAttachmentLocations = null
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

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (pColorAttachmentLocations is not null)
            {
                PColorAttachmentLocations = pColorAttachmentLocations;
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
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pColorAttachmentLocations")]
        public uint* PColorAttachmentLocations;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderingAttachmentLocationInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
