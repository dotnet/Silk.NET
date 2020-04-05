// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public FramebufferCreateFlags Flags;
/// <summary></summary>
        public RenderPass RenderPass;
/// <summary></summary>
        public uint AttachmentCount;
/// <summary></summary>
        public ImageView* PAttachments;
/// <summary></summary>
        public uint Width;
/// <summary></summary>
        public uint Height;
/// <summary></summary>
        public uint Layers;
    }
}
