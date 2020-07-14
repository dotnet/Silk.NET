// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrCompositionLayerProjection")]
    public unsafe partial struct CompositionLayerProjection
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
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrCompositionLayerFlags")]
        [NativeName("Type.Name", "XrCompositionLayerFlags")]
        [NativeName("Name", "layerFlags")]
        public CompositionLayerFlags LayerFlags;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewCount")]
        public uint ViewCount;
/// <summary></summary>
        [NativeName("Type", "XrCompositionLayerProjectionView*")]
        [NativeName("Type.Name", "XrCompositionLayerProjectionView")]
        [NativeName("Name", "views")]
        public CompositionLayerProjectionView* Views;
    }
}
