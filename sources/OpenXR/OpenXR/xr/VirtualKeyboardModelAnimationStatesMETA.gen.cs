// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardModelAnimationStatesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VirtualKeyboardModelAnimationStatesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public StructureType Type = StructureType.VirtualKeyboardModelAnimationStatesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public void* Next;

    [NativeName("stateCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public uint StateCapacityInput;

    [NativeName("stateCountOutput")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public uint StateCountOutput;

    [NativeName("states")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardAnimationStateMETA* States;

    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardModelAnimationStatesMETA() { }
}
