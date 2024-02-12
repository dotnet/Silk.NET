// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerAprilTagDictML")]
    public enum MarkerAprilTagDictML : int
    {
        [Obsolete("Deprecated in favour of \"Dict16H5ML\"")]
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_16H5_ML")]
        MarkerAprilTagDict16H5ML = 0,
        [Obsolete("Deprecated in favour of \"Dict25H9ML\"")]
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_25H9_ML")]
        MarkerAprilTagDict25H9ML = 1,
        [Obsolete("Deprecated in favour of \"Dict36H10ML\"")]
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_36H10_ML")]
        MarkerAprilTagDict36H10ML = 2,
        [Obsolete("Deprecated in favour of \"Dict36H11ML\"")]
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_36H11_ML")]
        MarkerAprilTagDict36H11ML = 3,
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_16H5_ML")]
        Dict16H5ML = 0,
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_25H9_ML")]
        Dict25H9ML = 1,
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_36H10_ML")]
        Dict36H10ML = 2,
        [NativeName("Name", "XR_MARKER_APRIL_TAG_DICT_36H11_ML")]
        Dict36H11ML = 3,
    }
}
