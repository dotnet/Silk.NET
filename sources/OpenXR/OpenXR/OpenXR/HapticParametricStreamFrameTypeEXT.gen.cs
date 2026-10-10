// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHapticParametricStreamFrameTypeEXT")]
[SupportedApiProfile("openxr")]
public enum HapticParametricStreamFrameTypeEXT : uint
{
    [NativeName("XR_HAPTIC_PARAMETRIC_STREAM_FRAME_TYPE_NONE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    None = 0,

    [NativeName("XR_HAPTIC_PARAMETRIC_STREAM_FRAME_TYPE_FIRST_FRAME_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    FirstFrame = 1,

    [NativeName("XR_HAPTIC_PARAMETRIC_STREAM_FRAME_TYPE_INTERMEDIATE_FRAME_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    IntermediateFrame = 2,

    [NativeName("XR_HAPTIC_PARAMETRIC_STREAM_FRAME_TYPE_LAST_FRAME_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    LastFrame = 3,
}
