// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackingDataSourceEXT")]
[SupportedApiProfile("openxr")]
public enum HandTrackingDataSourceEXT : uint
{
    [NativeName("XR_HAND_TRACKING_DATA_SOURCE_UNOBSTRUCTED_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Unobstructed = 1,

    [NativeName("XR_HAND_TRACKING_DATA_SOURCE_CONTROLLER_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Controller = 2,
}
