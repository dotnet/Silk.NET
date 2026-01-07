// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceConfidenceRegionsANDROID")]
    public enum FaceConfidenceRegionsANDROID : int
    {
        [Obsolete("Deprecated in favour of \"LowerAndroid\"")]
        [NativeName("Name", "XR_FACE_CONFIDENCE_REGIONS_LOWER_ANDROID")]
        FaceConfidenceRegionsLowerAndroid = 0,
        [Obsolete("Deprecated in favour of \"LeftUpperAndroid\"")]
        [NativeName("Name", "XR_FACE_CONFIDENCE_REGIONS_LEFT_UPPER_ANDROID")]
        FaceConfidenceRegionsLeftUpperAndroid = 1,
        [Obsolete("Deprecated in favour of \"RightUpperAndroid\"")]
        [NativeName("Name", "XR_FACE_CONFIDENCE_REGIONS_RIGHT_UPPER_ANDROID")]
        FaceConfidenceRegionsRightUpperAndroid = 2,
        [NativeName("Name", "XR_FACE_CONFIDENCE_REGIONS_LOWER_ANDROID")]
        LowerAndroid = 0,
        [NativeName("Name", "XR_FACE_CONFIDENCE_REGIONS_LEFT_UPPER_ANDROID")]
        LeftUpperAndroid = 1,
        [NativeName("Name", "XR_FACE_CONFIDENCE_REGIONS_RIGHT_UPPER_ANDROID")]
        RightUpperAndroid = 2,
    }
}
