// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPlaneDetectorSemanticTypeEXT")]
    public enum PlaneDetectorSemanticTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"UndefinedExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_UNDEFINED_EXT")]
        PlaneDetectorSemanticTypeUndefinedExt = 0,
        [Obsolete("Deprecated in favour of \"CeilingExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_CEILING_EXT")]
        PlaneDetectorSemanticTypeCeilingExt = 1,
        [Obsolete("Deprecated in favour of \"FloorExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_FLOOR_EXT")]
        PlaneDetectorSemanticTypeFloorExt = 2,
        [Obsolete("Deprecated in favour of \"WallExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_WALL_EXT")]
        PlaneDetectorSemanticTypeWallExt = 3,
        [Obsolete("Deprecated in favour of \"PlatformExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_PLATFORM_EXT")]
        PlaneDetectorSemanticTypePlatformExt = 4,
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_UNDEFINED_EXT")]
        UndefinedExt = 0,
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_CEILING_EXT")]
        CeilingExt = 1,
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_FLOOR_EXT")]
        FloorExt = 2,
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_WALL_EXT")]
        WallExt = 3,
        [NativeName("Name", "XR_PLANE_DETECTOR_SEMANTIC_TYPE_PLATFORM_EXT")]
        PlatformExt = 4,
    }
}
