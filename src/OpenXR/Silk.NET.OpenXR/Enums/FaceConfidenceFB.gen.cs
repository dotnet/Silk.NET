// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceConfidenceFB")]
    public enum FaceConfidenceFB : int
    {
        [Obsolete("Deprecated in favour of \"LowerFaceFB\"")]
        [NativeName("Name", "XR_FACE_CONFIDENCE_LOWER_FACE_FB")]
        FaceConfidenceLowerFaceFB = 0,
        [Obsolete("Deprecated in favour of \"UpperFaceFB\"")]
        [NativeName("Name", "XR_FACE_CONFIDENCE_UPPER_FACE_FB")]
        FaceConfidenceUpperFaceFB = 1,
        [Obsolete("Deprecated in favour of \"CountFB\"")]
        [NativeName("Name", "XR_FACE_CONFIDENCE_COUNT_FB")]
        FaceConfidenceCountFB = 2,
        [NativeName("Name", "XR_FACE_CONFIDENCE_LOWER_FACE_FB")]
        LowerFaceFB = 0,
        [NativeName("Name", "XR_FACE_CONFIDENCE_UPPER_FACE_FB")]
        UpperFaceFB = 1,
        [NativeName("Name", "XR_FACE_CONFIDENCE_COUNT_FB")]
        CountFB = 2,
    }
}
