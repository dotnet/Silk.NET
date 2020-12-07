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
    [NativeName("Name", "VkClearRect")]
    public unsafe partial struct ClearRect
    {
        public ClearRect
        (
            Rect2D? rect = null,
            uint? baseArrayLayer = null,
            uint? layerCount = null
        ) : this()
        {
            if (rect is not null)
            {
                Rect = rect.Value;
            }

            if (baseArrayLayer is not null)
            {
                BaseArrayLayer = baseArrayLayer.Value;
            }

            if (layerCount is not null)
            {
                LayerCount = layerCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkRect2D")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "rect")]
        public Rect2D Rect;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "baseArrayLayer")]
        public uint BaseArrayLayer;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layerCount")]
        public uint LayerCount;
    }
}
