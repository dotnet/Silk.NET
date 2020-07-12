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

namespace Silk.NET.OpenXR
{
    public unsafe struct CompositionLayerProjection
    {
        public CompositionLayerProjection
        (
            StructureType type = StructureType.TypeCompositionLayerProjection,
            void* next = default,
            CompositionLayerFlags layerFlags = default,
            Space space = default,
            uint viewCount = default,
            CompositionLayerProjectionView* views = default
        )
        {
           Type = type;
           Next = next;
           LayerFlags = layerFlags;
           Space = space;
           ViewCount = viewCount;
           Views = views;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public CompositionLayerFlags LayerFlags;
/// <summary></summary>
        public Space Space;
/// <summary></summary>
        public uint ViewCount;
/// <summary></summary>
        public CompositionLayerProjectionView* Views;
    }
}
