// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrAnchorPersistStateANDROID")]
[SupportedApiProfile("openxr")]
public enum AnchorPersistStateANDROID : uint
{
    [NativeName("XR_ANCHOR_PERSIST_STATE_PERSIST_NOT_REQUESTED_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    PersistNotRequested = 0,

    [NativeName("XR_ANCHOR_PERSIST_STATE_PERSIST_PENDING_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    PersistPending = 1,

    [NativeName("XR_ANCHOR_PERSIST_STATE_PERSISTED_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    Persisted = 2,
}
