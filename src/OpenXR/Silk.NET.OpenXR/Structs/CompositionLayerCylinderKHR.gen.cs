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
    [NativeName("Name", "XrCompositionLayerCylinderKHR")]
    public unsafe partial struct CompositionLayerCylinderKHR
    {
        public CompositionLayerCylinderKHR
        (
            StructureType type = StructureType.TypeCompositionLayerCylinderKhr,
            void* next = default,
            CompositionLayerFlags layerFlags = default,
            Space space = default,
            EyeVisibility eyeVisibility = default,
            SwapchainSubImage subImage = default,
            Posef pose = default,
            float radius = default,
            float centralAngle = default,
            float aspectRatio = default
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
            CentralAngle = centralAngle;
            AspectRatio = aspectRatio;
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
        [NativeName("Type", "XrEyeVisibility")]
        [NativeName("Type.Name", "XrEyeVisibility")]
        [NativeName("Name", "eyeVisibility")]
        public EyeVisibility EyeVisibility;
/// <summary></summary>
        [NativeName("Type", "XrSwapchainSubImage")]
        [NativeName("Type.Name", "XrSwapchainSubImage")]
        [NativeName("Name", "subImage")]
        public SwapchainSubImage SubImage;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "radius")]
        public float Radius;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "centralAngle")]
        public float CentralAngle;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "aspectRatio")]
        public float AspectRatio;
    }
}
