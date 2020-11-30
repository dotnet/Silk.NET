// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkInputAttachmentAspectReference")]
    public unsafe partial struct InputAttachmentAspectReference
    {
        public InputAttachmentAspectReference
        (
            uint? subpass = null,
            uint? inputAttachmentIndex = null,
            ImageAspectFlags? aspectMask = null
        ) : this()
        {
            if (subpass is not null)
            {
                Subpass = subpass.Value;
            }

            if (inputAttachmentIndex is not null)
            {
                InputAttachmentIndex = inputAttachmentIndex.Value;
            }

            if (aspectMask is not null)
            {
                AspectMask = aspectMask.Value;
            }
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
