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
    [NativeName("Name", "VkRenderPassCreateInfo2KHR")]
    [NativeName("AliasOf", "VkRenderPassCreateInfo2")]
    public unsafe partial struct RenderPassCreateInfo2KHR : IChainStart
    {
        public RenderPassCreateInfo2KHR
        (
            StructureType? sType = StructureType.RenderPassCreateInfo2,
            void* pNext = null,
            RenderPassCreateFlags? flags = null,
            uint? attachmentCount = null,
            AttachmentDescription2* pAttachments = null,
            uint? subpassCount = null,
            SubpassDescription2* pSubpasses = null,
            uint? dependencyCount = null,
            SubpassDependency2* pDependencies = null,
            uint? correlatedViewMaskCount = null,
            uint* pCorrelatedViewMasks = null
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

            if (attachmentCount is not null)
            {
                AttachmentCount = attachmentCount.Value;
            }

            if (pAttachments is not null)
            {
                PAttachments = pAttachments;
            }

            if (subpassCount is not null)
            {
                SubpassCount = subpassCount.Value;
            }

            if (pSubpasses is not null)
            {
                PSubpasses = pSubpasses;
            }

            if (dependencyCount is not null)
            {
                DependencyCount = dependencyCount.Value;
            }

            if (pDependencies is not null)
            {
                PDependencies = pDependencies;
            }

            if (correlatedViewMaskCount is not null)
            {
                CorrelatedViewMaskCount = correlatedViewMaskCount.Value;
            }

            if (pCorrelatedViewMasks is not null)
            {
                PCorrelatedViewMasks = pCorrelatedViewMasks;
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
        [NativeName("Type", "VkRenderPassCreateFlags")]
        [NativeName("Type.Name", "VkRenderPassCreateFlags")]
        [NativeName("Name", "flags")]
        public RenderPassCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentCount")]
        public uint AttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentDescription2*")]
        [NativeName("Type.Name", "VkAttachmentDescription2")]
        [NativeName("Name", "pAttachments")]
        public AttachmentDescription2* PAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpassCount")]
        public uint SubpassCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDescription2*")]
        [NativeName("Type.Name", "VkSubpassDescription2")]
        [NativeName("Name", "pSubpasses")]
        public SubpassDescription2* PSubpasses;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dependencyCount")]
        public uint DependencyCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDependency2*")]
        [NativeName("Type.Name", "VkSubpassDependency2")]
        [NativeName("Name", "pDependencies")]
        public SubpassDependency2* PDependencies;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "correlatedViewMaskCount")]
        public uint CorrelatedViewMaskCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pCorrelatedViewMasks")]
        public uint* PCorrelatedViewMasks;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassCreateInfo2;
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
        public static unsafe ref RenderPassCreateInfo2KHR Chain(
            out RenderPassCreateInfo2KHR capture)
        {
            capture = new RenderPassCreateInfo2KHR(StructureType.RenderPassCreateInfo2);
            return ref capture;
        }
    }
}
