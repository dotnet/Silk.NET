// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemPassthroughCameraStatePropertiesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemPassthroughCameraStatePropertiesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    public StructureType Type = StructureType.SystemPassthroughCameraStatePropertiesANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    public void* Next;

    [NativeName("supportsPassthroughCameraState")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    public MaybeBool<uint> SupportsPassthroughCameraState;

    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    public SystemPassthroughCameraStatePropertiesANDROID() { }
}
