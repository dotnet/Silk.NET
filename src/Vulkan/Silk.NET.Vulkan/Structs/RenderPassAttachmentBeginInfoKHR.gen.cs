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
    [NativeName("Name", "VkRenderPassAttachmentBeginInfoKHR")]
    [NativeName("AliasOf", "VkRenderPassAttachmentBeginInfo")]
    public unsafe partial struct RenderPassAttachmentBeginInfoKHR : IExtendsChain<RenderPassBeginInfo>
    {
        public RenderPassAttachmentBeginInfoKHR
        (
            StructureType? sType = StructureType.RenderPassAttachmentBeginInfo,
            void* pNext = null,
            uint? attachmentCount = null,
            ImageView* pAttachments = null
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

            if (attachmentCount is not null)
            {
                AttachmentCount = attachmentCount.Value;
            }

            if (pAttachments is not null)
            {
                PAttachments = pAttachments;
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
        [NativeName("Name", "attachmentCount")]
        public uint AttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkImageView*")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "pAttachments")]
        public ImageView* PAttachments;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassAttachmentBeginInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
