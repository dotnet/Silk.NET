// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardInputInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VirtualKeyboardInputInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public StructureType Type = StructureType.VirtualKeyboardInputInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public void* Next;

    [NativeName("inputSource")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardInputSourceMETA InputSource;

    [NativeName("inputSpace")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public SpaceHandle InputSpace;

    [NativeName("inputPoseInSpace")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public Posef InputPoseInSpace;

    [NativeName("inputState")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardInputStateFlagsMETA InputState;

    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardInputInfoMETA() { }
}
