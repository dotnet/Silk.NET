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
    [NativeName("Name", "VkSubpassDescriptionDepthStencilResolveKHR")]
    [NativeName("AliasOf", "VkSubpassDescriptionDepthStencilResolve")]
    public unsafe partial struct SubpassDescriptionDepthStencilResolveKHR : IExtendsChain<SubpassDescription2>, IExtendsChain<SubpassDescription2KHR>
    {
        public SubpassDescriptionDepthStencilResolveKHR
        (
            StructureType? sType = StructureType.SubpassDescriptionDepthStencilResolve,
            void* pNext = null,
            ResolveModeFlags? depthResolveMode = null,
            ResolveModeFlags? stencilResolveMode = null,
            AttachmentReference2* pDepthStencilResolveAttachment = null
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

            if (depthResolveMode is not null)
            {
                DepthResolveMode = depthResolveMode.Value;
            }

            if (stencilResolveMode is not null)
            {
                StencilResolveMode = stencilResolveMode.Value;
            }

            if (pDepthStencilResolveAttachment is not null)
            {
                PDepthStencilResolveAttachment = pDepthStencilResolveAttachment;
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
        [NativeName("Type", "VkResolveModeFlagBits")]
        [NativeName("Type.Name", "VkResolveModeFlagBits")]
        [NativeName("Name", "depthResolveMode")]
        public ResolveModeFlags DepthResolveMode;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlagBits")]
        [NativeName("Type.Name", "VkResolveModeFlagBits")]
        [NativeName("Name", "stencilResolveMode")]
        public ResolveModeFlags StencilResolveMode;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentReference2*")]
        [NativeName("Type.Name", "VkAttachmentReference2")]
        [NativeName("Name", "pDepthStencilResolveAttachment")]
        public AttachmentReference2* PDepthStencilResolveAttachment;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SubpassDescriptionDepthStencilResolve;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
