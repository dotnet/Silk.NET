// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemKeyboardTrackingPropertiesFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemKeyboardTrackingPropertiesFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public StructureType Type = StructureType.TypeSystemKeyboardTrackingPropertiesFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public void* Next;

    [NativeName("supportsKeyboardTracking")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public MaybeBool<uint> SupportsKeyboardTracking;

    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public SystemKeyboardTrackingPropertiesFB() { }
}
