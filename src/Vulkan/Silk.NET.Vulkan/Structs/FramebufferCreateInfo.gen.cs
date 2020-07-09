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
    [NativeName("Name", "VkFramebufferCreateInfo")]
    public unsafe struct FramebufferCreateInfo
    {
        public FramebufferCreateInfo
        (
            StructureType sType = StructureType.FramebufferCreateInfo,
            void* pNext = default,
            FramebufferCreateFlags flags = default,
            RenderPass renderPass = default,
            uint attachmentCount = default,
            ImageView* pAttachments = default,
            uint width = default,
            uint height = default,
            uint layers = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           RenderPass = renderPass;
           AttachmentCount = attachmentCount;
           PAttachments = pAttachments;
           Width = width;
           Height = height;
           Layers = layers;
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
        [NativeName("Type", "VkFramebufferCreateFlags")]
        [NativeName("Type.Name", "VkFramebufferCreateFlags")]
        [NativeName("Name", "flags")]
        public FramebufferCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkRenderPass")]
        [NativeName("Type.Name", "VkRenderPass")]
        [NativeName("Name", "renderPass")]
        public RenderPass RenderPass;
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
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "width")]
        public uint Width;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "height")]
        public uint Height;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layers")]
        public uint Layers;
    }
}
