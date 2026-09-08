// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyeIndexANDROID")]
[SupportedApiProfile("openxr")]
public enum EyeIndexANDROID : uint
{
    [NativeName("XR_EYE_INDEX_LEFT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    Left = 0,

    [NativeName("XR_EYE_INDEX_RIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    Right = 1,
}
