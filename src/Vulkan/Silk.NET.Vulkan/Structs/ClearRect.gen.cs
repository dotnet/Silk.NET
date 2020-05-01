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
    public unsafe struct ClearRect
    {
        public ClearRect
        (
            Rect2D rect = default,
            uint baseArrayLayer = default,
            uint layerCount = default
        )
        {
           Rect = rect;
           BaseArrayLayer = baseArrayLayer;
           LayerCount = layerCount;
        }

/// <summary></summary>
        public Rect2D Rect;
/// <summary></summary>
        public uint BaseArrayLayer;
/// <summary></summary>
        public uint LayerCount;
    }
}
