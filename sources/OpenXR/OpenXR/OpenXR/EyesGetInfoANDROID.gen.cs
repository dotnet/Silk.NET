// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyesGetInfoANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EyesGetInfoANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public StructureType Type = StructureType.EyesGetInfoANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public void* Next;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public long Time;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public SpaceHandle BaseSpace;

    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public EyesGetInfoANDROID() { }
}
