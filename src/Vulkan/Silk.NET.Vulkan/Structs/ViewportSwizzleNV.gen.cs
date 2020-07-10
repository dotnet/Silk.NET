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
    [NativeName("Name", "VkViewportSwizzleNV")]
    public unsafe partial struct ViewportSwizzleNV
    {
        public ViewportSwizzleNV
        (
            ViewportCoordinateSwizzleNV x = default,
            ViewportCoordinateSwizzleNV y = default,
            ViewportCoordinateSwizzleNV z = default,
            ViewportCoordinateSwizzleNV w = default
        )
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

/// <summary></summary>
        [NativeName("Type", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Type.Name", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Name", "x")]
        public ViewportCoordinateSwizzleNV X;
/// <summary></summary>
        [NativeName("Type", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Type.Name", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Name", "y")]
        public ViewportCoordinateSwizzleNV Y;
/// <summary></summary>
        [NativeName("Type", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Type.Name", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Name", "z")]
        public ViewportCoordinateSwizzleNV Z;
/// <summary></summary>
        [NativeName("Type", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Type.Name", "VkViewportCoordinateSwizzleNV")]
        [NativeName("Name", "w")]
        public ViewportCoordinateSwizzleNV W;
    }
}
