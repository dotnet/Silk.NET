// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum GeometryInstanceFlagsKHR
    {
        GeometryInstanceTriangleFacingCullDisableBitKhr = 1,
        GeometryInstanceTriangleFrontCounterclockwiseBitKhr = 2,
        GeometryInstanceForceOpaqueBitKhr = 4,
        GeometryInstanceForceNoOpaqueBitKhr = 8,
    }
}
