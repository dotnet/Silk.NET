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
    [NativeName("Name", "VkRenderPassInputAttachmentAspectCreateInfo")]
    [NativeName("Aliases", "VkRenderPassInputAttachmentAspectCreateInfoKHR")]
    public unsafe partial struct RenderPassInputAttachmentAspectCreateInfo : IExtendsChain<RenderPassCreateInfo>
    {
        public RenderPassInputAttachmentAspectCreateInfo
        (
            StructureType? sType = StructureType.RenderPassInputAttachmentAspectCreateInfo,
            void* pNext = null,
            uint? aspectReferenceCount = null,
            InputAttachmentAspectReference* pAspectReferences = null
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

            if (aspectReferenceCount is not null)
            {
                AspectReferenceCount = aspectReferenceCount.Value;
            }

            if (pAspectReferences is not null)
            {
                PAspectReferences = pAspectReferences;
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
        [NativeName("Name", "aspectReferenceCount")]
        public uint AspectReferenceCount;
/// <summary></summary>
        [NativeName("Type", "VkInputAttachmentAspectReference*")]
        [NativeName("Type.Name", "VkInputAttachmentAspectReference")]
        [NativeName("Name", "pAspectReferences")]
        public InputAttachmentAspectReference* PAspectReferences;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassInputAttachmentAspectCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
