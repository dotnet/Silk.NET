// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardSpaceCreateInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VirtualKeyboardSpaceCreateInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public StructureType Type = StructureType.VirtualKeyboardSpaceCreateInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public void* Next;

    [NativeName("locationType")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardLocationTypeMETA LocationType;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public SpaceHandle Space;

    [NativeName("poseInSpace")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public Posef PoseInSpace;

    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardSpaceCreateInfoMETA() { }
}
