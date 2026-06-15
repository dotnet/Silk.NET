// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataDisplayRefreshRateChangedFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataDisplayRefreshRateChangedFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    public StructureType Type = StructureType.TypeEventDataDisplayRefreshRateChangedFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    public void* Next;

    [NativeName("fromDisplayRefreshRate")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    public float FromDisplayRefreshRate;

    [NativeName("toDisplayRefreshRate")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    public float ToDisplayRefreshRate;

    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    public EventDataDisplayRefreshRateChangedFB() { }
}
