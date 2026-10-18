// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrKeyboardTrackingDescriptionFB")]
[SupportedApiProfile("openxr")]
public partial struct KeyboardTrackingDescriptionFB
{
    [NativeName("trackedKeyboardId")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public ulong TrackedKeyboardId;

    [NativeName("size")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public Vector3F Size;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public KeyboardTrackingFlagsFB Flags;

    [NativeName("name")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public KeyboardTrackingDescriptionFBName Name;
}
