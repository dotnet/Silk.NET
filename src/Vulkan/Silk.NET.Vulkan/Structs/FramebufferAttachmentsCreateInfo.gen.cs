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
    [NativeName("Name", "VkFramebufferAttachmentsCreateInfo")]
    [NativeName("Aliases", "VkFramebufferAttachmentsCreateInfoKHR")]
    public unsafe partial struct FramebufferAttachmentsCreateInfo : IExtendsChain<FramebufferCreateInfo>
    {
        public FramebufferAttachmentsCreateInfo
        (
            StructureType? sType = StructureType.FramebufferAttachmentsCreateInfo,
            void* pNext = null,
            uint? attachmentImageInfoCount = null,
            FramebufferAttachmentImageInfo* pAttachmentImageInfos = null
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

            if (attachmentImageInfoCount is not null)
            {
                AttachmentImageInfoCount = attachmentImageInfoCount.Value;
            }

            if (pAttachmentImageInfos is not null)
            {
                PAttachmentImageInfos = pAttachmentImageInfos;
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
        [NativeName("Name", "attachmentImageInfoCount")]
        public uint AttachmentImageInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkFramebufferAttachmentImageInfo*")]
        [NativeName("Type.Name", "VkFramebufferAttachmentImageInfo")]
        [NativeName("Name", "pAttachmentImageInfos")]
        public FramebufferAttachmentImageInfo* PAttachmentImageInfos;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FramebufferAttachmentsCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
