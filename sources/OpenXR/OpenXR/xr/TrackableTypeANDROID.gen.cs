// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableTypeANDROID")]
[SupportedApiProfile("openxr")]
public enum TrackableTypeANDROID : uint
{
    [NativeName("XR_TRACKABLE_TYPE_NOT_VALID_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    NotValid = 0,

    [NativeName("XR_TRACKABLE_TYPE_PLANE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    Plane = 1,

    [NativeName("XR_TRACKABLE_TYPE_DEPTH_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    Depth = 1000463000,

    [NativeName("XR_TRACKABLE_TYPE_OBJECT_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    Object = 1000466000,

    [NativeName("XR_TRACKABLE_TYPE_MARKER_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    Marker = 1000707000,

    [NativeName("XR_TRACKABLE_TYPE_QR_CODE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    QrCode = 1000708000,

    [NativeName("XR_TRACKABLE_TYPE_IMAGE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    Image = 1000709000,
}
