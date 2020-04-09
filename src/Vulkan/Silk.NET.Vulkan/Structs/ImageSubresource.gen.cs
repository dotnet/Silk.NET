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
    public unsafe struct ImageSubresource
    {
        public ImageSubresource
        (
            ImageAspectFlags aspectMask = default,
            uint mipLevel = default,
            uint arrayLayer = default
        )
        {
           AspectMask = aspectMask;
           MipLevel = mipLevel;
           ArrayLayer = arrayLayer;
        }

/// <summary></summary>
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        public uint MipLevel;
/// <summary></summary>
        public uint ArrayLayer;
    }
}
