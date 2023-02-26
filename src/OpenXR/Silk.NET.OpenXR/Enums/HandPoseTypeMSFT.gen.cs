// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrHandPoseTypeMSFT")]
    public enum HandPoseTypeMSFT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TrackedMsft\"")]
        [NativeName("Name", "XR_HAND_POSE_TYPE_TRACKED_MSFT")]
        HandPoseTypeTrackedMsft = 0,
        [Obsolete("Deprecated in favour of \"ReferenceOpenPalmMsft\"")]
        [NativeName("Name", "XR_HAND_POSE_TYPE_REFERENCE_OPEN_PALM_MSFT")]
        HandPoseTypeReferenceOpenPalmMsft = 1,
        [NativeName("Name", "XR_HAND_POSE_TYPE_TRACKED_MSFT")]
        TrackedMsft = 0,
        [NativeName("Name", "XR_HAND_POSE_TYPE_REFERENCE_OPEN_PALM_MSFT")]
        ReferenceOpenPalmMsft = 1,
    }
}
