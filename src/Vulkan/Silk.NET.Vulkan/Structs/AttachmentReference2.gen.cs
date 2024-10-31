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
    [NativeName("Name", "VkAttachmentReference2")]
    [NativeName("Aliases", "VkAttachmentReference2KHR")]
    public unsafe partial struct AttachmentReference2 : IChainStart
    {
        public AttachmentReference2
        (
            StructureType? sType = StructureType.AttachmentReference2,
            void* pNext = null,
            uint? attachment = null,
            ImageLayout? layout = null,
            ImageAspectFlags? aspectMask = null
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

            if (attachment is not null)
            {
                Attachment = attachment.Value;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (aspectMask is not null)
            {
                AspectMask = aspectMask.Value;
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
        [NativeName("Name", "attachment")]
        public uint Attachment;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "layout")]
        public ImageLayout Layout;
/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlags")]
        [NativeName("Type.Name", "VkImageAspectFlags")]
        [NativeName("Name", "aspectMask")]
        public ImageAspectFlags AspectMask;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AttachmentReference2;
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
        public static unsafe ref AttachmentReference2 Chain(
            out AttachmentReference2 capture)
        {
            capture = new AttachmentReference2(StructureType.AttachmentReference2);
            return ref capture;
        }
    }
}
