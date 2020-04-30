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
    public unsafe struct DisplayPropertiesKHR
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
        public DisplayKHR Display;
/// <summary></summary>
        public byte* DisplayName;
/// <summary></summary>
        public Extent2D PhysicalDimensions;
/// <summary></summary>
        public Extent2D PhysicalResolution;
/// <summary></summary>
        public SurfaceTransformFlagsKHR SupportedTransforms;
/// <summary></summary>
        public Bool32 PlaneReorderPossible;
/// <summary></summary>
        public Bool32 PersistentContent;
    }
}
