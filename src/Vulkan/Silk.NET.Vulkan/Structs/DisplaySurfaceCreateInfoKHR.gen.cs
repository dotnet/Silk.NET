// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct DisplaySurfaceCreateInfoKHR
    {
        public DisplaySurfaceCreateInfoKHR
        (
            StructureType sType = StructureType.DisplaySurfaceCreateInfoKhr,
            void* pNext = default,
            uint flags = default,
            DisplayModeKHR displayMode = default,
            uint planeIndex = default,
            uint planeStackIndex = default,
            SurfaceTransformFlagsKHR transform = default,
            float globalAlpha = default,
            DisplayPlaneAlphaFlagsKHR alphaMode = default,
            Extent2D imageExtent = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           DisplayMode = displayMode;
           PlaneIndex = planeIndex;
           PlaneStackIndex = planeStackIndex;
           Transform = transform;
           GlobalAlpha = globalAlpha;
           AlphaMode = alphaMode;
           ImageExtent = imageExtent;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public DisplayModeKHR DisplayMode;
/// <summary></summary>
        public uint PlaneIndex;
/// <summary></summary>
        public uint PlaneStackIndex;
/// <summary></summary>
        public SurfaceTransformFlagsKHR Transform;
/// <summary></summary>
        public float GlobalAlpha;
/// <summary></summary>
        public DisplayPlaneAlphaFlagsKHR AlphaMode;
/// <summary></summary>
        public Extent2D ImageExtent;
    }
}
