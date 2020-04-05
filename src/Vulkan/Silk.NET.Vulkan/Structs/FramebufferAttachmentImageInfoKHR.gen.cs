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
    public unsafe struct FramebufferAttachmentImageInfoKHR
    {
        public FramebufferAttachmentImageInfoKHR
        (
            StructureType sType = StructureType.FramebufferAttachmentImageInfo,
            void* pNext = default,
            ImageCreateFlags flags = default,
            ImageUsageFlags usage = default,
            uint width = default,
            uint height = default,
            uint layerCount = default,
            uint viewFormatCount = default,
            Format* pViewFormats = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Usage = usage;
           Width = width;
           Height = height;
           LayerCount = layerCount;
           ViewFormatCount = viewFormatCount;
           PViewFormats = pViewFormats;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ImageCreateFlags Flags;
/// <summary></summary>
        public ImageUsageFlags Usage;
/// <summary></summary>
        public uint Width;
/// <summary></summary>
        public uint Height;
/// <summary></summary>
        public uint LayerCount;
/// <summary></summary>
        public uint ViewFormatCount;
/// <summary></summary>
        public Format* PViewFormats;
    }
}
