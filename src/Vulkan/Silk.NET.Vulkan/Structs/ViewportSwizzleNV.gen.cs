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
    public unsafe struct ViewportSwizzleNV
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
        public ViewportCoordinateSwizzleNV X;
/// <summary></summary>
        public ViewportCoordinateSwizzleNV Y;
/// <summary></summary>
        public ViewportCoordinateSwizzleNV Z;
/// <summary></summary>
        public ViewportCoordinateSwizzleNV W;
    }
}
