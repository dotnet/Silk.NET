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
    [NativeName("Name", "VkInputAttachmentAspectReferenceKHR")]
    public unsafe struct InputAttachmentAspectReferenceKHR
    {
        public InputAttachmentAspectReferenceKHR
        (
            uint subpass = default,
            uint inputAttachmentIndex = default,
            ImageAspectFlags aspectMask = default
        )
        {
           Subpass = subpass;
           InputAttachmentIndex = inputAttachmentIndex;
           AspectMask = aspectMask;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpass")]
        public uint Subpass;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "inputAttachmentIndex")]
        public uint InputAttachmentIndex;
/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlags")]
        [NativeName("Type.Name", "VkImageAspectFlags")]
        [NativeName("Name", "aspectMask")]
        public ImageAspectFlags AspectMask;
    }
}
