// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialMarkerAprilTagDictEXT")]
    public enum SpatialMarkerAprilTagDictEXT : int
    {
        [Obsolete("Deprecated in favour of \"Dict16H5Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_16H5_EXT")]
        SpatialMarkerAprilTagDict16H5Ext = 1,
        [Obsolete("Deprecated in favour of \"Dict25H9Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_25H9_EXT")]
        SpatialMarkerAprilTagDict25H9Ext = 2,
        [Obsolete("Deprecated in favour of \"Dict36H10Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_36H10_EXT")]
        SpatialMarkerAprilTagDict36H10Ext = 3,
        [Obsolete("Deprecated in favour of \"Dict36H11Ext\"")]
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_36H11_EXT")]
        SpatialMarkerAprilTagDict36H11Ext = 4,
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_16H5_EXT")]
        Dict16H5Ext = 1,
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_25H9_EXT")]
        Dict25H9Ext = 2,
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_36H10_EXT")]
        Dict36H10Ext = 3,
        [NativeName("Name", "XR_SPATIAL_MARKER_APRIL_TAG_DICT_36H11_EXT")]
        Dict36H11Ext = 4,
    }
}
