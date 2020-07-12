// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct SystemTrackingProperties
    {
        public SystemTrackingProperties
        (
            uint orientationTracking = default,
            uint positionTracking = default
        )
        {
           OrientationTracking = orientationTracking;
           PositionTracking = positionTracking;
        }

/// <summary></summary>
        public uint OrientationTracking;
/// <summary></summary>
        public uint PositionTracking;
    }
}
