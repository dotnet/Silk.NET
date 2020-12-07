// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    public unsafe partial struct AttachmentReference2
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
    }
}
