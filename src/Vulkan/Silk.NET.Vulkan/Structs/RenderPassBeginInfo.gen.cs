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
    public unsafe struct RenderPassBeginInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public RenderPass RenderPass;
/// <summary></summary>
        public Framebuffer Framebuffer;
/// <summary></summary>
        public Rect2D RenderArea;
/// <summary></summary>
        public uint ClearValueCount;
/// <summary></summary>
        public ClearValue* PClearValues;
    }
}
