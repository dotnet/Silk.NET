// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFramebufferAttachmentsCreateInfoKHR")]
    public unsafe partial struct FramebufferAttachmentsCreateInfoKHR
    {
        public FramebufferAttachmentsCreateInfoKHR
        (
            StructureType sType = StructureType.FramebufferAttachmentsCreateInfo,
            void* pNext = default,
            uint attachmentImageInfoCount = default,
            FramebufferAttachmentImageInfo* pAttachmentImageInfos = default
        )
        {
            SType = sType;
            PNext = pNext;
            AttachmentImageInfoCount = attachmentImageInfoCount;
            PAttachmentImageInfos = pAttachmentImageInfos;
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
    }
}
