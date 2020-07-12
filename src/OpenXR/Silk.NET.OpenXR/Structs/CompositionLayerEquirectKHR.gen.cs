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
    public unsafe struct CompositionLayerEquirectKHR
    {
        public CompositionLayerEquirectKHR
        (
            StructureType type = StructureType.TypeCompositionLayerEquirectKhr,
            void* next = default,
            CompositionLayerFlags layerFlags = default,
            Space space = default,
            EyeVisibility eyeVisibility = default,
            SwapchainSubImage subImage = default,
            Posef pose = default,
            float radius = default,
            Vector2f scale = default,
            Vector2f bias = default
        )
        {
           Type = type;
           Next = next;
           LayerFlags = layerFlags;
           Space = space;
           EyeVisibility = eyeVisibility;
           SubImage = subImage;
           Pose = pose;
           Radius = radius;
           Scale = scale;
           Bias = bias;
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
        public float Radius;
/// <summary></summary>
        public Vector2f Scale;
/// <summary></summary>
        public Vector2f Bias;
    }
}
