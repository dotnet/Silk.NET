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
        public uint Subpass;
/// <summary></summary>
        public uint InputAttachmentIndex;
/// <summary></summary>
        public ImageAspectFlags AspectMask;
    }
}
