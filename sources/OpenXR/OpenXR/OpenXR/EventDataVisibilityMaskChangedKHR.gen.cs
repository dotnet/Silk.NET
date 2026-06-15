// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataVisibilityMaskChangedKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataVisibilityMaskChangedKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public StructureType Type = StructureType.TypeEventDataVisibilityMaskChangedKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public void* Next;

    [NativeName("session")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public SessionHandle Session;

    [NativeName("viewConfigurationType")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public ViewConfigurationType ViewConfigurationType;

    [NativeName("viewIndex")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public uint ViewIndex;

    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public EventDataVisibilityMaskChangedKHR() { }
}
