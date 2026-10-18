// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionType")]
[SupportedApiProfile("openxr")]
public enum ActionType : uint
{
    [NativeName("XR_ACTION_TYPE_BOOLEAN_INPUT")]
    [SupportedApiProfile("openxr")]
    BooleanInput = 1,

    [NativeName("XR_ACTION_TYPE_FLOAT_INPUT")]
    [SupportedApiProfile("openxr")]
    FloatInput = 2,

    [NativeName("XR_ACTION_TYPE_VECTOR2F_INPUT")]
    [SupportedApiProfile("openxr")]
    Vector2FInput = 3,

    [NativeName("XR_ACTION_TYPE_POSE_INPUT")]
    [SupportedApiProfile("openxr")]
    PoseInput = 4,

    [NativeName("XR_ACTION_TYPE_VIBRATION_OUTPUT")]
    [SupportedApiProfile("openxr")]
    VibrationOutput = 100,
}
