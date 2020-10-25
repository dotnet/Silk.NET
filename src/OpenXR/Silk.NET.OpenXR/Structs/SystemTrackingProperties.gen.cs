// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSystemTrackingProperties")]
    public unsafe partial struct SystemTrackingProperties
    {
        public SystemTrackingProperties
        (
            uint? orientationTracking = null,
            uint? positionTracking = null
        ) : this()
        {
            if (orientationTracking is not null)
            {
                OrientationTracking = orientationTracking.Value;
            }

            if (positionTracking is not null)
            {
                PositionTracking = positionTracking.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "orientationTracking")]
        public uint OrientationTracking;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "positionTracking")]
        public uint PositionTracking;
    }
}
