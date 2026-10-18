// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughCameraStateANDROID")]
[SupportedApiProfile("openxr")]
public enum PassthroughCameraStateANDROID : uint
{
    [NativeName("XR_PASSTHROUGH_CAMERA_STATE_DISABLED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    Disabled = 0,

    [NativeName("XR_PASSTHROUGH_CAMERA_STATE_INITIALIZING_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    Initializing = 1,

    [NativeName("XR_PASSTHROUGH_CAMERA_STATE_READY_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    Ready = 2,

    [NativeName("XR_PASSTHROUGH_CAMERA_STATE_ERROR_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    Error = 3,
}
