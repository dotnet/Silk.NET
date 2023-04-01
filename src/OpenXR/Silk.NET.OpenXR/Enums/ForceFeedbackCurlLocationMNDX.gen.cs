// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrForceFeedbackCurlLocationMNDX")]
    public enum ForceFeedbackCurlLocationMNDX : int
    {
        [Obsolete("Deprecated in favour of \"ThumbCurlMndx\"")]
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_THUMB_CURL_MNDX")]
        ForceFeedbackCurlLocationThumbCurlMndx = 0,
        [Obsolete("Deprecated in favour of \"IndexCurlMndx\"")]
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_INDEX_CURL_MNDX")]
        ForceFeedbackCurlLocationIndexCurlMndx = 1,
        [Obsolete("Deprecated in favour of \"MiddleCurlMndx\"")]
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_MIDDLE_CURL_MNDX")]
        ForceFeedbackCurlLocationMiddleCurlMndx = 2,
        [Obsolete("Deprecated in favour of \"RingCurlMndx\"")]
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_RING_CURL_MNDX")]
        ForceFeedbackCurlLocationRingCurlMndx = 3,
        [Obsolete("Deprecated in favour of \"LittleCurlMndx\"")]
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_LITTLE_CURL_MNDX")]
        ForceFeedbackCurlLocationLittleCurlMndx = 4,
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_THUMB_CURL_MNDX")]
        ThumbCurlMndx = 0,
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_INDEX_CURL_MNDX")]
        IndexCurlMndx = 1,
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_MIDDLE_CURL_MNDX")]
        MiddleCurlMndx = 2,
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_RING_CURL_MNDX")]
        RingCurlMndx = 3,
        [NativeName("Name", "XR_FORCE_FEEDBACK_CURL_LOCATION_LITTLE_CURL_MNDX")]
        LittleCurlMndx = 4,
    }
}
