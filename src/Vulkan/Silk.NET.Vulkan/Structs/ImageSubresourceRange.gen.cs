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
    public unsafe struct ImageSubresourceRange
    {
        public ImageSubresourceRange
        (
            ImageAspectFlags aspectMask = default,
            uint baseMipLevel = default,
            uint levelCount = default,
            uint baseArrayLayer = default,
            uint layerCount = default
        )
        {
           AspectMask = aspectMask;
           BaseMipLevel = baseMipLevel;
           LevelCount = levelCount;
           BaseArrayLayer = baseArrayLayer;
           LayerCount = layerCount;
        }

/// <summary></summary>
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        public uint BaseMipLevel;
/// <summary></summary>
        public uint LevelCount;
/// <summary></summary>
        public uint BaseArrayLayer;
/// <summary></summary>
        public uint LayerCount;
    }
}
