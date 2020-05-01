// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct InputAttachmentAspectReference
    {
        public InputAttachmentAspectReference
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
