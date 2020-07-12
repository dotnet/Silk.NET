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
    public unsafe struct CompositionLayerCubeKHR
    {
        public CompositionLayerCubeKHR
        (
            StructureType type = StructureType.TypeCompositionLayerCubeKhr,
            void* next = default,
            CompositionLayerFlags layerFlags = default,
            Space space = default,
            EyeVisibility eyeVisibility = default,
            Swapchain swapchain = default,
            uint imageArrayIndex = default,
            Quaternionf orientation = default
        )
        {
           Type = type;
           Next = next;
           LayerFlags = layerFlags;
           Space = space;
           EyeVisibility = eyeVisibility;
           Swapchain = swapchain;
           ImageArrayIndex = imageArrayIndex;
           Orientation = orientation;
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
        public Swapchain Swapchain;
/// <summary></summary>
        public uint ImageArrayIndex;
/// <summary></summary>
        public Quaternionf Orientation;
    }
}
