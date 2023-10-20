// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPlaneDetectionCapabilityFlagsEXT")]
    public enum PlaneDetectionCapabilityFlagsEXT : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PlaneDetectionBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_PLANE_DETECTION_BIT_EXT")]
        PlaneDetectionCapabilityPlaneDetectionBitExt = 1,
        [Obsolete("Deprecated in favour of \"PlaneHolesBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_PLANE_HOLES_BIT_EXT")]
        PlaneDetectionCapabilityPlaneHolesBitExt = 2,
        [Obsolete("Deprecated in favour of \"SemanticCeilingBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_CEILING_BIT_EXT")]
        PlaneDetectionCapabilitySemanticCeilingBitExt = 4,
        [Obsolete("Deprecated in favour of \"SemanticFloorBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_FLOOR_BIT_EXT")]
        PlaneDetectionCapabilitySemanticFloorBitExt = 8,
        [Obsolete("Deprecated in favour of \"SemanticWallBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_WALL_BIT_EXT")]
        PlaneDetectionCapabilitySemanticWallBitExt = 16,
        [Obsolete("Deprecated in favour of \"SemanticPlatformBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_PLATFORM_BIT_EXT")]
        PlaneDetectionCapabilitySemanticPlatformBitExt = 32,
        [Obsolete("Deprecated in favour of \"OrientationBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_ORIENTATION_BIT_EXT")]
        PlaneDetectionCapabilityOrientationBitExt = 64,
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_PLANE_DETECTION_BIT_EXT")]
        PlaneDetectionBitExt = 1,
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_PLANE_HOLES_BIT_EXT")]
        PlaneHolesBitExt = 2,
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_CEILING_BIT_EXT")]
        SemanticCeilingBitExt = 4,
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_FLOOR_BIT_EXT")]
        SemanticFloorBitExt = 8,
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_WALL_BIT_EXT")]
        SemanticWallBitExt = 16,
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_PLATFORM_BIT_EXT")]
        SemanticPlatformBitExt = 32,
        [NativeName("Name", "XR_PLANE_DETECTION_CAPABILITY_ORIENTATION_BIT_EXT")]
        OrientationBitExt = 64,
    }
}
