// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandPoseTypeMSFT")]
    public enum HandPoseTypeMSFT : int
    {
        [NativeName("Name", "XR_HAND_POSE_TYPE_TRACKED_MSFT")]
        HandPoseTypeTrackedMsft = 0,
        [NativeName("Name", "XR_HAND_POSE_TYPE_REFERENCE_OPEN_PALM_MSFT")]
        HandPoseTypeReferenceOpenPalmMsft = 1,
    }
}
