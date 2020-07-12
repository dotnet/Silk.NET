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
    public unsafe struct CompositionLayerQuad
    {
        public CompositionLayerQuad
        (
            StructureType type = StructureType.TypeCompositionLayerQuad,
            void* next = default,
            CompositionLayerFlags layerFlags = default,
            Space space = default,
            EyeVisibility eyeVisibility = default,
            SwapchainSubImage subImage = default,
            Posef pose = default,
            Extent2Df size = default
        )
        {
           Type = type;
           Next = next;
           LayerFlags = layerFlags;
           Space = space;
           EyeVisibility = eyeVisibility;
           SubImage = subImage;
           Pose = pose;
           Size = size;
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
        public EyeVisibility EyeVisibility;
/// <summary></summary>
        public SwapchainSubImage SubImage;
/// <summary></summary>
        public Posef Pose;
/// <summary></summary>
        public Extent2Df Size;
    }
}
