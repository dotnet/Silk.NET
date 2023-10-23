// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVirtualKeyboardInputSourceMETA")]
    public enum VirtualKeyboardInputSourceMETA : int
    {
        [Obsolete("Deprecated in favour of \"ControllerRayLeftMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_RAY_LEFT_META")]
        VirtualKeyboardInputSourceControllerRayLeftMeta = 1,
        [Obsolete("Deprecated in favour of \"ControllerRayRightMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_RAY_RIGHT_META")]
        VirtualKeyboardInputSourceControllerRayRightMeta = 2,
        [Obsolete("Deprecated in favour of \"HandRayLeftMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_RAY_LEFT_META")]
        VirtualKeyboardInputSourceHandRayLeftMeta = 3,
        [Obsolete("Deprecated in favour of \"HandRayRightMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_RAY_RIGHT_META")]
        VirtualKeyboardInputSourceHandRayRightMeta = 4,
        [Obsolete("Deprecated in favour of \"ControllerDirectLeftMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_DIRECT_LEFT_META")]
        VirtualKeyboardInputSourceControllerDirectLeftMeta = 5,
        [Obsolete("Deprecated in favour of \"ControllerDirectRightMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_DIRECT_RIGHT_META")]
        VirtualKeyboardInputSourceControllerDirectRightMeta = 6,
        [Obsolete("Deprecated in favour of \"HandDirectIndexTipLeftMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_DIRECT_INDEX_TIP_LEFT_META")]
        VirtualKeyboardInputSourceHandDirectIndexTipLeftMeta = 7,
        [Obsolete("Deprecated in favour of \"HandDirectIndexTipRightMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_DIRECT_INDEX_TIP_RIGHT_META")]
        VirtualKeyboardInputSourceHandDirectIndexTipRightMeta = 8,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_RAY_LEFT_META")]
        ControllerRayLeftMeta = 1,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_RAY_RIGHT_META")]
        ControllerRayRightMeta = 2,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_RAY_LEFT_META")]
        HandRayLeftMeta = 3,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_RAY_RIGHT_META")]
        HandRayRightMeta = 4,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_DIRECT_LEFT_META")]
        ControllerDirectLeftMeta = 5,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_CONTROLLER_DIRECT_RIGHT_META")]
        ControllerDirectRightMeta = 6,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_DIRECT_INDEX_TIP_LEFT_META")]
        HandDirectIndexTipLeftMeta = 7,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_SOURCE_HAND_DIRECT_INDEX_TIP_RIGHT_META")]
        HandDirectIndexTipRightMeta = 8,
    }
}
