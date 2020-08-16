// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplayPresentInfoKHR")]
    public unsafe partial struct DisplayPresentInfoKHR
    {
        public DisplayPresentInfoKHR
        (
            StructureType sType = StructureType.DisplayPresentInfoKhr,
            void* pNext = default,
            Rect2D srcRect = default,
            Rect2D dstRect = default,
            Bool32 persistent = default
        )
        {
            SType = sType;
            PNext = pNext;
            SrcRect = srcRect;
            DstRect = dstRect;
            Persistent = persistent;
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
        [NativeName("Type", "VkRect2D")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "srcRect")]
        public Rect2D SrcRect;
/// <summary></summary>
        [NativeName("Type", "VkRect2D")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "dstRect")]
        public Rect2D DstRect;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "persistent")]
        public Bool32 Persistent;
    }
}
