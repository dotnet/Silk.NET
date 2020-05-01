// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum SurfaceTransformFlagsKHR
    {
        SurfaceTransformIdentityBitKhr = 1,
        SurfaceTransformRotate90BitKhr = 2,
        SurfaceTransformRotate180BitKhr = 4,
        SurfaceTransformRotate270BitKhr = 8,
        SurfaceTransformHorizontalMirrorBitKhr = 16,
        SurfaceTransformHorizontalMirrorRotate90BitKhr = 32,
        SurfaceTransformHorizontalMirrorRotate180BitKhr = 64,
        SurfaceTransformHorizontalMirrorRotate270BitKhr = 128,
        SurfaceTransformInheritBitKhr = 256,
    }
}
