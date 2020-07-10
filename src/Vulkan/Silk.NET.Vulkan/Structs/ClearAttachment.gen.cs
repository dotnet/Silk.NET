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
    [NativeName("Name", "VkClearAttachment")]
    public unsafe partial struct ClearAttachment
    {
        public ClearAttachment
        (
            ImageAspectFlags aspectMask = default,
            uint colorAttachment = default,
            ClearValue clearValue = default
        )
        {
            AspectMask = aspectMask;
            ColorAttachment = colorAttachment;
            ClearValue = clearValue;
        }

/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlags")]
        [NativeName("Type.Name", "VkImageAspectFlags")]
        [NativeName("Name", "aspectMask")]
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachment")]
        public uint ColorAttachment;
/// <summary></summary>
        [NativeName("Type", "VkClearValue")]
        [NativeName("Type.Name", "VkClearValue")]
        [NativeName("Name", "clearValue")]
        public ClearValue ClearValue;
    }
}
