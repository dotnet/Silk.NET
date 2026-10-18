// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRaycastHitResultANDROID")]
[SupportedApiProfile("openxr")]
public partial struct RaycastHitResultANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public TrackableTypeANDROID Type;

    [NativeName("trackable")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public ulong Trackable;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public Posef Pose;
}
