// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyJointConfidenceHTC")]
    public enum BodyJointConfidenceHTC : int
    {
        [Obsolete("Deprecated in favour of \"NoneHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_CONFIDENCE_NONE_HTC")]
        BodyJointConfidenceNoneHtc = 0,
        [Obsolete("Deprecated in favour of \"LowHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_CONFIDENCE_LOW_HTC")]
        BodyJointConfidenceLowHtc = 1,
        [Obsolete("Deprecated in favour of \"HighHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_CONFIDENCE_HIGH_HTC")]
        BodyJointConfidenceHighHtc = 2,
        [NativeName("Name", "XR_BODY_JOINT_CONFIDENCE_NONE_HTC")]
        NoneHtc = 0,
        [NativeName("Name", "XR_BODY_JOINT_CONFIDENCE_LOW_HTC")]
        LowHtc = 1,
        [NativeName("Name", "XR_BODY_JOINT_CONFIDENCE_HIGH_HTC")]
        HighHtc = 2,
    }
}
