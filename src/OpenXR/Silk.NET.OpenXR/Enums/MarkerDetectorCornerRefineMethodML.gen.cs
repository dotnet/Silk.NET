// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerDetectorCornerRefineMethodML")]
    public enum MarkerDetectorCornerRefineMethodML : int
    {
        [Obsolete("Deprecated in favour of \"NoneML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_NONE_ML")]
        MarkerDetectorCornerRefineMethodNoneML = 0,
        [Obsolete("Deprecated in favour of \"SubpixML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_SUBPIX_ML")]
        MarkerDetectorCornerRefineMethodSubpixML = 1,
        [Obsolete("Deprecated in favour of \"ContourML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_CONTOUR_ML")]
        MarkerDetectorCornerRefineMethodContourML = 2,
        [Obsolete("Deprecated in favour of \"AprilTagML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_APRIL_TAG_ML")]
        MarkerDetectorCornerRefineMethodAprilTagML = 3,
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_NONE_ML")]
        NoneML = 0,
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_SUBPIX_ML")]
        SubpixML = 1,
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_CONTOUR_ML")]
        ContourML = 2,
        [NativeName("Name", "XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_APRIL_TAG_ML")]
        AprilTagML = 3,
    }
}
