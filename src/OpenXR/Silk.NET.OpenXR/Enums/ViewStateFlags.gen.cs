// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    public enum ViewStateFlags
    {
        ViewStateOrientationValidBit = 1,
        ViewStatePositionValidBit = 2,
        ViewStateOrientationTrackedBit = 4,
        ViewStatePositionTrackedBit = 8,
    }
}
