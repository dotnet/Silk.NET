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
    [NativeName("Name", "VkImageBlit")]
    public unsafe partial struct ImageBlit
    {
        public ImageBlit
        (
            ImageSubresourceLayers srcSubresource = default,
            ImageSubresourceLayers dstSubresource = default
        )
        {
            SrcSubresource = srcSubresource;
           SrcOffsets_0 = default;
           SrcOffsets_1 = default;
            DstSubresource = dstSubresource;
           DstOffsets_0 = default;
           DstOffsets_1 = default;
        }

/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "srcSubresource")]
        public ImageSubresourceLayers SrcSubresource;
        /// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "srcOffsets")]
        public Offset3D SrcOffsets_0;
        /// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "srcOffsets")]
        public Offset3D SrcOffsets_1;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "dstSubresource")]
        public ImageSubresourceLayers DstSubresource;
        /// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "dstOffsets")]
        public Offset3D DstOffsets_0;
        /// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "dstOffsets")]
        public Offset3D DstOffsets_1;
    }
}
