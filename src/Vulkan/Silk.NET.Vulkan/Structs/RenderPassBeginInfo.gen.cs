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
    [NativeName("Name", "VkRenderPassBeginInfo")]
    public unsafe partial struct RenderPassBeginInfo
    {
        public RenderPassBeginInfo
        (
            StructureType sType = StructureType.RenderPassBeginInfo,
            void* pNext = default,
            RenderPass renderPass = default,
            Framebuffer framebuffer = default,
            Rect2D renderArea = default,
            uint clearValueCount = default,
            ClearValue* pClearValues = default
        )
        {
            SType = sType;
            PNext = pNext;
            RenderPass = renderPass;
            Framebuffer = framebuffer;
            RenderArea = renderArea;
            ClearValueCount = clearValueCount;
            PClearValues = pClearValues;
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
        [NativeName("Type", "VkRenderPass")]
        [NativeName("Type.Name", "VkRenderPass")]
        [NativeName("Name", "renderPass")]
        public RenderPass RenderPass;
/// <summary></summary>
        [NativeName("Type", "VkFramebuffer")]
        [NativeName("Type.Name", "VkFramebuffer")]
        [NativeName("Name", "framebuffer")]
        public Framebuffer Framebuffer;
/// <summary></summary>
        [NativeName("Type", "VkRect2D")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "renderArea")]
        public Rect2D RenderArea;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clearValueCount")]
        public uint ClearValueCount;
/// <summary></summary>
        [NativeName("Type", "VkClearValue*")]
        [NativeName("Type.Name", "VkClearValue")]
        [NativeName("Name", "pClearValues")]
        public ClearValue* PClearValues;
    }
}
