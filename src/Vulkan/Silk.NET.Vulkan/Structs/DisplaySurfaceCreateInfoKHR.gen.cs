// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplaySurfaceCreateInfoKHR")]
    public unsafe partial struct DisplaySurfaceCreateInfoKHR
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
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkDisplaySurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkDisplaySurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkDisplayModeKHR")]
        [NativeName("Type.Name", "VkDisplayModeKHR")]
        [NativeName("Name", "displayMode")]
        public DisplayModeKHR DisplayMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "planeIndex")]
        public uint PlaneIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "planeStackIndex")]
        public uint PlaneStackIndex;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Name", "transform")]
        public SurfaceTransformFlagsKHR Transform;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "globalAlpha")]
        public float GlobalAlpha;
/// <summary></summary>
        [NativeName("Type", "VkDisplayPlaneAlphaFlagBitsKHR")]
        [NativeName("Type.Name", "VkDisplayPlaneAlphaFlagBitsKHR")]
        [NativeName("Name", "alphaMode")]
        public DisplayPlaneAlphaFlagsKHR AlphaMode;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "imageExtent")]
        public Extent2D ImageExtent;
    }
}
