// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrVirtualKeyboardInputStateFlagsMETA")]
    public enum VirtualKeyboardInputStateFlagsMETA : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PressedBitMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_STATE_PRESSED_BIT_META")]
        VirtualKeyboardInputStatePressedBitMeta = 1,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_INPUT_STATE_PRESSED_BIT_META")]
        PressedBitMeta = 1,
    }
}
