// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EyesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public StructureType Type = StructureType.EyesANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public void* Next;

    [NativeName("eyes")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public EyesANDROIDEyes Eyes;

    [NativeName("mode")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public EyeTrackingModeANDROID Mode;

    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public EyesANDROID() { }
}
