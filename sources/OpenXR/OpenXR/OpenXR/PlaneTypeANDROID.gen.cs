// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneTypeANDROID")]
[SupportedApiProfile("openxr")]
public enum PlaneTypeANDROID : uint
{
    [NativeName("XR_PLANE_TYPE_HORIZONTAL_DOWNWARD_FACING_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    HorizontalDownwardFacing = 0,

    [NativeName("XR_PLANE_TYPE_HORIZONTAL_UPWARD_FACING_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    HorizontalUpwardFacing = 1,

    [NativeName("XR_PLANE_TYPE_VERTICAL_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    Vertical = 2,

    [NativeName("XR_PLANE_TYPE_ARBITRARY_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    Arbitrary = 3,
}
