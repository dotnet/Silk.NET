// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemVirtualKeyboardPropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemVirtualKeyboardPropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public StructureType Type = StructureType.TypeSystemVirtualKeyboardPropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public void* Next;

    [NativeName("supportsVirtualKeyboard")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public MaybeBool<uint> SupportsVirtualKeyboard;

    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public SystemVirtualKeyboardPropertiesMETA() { }
}
