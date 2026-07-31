// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemEyeTrackingPropertiesFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemEyeTrackingPropertiesFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public StructureType Type = StructureType.SystemEyeTrackingPropertiesFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public void* Next;

    [NativeName("supportsEyeTracking")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public MaybeBool<uint> SupportsEyeTracking;

    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public SystemEyeTrackingPropertiesFB() { }
}
