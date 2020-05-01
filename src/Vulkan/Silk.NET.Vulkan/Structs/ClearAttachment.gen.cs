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
    public unsafe struct ClearAttachment
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
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        public uint ColorAttachment;
/// <summary></summary>
        public ClearValue ClearValue;
    }
}
