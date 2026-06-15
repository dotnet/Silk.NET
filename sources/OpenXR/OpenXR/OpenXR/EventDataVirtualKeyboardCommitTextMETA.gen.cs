// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataVirtualKeyboardCommitTextMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataVirtualKeyboardCommitTextMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public StructureType Type = StructureType.TypeEventDataVirtualKeyboardCommitTextMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public void* Next;

    [NativeName("keyboard")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardHandleMETA Keyboard;

    [NativeName("text")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public EventDataVirtualKeyboardCommitTextMETAText Text;

    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public EventDataVirtualKeyboardCommitTextMETA() { }
}
