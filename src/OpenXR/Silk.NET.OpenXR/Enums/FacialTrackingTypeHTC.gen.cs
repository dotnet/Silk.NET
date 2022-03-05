// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFacialTrackingTypeHTC")]
    public enum FacialTrackingTypeHTC : int
    {
        [NativeName("Name", "XR_FACIAL_TRACKING_TYPE_EYE_DEFAULT_HTC")]
        FacialTrackingTypeEyeDefaultHtc = 1,
        [NativeName("Name", "XR_FACIAL_TRACKING_TYPE_LIP_DEFAULT_HTC")]
        FacialTrackingTypeLipDefaultHtc = 2,
    }
}
