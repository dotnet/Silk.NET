// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemEyeTrackingPropertiesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemEyeTrackingPropertiesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public StructureType Type = StructureType.SystemEyeTrackingPropertiesANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public void* Next;

    [NativeName("supportsEyeTracking")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public MaybeBool<uint> SupportsEyeTracking;

    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public SystemEyeTrackingPropertiesANDROID() { }
}
