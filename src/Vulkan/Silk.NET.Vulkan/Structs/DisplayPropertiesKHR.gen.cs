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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplayPropertiesKHR")]
    public unsafe partial struct DisplayPropertiesKHR
    {
        public DisplayPropertiesKHR
        (
            DisplayKHR display = default,
            byte* displayName = default,
            Extent2D physicalDimensions = default,
            Extent2D physicalResolution = default,
            SurfaceTransformFlagsKHR supportedTransforms = default,
            Bool32 planeReorderPossible = default,
            Bool32 persistentContent = default
        )
        {
            Display = display;
            DisplayName = displayName;
            PhysicalDimensions = physicalDimensions;
            PhysicalResolution = physicalResolution;
            SupportedTransforms = supportedTransforms;
            PlaneReorderPossible = planeReorderPossible;
            PersistentContent = persistentContent;
        }

/// <summary></summary>
        [NativeName("Type", "VkDisplayKHR")]
        [NativeName("Type.Name", "VkDisplayKHR")]
        [NativeName("Name", "display")]
        public DisplayKHR Display;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "displayName")]
        public byte* DisplayName;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "physicalDimensions")]
        public Extent2D PhysicalDimensions;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "physicalResolution")]
        public Extent2D PhysicalResolution;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceTransformFlagsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagsKHR")]
        [NativeName("Name", "supportedTransforms")]
        public SurfaceTransformFlagsKHR SupportedTransforms;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "planeReorderPossible")]
        public Bool32 PlaneReorderPossible;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "persistentContent")]
        public Bool32 PersistentContent;
    }
}
