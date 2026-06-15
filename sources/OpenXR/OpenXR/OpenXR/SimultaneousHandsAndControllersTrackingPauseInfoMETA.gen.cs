// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSimultaneousHandsAndControllersTrackingPauseInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SimultaneousHandsAndControllersTrackingPauseInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    public StructureType Type =
        StructureType.TypeSimultaneousHandsAndControllersTrackingPauseInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    public void* Next;

    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    public SimultaneousHandsAndControllersTrackingPauseInfoMETA() { }
}
