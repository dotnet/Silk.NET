// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialMarkerArucoDictEXT")]
    public enum SpatialMarkerArucoDictEXT : int
    {
        [Obsolete("Deprecated in favour of \"Dict4X450Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_50_EXT")]
        SpatialMarkerArucoDict4X450Ext = 1,
        [Obsolete("Deprecated in favour of \"Dict4X4100Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_100_EXT")]
        SpatialMarkerArucoDict4X4100Ext = 2,
        [Obsolete("Deprecated in favour of \"Dict4X4250Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_250_EXT")]
        SpatialMarkerArucoDict4X4250Ext = 3,
        [Obsolete("Deprecated in favour of \"Dict4X41000Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_1000_EXT")]
        SpatialMarkerArucoDict4X41000Ext = 4,
        [Obsolete("Deprecated in favour of \"Dict5X550Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_50_EXT")]
        SpatialMarkerArucoDict5X550Ext = 5,
        [Obsolete("Deprecated in favour of \"Dict5X5100Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_100_EXT")]
        SpatialMarkerArucoDict5X5100Ext = 6,
        [Obsolete("Deprecated in favour of \"Dict5X5250Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_250_EXT")]
        SpatialMarkerArucoDict5X5250Ext = 7,
        [Obsolete("Deprecated in favour of \"Dict5X51000Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_1000_EXT")]
        SpatialMarkerArucoDict5X51000Ext = 8,
        [Obsolete("Deprecated in favour of \"Dict6X650Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_50_EXT")]
        SpatialMarkerArucoDict6X650Ext = 9,
        [Obsolete("Deprecated in favour of \"Dict6X6100Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_100_EXT")]
        SpatialMarkerArucoDict6X6100Ext = 10,
        [Obsolete("Deprecated in favour of \"Dict6X6250Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_250_EXT")]
        SpatialMarkerArucoDict6X6250Ext = 11,
        [Obsolete("Deprecated in favour of \"Dict6X61000Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_1000_EXT")]
        SpatialMarkerArucoDict6X61000Ext = 12,
        [Obsolete("Deprecated in favour of \"Dict7X750Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_50_EXT")]
        SpatialMarkerArucoDict7X750Ext = 13,
        [Obsolete("Deprecated in favour of \"Dict7X7100Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_100_EXT")]
        SpatialMarkerArucoDict7X7100Ext = 14,
        [Obsolete("Deprecated in favour of \"Dict7X7250Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_250_EXT")]
        SpatialMarkerArucoDict7X7250Ext = 15,
        [Obsolete("Deprecated in favour of \"Dict7X71000Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_1000_EXT")]
        SpatialMarkerArucoDict7X71000Ext = 16,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_50_EXT")]
        Dict4X450Ext = 1,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_100_EXT")]
        Dict4X4100Ext = 2,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_250_EXT")]
        Dict4X4250Ext = 3,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_4X4_1000_EXT")]
        Dict4X41000Ext = 4,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_50_EXT")]
        Dict5X550Ext = 5,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_100_EXT")]
        Dict5X5100Ext = 6,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_250_EXT")]
        Dict5X5250Ext = 7,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_5X5_1000_EXT")]
        Dict5X51000Ext = 8,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_50_EXT")]
        Dict6X650Ext = 9,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_100_EXT")]
        Dict6X6100Ext = 10,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_250_EXT")]
        Dict6X6250Ext = 11,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_6X6_1000_EXT")]
        Dict6X61000Ext = 12,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_50_EXT")]
        Dict7X750Ext = 13,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_100_EXT")]
        Dict7X7100Ext = 14,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_250_EXT")]
        Dict7X7250Ext = 15,
        [NativeName("Name", "XR_SPATIAL_MARKER_ARUCO_DICT_7X7_1000_EXT")]
        Dict7X71000Ext = 16,
    }
}
