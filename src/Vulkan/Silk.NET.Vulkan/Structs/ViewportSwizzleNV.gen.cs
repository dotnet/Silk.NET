// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkViewportSwizzleNV")]
    public unsafe partial struct ViewportSwizzleNV
    {
        public ViewportSwizzleNV
        (
            ViewportCoordinateSwizzleNV? x = null,
            ViewportCoordinateSwizzleNV? y = null,
            ViewportCoordinateSwizzleNV? z = null,
            ViewportCoordinateSwizzleNV? w = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (z is not null)
            {
                Z = z.Value;
            }

            if (w is not null)
            {
                W = w.Value;
            }
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
