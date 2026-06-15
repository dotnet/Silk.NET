// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardInputSourceMETA")]
[SupportedApiProfile("openxr")]
public enum VirtualKeyboardInputSourceMETA : uint
{
    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_RAY_LEFT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    ControllerRayLeft = 1,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_RAY_RIGHT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    ControllerRayRight = 2,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_RAY_LEFT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    HandRayLeft = 3,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_RAY_RIGHT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    HandRayRight = 4,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_DIRECT_LEFT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    ControllerDirectLeft = 5,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_DIRECT_RIGHT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    ControllerDirectRight = 6,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_DIRECT_INDEX_TIP_LEFT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    HandDirectIndexTipLeft = 7,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_DIRECT_INDEX_TIP_RIGHT_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    HandDirectIndexTipRight = 8,
}
