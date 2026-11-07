// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialTrackingTypeHTC")]
[SupportedApiProfile("openxr")]
public enum FacialTrackingTypeHTC : uint
{
    [NativeName("XR_FACIAL_TRACKING_TYPE_EYE_DEFAULT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    EyeDefault = 1,

    [NativeName("XR_FACIAL_TRACKING_TYPE_LIP_DEFAULT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LipDefault = 2,
}
