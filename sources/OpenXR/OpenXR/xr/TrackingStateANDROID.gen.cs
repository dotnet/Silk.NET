// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackingStateANDROID")]
[SupportedApiProfile("openxr")]
public enum TrackingStateANDROID : uint
{
    [NativeName("XR_TRACKING_STATE_PAUSED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    Paused = 0,

    [NativeName("XR_TRACKING_STATE_STOPPED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    Stopped = 1,

    [NativeName("XR_TRACKING_STATE_TRACKING_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    Tracking = 2,
}
