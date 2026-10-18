// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrKeyboardSpaceCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct KeyboardSpaceCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public StructureType Type = StructureType.KeyboardSpaceCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public void* Next;

    [NativeName("trackedKeyboardId")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public ulong TrackedKeyboardId;

    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public KeyboardSpaceCreateInfoFB() { }
}
