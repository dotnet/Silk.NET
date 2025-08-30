// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialAnchorConfidenceML")]
    public enum SpatialAnchorConfidenceML : int
    {
        [Obsolete("Deprecated in favour of \"LowML\"")]
        [NativeName("Name", "XR_SPATIAL_ANCHOR_CONFIDENCE_LOW_ML")]
        SpatialAnchorConfidenceLowML = 0,
        [Obsolete("Deprecated in favour of \"MediumML\"")]
        [NativeName("Name", "XR_SPATIAL_ANCHOR_CONFIDENCE_MEDIUM_ML")]
        SpatialAnchorConfidenceMediumML = 1,
        [Obsolete("Deprecated in favour of \"HighML\"")]
        [NativeName("Name", "XR_SPATIAL_ANCHOR_CONFIDENCE_HIGH_ML")]
        SpatialAnchorConfidenceHighML = 2,
        [NativeName("Name", "XR_SPATIAL_ANCHOR_CONFIDENCE_LOW_ML")]
        LowML = 0,
        [NativeName("Name", "XR_SPATIAL_ANCHOR_CONFIDENCE_MEDIUM_ML")]
        MediumML = 1,
        [NativeName("Name", "XR_SPATIAL_ANCHOR_CONFIDENCE_HIGH_ML")]
        HighML = 2,
    }
}
