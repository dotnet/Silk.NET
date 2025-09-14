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
    [NativeName("Name", "VkRenderingInputAttachmentIndexInfoKHR")]
    [NativeName("AliasOf", "VkRenderingInputAttachmentIndexInfo")]
    public unsafe partial struct RenderingInputAttachmentIndexInfoKHR : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<CommandBufferInheritanceInfo>
    {
        public RenderingInputAttachmentIndexInfoKHR
        (
            StructureType? sType = StructureType.RenderingInputAttachmentIndexInfo,
            void* pNext = null,
            uint? colorAttachmentCount = null,
            uint* pColorAttachmentInputIndices = null,
            uint* pDepthInputAttachmentIndex = null,
            uint* pStencilInputAttachmentIndex = null
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

            if (pColorAttachmentInputIndices is not null)
            {
                PColorAttachmentInputIndices = pColorAttachmentInputIndices;
            }

            if (pDepthInputAttachmentIndex is not null)
            {
                PDepthInputAttachmentIndex = pDepthInputAttachmentIndex;
            }

            if (pStencilInputAttachmentIndex is not null)
            {
                PStencilInputAttachmentIndex = pStencilInputAttachmentIndex;
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
        [NativeName("Name", "pColorAttachmentInputIndices")]
        public uint* PColorAttachmentInputIndices;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDepthInputAttachmentIndex")]
        public uint* PDepthInputAttachmentIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pStencilInputAttachmentIndex")]
        public uint* PStencilInputAttachmentIndex;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderingInputAttachmentIndexInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
