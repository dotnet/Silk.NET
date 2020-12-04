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
    [NativeName("Name", "VkRectLayerKHR")]
    public unsafe partial struct RectLayerKHR
    {
        public RectLayerKHR
        (
            Offset2D? offset = null,
            Extent2D? extent = null,
            uint? layer = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (extent is not null)
            {
                Extent = extent.Value;
            }

            if (layer is not null)
            {
                Layer = layer.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "offset")]
        public Offset2D Offset;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "extent")]
        public Extent2D Extent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layer")]
        public uint Layer;
    }
}
