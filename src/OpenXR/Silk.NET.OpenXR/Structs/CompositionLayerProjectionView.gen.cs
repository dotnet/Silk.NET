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
    public unsafe struct CompositionLayerProjectionView
    {
        public CompositionLayerProjectionView
        (
            StructureType type = StructureType.TypeCompositionLayerProjectionView,
            void* next = default,
            Posef pose = default,
            Fovf fov = default,
            SwapchainSubImage subImage = default
        )
        {
           Type = type;
           Next = next;
           Pose = pose;
           Fov = fov;
           SubImage = subImage;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public Posef Pose;
/// <summary></summary>
        public Fovf Fov;
/// <summary></summary>
        public SwapchainSubImage SubImage;
    }
}
