// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
