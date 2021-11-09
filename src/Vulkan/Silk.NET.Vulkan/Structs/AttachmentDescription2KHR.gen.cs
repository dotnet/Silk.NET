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
    [NativeName("Name", "VkAttachmentDescription2KHR")]
    [NativeName("AliasOf", "VkAttachmentDescription2")]
    public unsafe partial struct AttachmentDescription2KHR : IChainStart
    {
        public AttachmentDescription2KHR
        (
            StructureType? sType = StructureType.AttachmentDescription2,
            void* pNext = null,
            AttachmentDescriptionFlags? flags = null,
            Format? format = null,
            SampleCountFlags? samples = null,
            AttachmentLoadOp? loadOp = null,
            AttachmentStoreOp? storeOp = null,
            AttachmentLoadOp? stencilLoadOp = null,
            AttachmentStoreOp? stencilStoreOp = null,
            ImageLayout? initialLayout = null,
            ImageLayout? finalLayout = null
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (samples is not null)
            {
                Samples = samples.Value;
            }

            if (loadOp is not null)
            {
                LoadOp = loadOp.Value;
            }

            if (storeOp is not null)
            {
                StoreOp = storeOp.Value;
            }

            if (stencilLoadOp is not null)
            {
                StencilLoadOp = stencilLoadOp.Value;
            }

            if (stencilStoreOp is not null)
            {
                StencilStoreOp = stencilStoreOp.Value;
            }

            if (initialLayout is not null)
            {
                InitialLayout = initialLayout.Value;
            }

            if (finalLayout is not null)
            {
                FinalLayout = finalLayout.Value;
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
        [NativeName("Type", "VkAttachmentDescriptionFlags")]
        [NativeName("Type.Name", "VkAttachmentDescriptionFlags")]
        [NativeName("Name", "flags")]
        public AttachmentDescriptionFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "samples")]
        public SampleCountFlags Samples;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentLoadOp")]
        [NativeName("Type.Name", "VkAttachmentLoadOp")]
        [NativeName("Name", "loadOp")]
        public AttachmentLoadOp LoadOp;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentStoreOp")]
        [NativeName("Type.Name", "VkAttachmentStoreOp")]
        [NativeName("Name", "storeOp")]
        public AttachmentStoreOp StoreOp;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentLoadOp")]
        [NativeName("Type.Name", "VkAttachmentLoadOp")]
        [NativeName("Name", "stencilLoadOp")]
        public AttachmentLoadOp StencilLoadOp;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentStoreOp")]
        [NativeName("Type.Name", "VkAttachmentStoreOp")]
        [NativeName("Name", "stencilStoreOp")]
        public AttachmentStoreOp StencilStoreOp;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "initialLayout")]
        public ImageLayout InitialLayout;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "finalLayout")]
        public ImageLayout FinalLayout;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AttachmentDescription2;
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
        public static unsafe ref AttachmentDescription2KHR Chain(
            out AttachmentDescription2KHR capture)
        {
            capture = new AttachmentDescription2KHR(StructureType.AttachmentDescription2);
            return ref capture;
        }
    }
}
